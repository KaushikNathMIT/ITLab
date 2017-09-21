using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Web.SessionState;

public partial class _Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		
	}
	public void AttemptLogin(object sender, EventArgs e) {
		string userName = username.Text;
		string pass = password.Text;
		if (userName.Equals("123") && pass.Equals("pwd")) {
			//message.Text = "Correct credentials";
			Session["secured_message"] = userName;
			Response.Redirect("Success.aspx");
		} else {
			message.Text = "Wrong credentials";
		}
	}
}