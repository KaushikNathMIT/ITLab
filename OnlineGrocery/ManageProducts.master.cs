using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManageProducts : System.Web.UI.MasterPage
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void btn_add_pr_Click(object sender, EventArgs e)
	{
		Response.Redirect("AddProduct.aspx");
	}

	protected void btn_delete_pr_Click(object sender, EventArgs e)
	{
		Response.Redirect("DeleteProduct.aspx");
	}
}
