using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void theme_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["chosenTheme"] = theme.SelectedValue;
        Response.Redirect(Request.RawUrl);
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["chosenTheme"] != null && (string)Session["chosenTheme"] != "NA")
        {
            Page.Theme = Session["chosenTheme"].ToString();
        }
    }
}
