using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if(!IsPostBack)
		{
			dpd.Items.Add("Email");
			dpd.Items.Add("Phone");
			dpd.Items.Add("UserID");
		}
	}

	protected void Unnamed_ServerValidate(object source, ServerValidateEventArgs args)
	{
		String text = args.Value;
		if(dpd.SelectedItem.ToString().Equals("Email"))
		{
			if (!text.Contains("@")) args.IsValid = false;
			else args.IsValid = true;
		}
	}

	protected void btn_Click(object sender, EventArgs e)
	{
		this.Validate();
	}
}