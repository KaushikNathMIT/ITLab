using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VendorHome : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void del_status_Click(object sender, EventArgs e)
	{
		Response.Redirect("VendorPending.aspx");
	}

	protected void update_quantity_Click(object sender, EventArgs e)
	{
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
		SqlCommand command = new SqlCommand("update Quantity set quant=" + tb_quantity.Text, connection);
		connection.Open();
		using (connection)
		{
			command.ExecuteNonQuery();
			tb_quantity.Text = "";
		}
	}
}