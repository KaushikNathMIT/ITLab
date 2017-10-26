using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteProduct : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if(!IsPostBack)
		{
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
			SqlCommand sqlCommand = new SqlCommand("select productname from Product",connection);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet, "productName");
			lb_prod.DataSource = dataSet;
			lb_prod.DataTextField = "productName";
			lb_prod.DataBind();
		}

	}

	protected void button_del_prod_Click(object sender, EventArgs e)
	{
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
		SqlCommand sqlCommand = new SqlCommand("delete from Product where productName='"+lb_prod.SelectedValue.Trim()+"'",connection);
		connection.Open();
		try
		{
			sqlCommand.ExecuteNonQuery();
			Response.Redirect(Request.RawUrl);
		}
		catch(Exception e1) { }
	}
}