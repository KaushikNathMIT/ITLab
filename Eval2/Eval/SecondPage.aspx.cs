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
        label_second.Text = "" + Session["message"];
        
        if (Request.QueryString["BorderStyle"].ToString().Equals("Dashed"))
            label_second.BorderStyle = BorderStyle.Dashed;
        else label_second.BorderStyle = BorderStyle.Dotted;
        
        /*
        int res;
        int.TryParse(Request.QueryString["BorderStyle"].ToString(), out res);
        label_second.BorderStyle = (BorderStyle) res;
        */
    }
}