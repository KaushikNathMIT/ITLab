using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SecondPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        label_manufacturer.Text = "The manufacturer is " + Request.QueryString["manu"] + " and the model is " + Request.QueryString["model"];
    }
}