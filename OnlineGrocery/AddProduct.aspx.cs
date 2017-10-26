using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddProduct : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if(!IsPostBack)
		{
			rbl_prod.Items.Add("TRUE");
			rbl_prod.Items.Add("FALSE");
		}
	}

	protected void btn_add_product_Click(object sender, EventArgs e)
	{
		try
		{
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
			SqlCommand command = new SqlCommand("insert into Product values('" + tb_pid.Text + "','" + tb_pname.Text+ "','" + rbl_prod.SelectedValue + "','" + tb_price.Text + "')", connection);
			connection.Open();
			using (connection)
			{
				command.ExecuteNonQuery();
			}
			Response.Redirect(Request.RawUrl);
		}
		catch(Exception e1) { }
	}
}