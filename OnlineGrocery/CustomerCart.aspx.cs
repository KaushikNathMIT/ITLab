using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class CustomerCart : System.Web.UI.Page
{
	private string orderID=null;
	private int quantity = 0, price=0;
	private string productid;
	protected void Page_PreLoad(object sender, EventArgs e)
	{
		/*
		if (orderID == null)
		{
			orderID = GenerateNewOrderID();
		}
		orderid.Text = orderID;
		this.DataBind();
		*/
	}
	protected void Page_Load(object sender, EventArgs e)
	{
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
		Debug.WriteLine(dpd_list_prod.SelectedValue);
		SqlCommand command = new SqlCommand("select top(1) quant from Quantity", connection);
		connection.Open();
		using (connection)
		{
			SqlDataReader sqlDataReader = command.ExecuteReader();
			while(sqlDataReader.Read())
			{
				quantity=(int)sqlDataReader[0];
			}
		}
		cust_id_label.Text = Session["custid"].ToString();
		orderID = Request.QueryString["orderid"];
		orderid.Text = orderID;
		//this.DataBind();
	}

	

	protected void btn_add_Click(object sender, EventArgs e)
	{
		int quant = 0;
		try
		{
			quant = int.Parse(Session["quant"].ToString());
		}
		catch(Exception ex)
		{

		}
		quant+=int.Parse(tb_quantity.Text);
		Session["quant"] = quant;
		if (quant < quantity)
		{
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
			Debug.WriteLine(dpd_list_prod.SelectedValue);
			SqlCommand command = new SqlCommand("insert into [Order] values ('" + orderID + "','" + dpd_list_prod.SelectedValue + "','" + tb_quantity.Text + "')", connection);
			SqlCommand command2 = new SqlCommand("select top(1) price from Product where productName='" + dpd_list_prod.SelectedValue + "'",connection);
			connection.Open();
			using (connection)
			{
				command.ExecuteNonQuery();
				SqlDataReader sqlDataReader = command2.ExecuteReader();
				while (sqlDataReader.Read())
				{
					price += ((int)sqlDataReader[0])*int.Parse(tb_quantity.Text);
				}
			}
			this.DataBind();
			label_error.Text = "Total price is "+price;
		}
		else
		{
			label_error.Text = "Inventory getting full. Can't add more products";
		}
	}

	protected void checkout_button_Click(object sender, EventArgs e)
	{
		Response.Redirect("CustomerHome.aspx");
	}
}