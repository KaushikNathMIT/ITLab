using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerHome : System.Web.UI.Page
{
	private string orderID;
	protected void Page_PreInit(object sender, EventArgs e)
	{
		Page.Theme = "ThemeMain";
	}
	protected void Page_Load(object sender, EventArgs e)
	{
		orderID = GenerateNewOrderID();
	}

	private void updateOrderStatusTable()
	{
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
		SqlCommand command = new SqlCommand("insert into OrderStatus values('" + orderID + "','PENDING')", connection);
		connection.Open();
		using (connection)
		{
			command.ExecuteNonQuery();
		}
	}

	private string GenerateNewOrderID()
	{
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
		SqlCommand command = new SqlCommand("select distinct orderid from [Order]", connection);
		connection.Open();
		using (connection)
		{
			SqlDataReader sqlDataReader = command.ExecuteReader();
			int count = 0;
			while (sqlDataReader.Read())
			{
				count++;
			}

			return "Order" + count;
		}
	}

	protected void check_status_Click(object sender, EventArgs e)
	{

	}

	protected void place_order_Click(object sender, EventArgs e)
	{
		this.Validate();
		if (IsValid)
		{
			Session["custid"] = tb_cust_id.Text;
			updateCustomerTable();
			updateOrderStatusTable();
			Response.Redirect("CustomerCart.aspx?orderid=" + orderID);
		}
	}

	private void updateCustomerTable()
	{
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
		try
		{
			SqlCommand command = new SqlCommand("insert into Customer values('" + tb_cust_id.Text + "','" + orderID + "')", connection);
			connection.Open();
			using (connection)
			{
				command.ExecuteNonQuery();
			}
		}
		catch (Exception e)
		{

		}
	}
}