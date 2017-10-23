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

    }

    protected void lb_1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("Page2.aspx?name=" + lb_1.SelectedItem.Text);
    }
}