using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VendorPending : System.Web.UI.Page
{
	private int nVans;

	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void btn_ff_Click(object sender, EventArgs e)
	{
		nVans = getNumberofVans();
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
		SqlCommand command = new SqlCommand("update top(" + nVans + ") OrderStatus set status='Delivered' where status='Pending'", connection);
		connection.Open();
		using (connection)
		{
			command.ExecuteNonQuery();
		}
		this.DataBind();
	}

	private int getNumberofVans()
	{
		int count = 0;
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
		SqlCommand command = new SqlCommand("select * from  vehicles", connection);
		connection.Open();
		using (connection)
		{
			SqlDataReader sqlDataReader = command.ExecuteReader();
			while (sqlDataReader.Read()) count++;
		}
		return count;
	}
}