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
        BorderStyle bs;
        bdstyle.Items.Add(BorderStyle.Dashed.ToString());
        bdstyle.Items.Add(BorderStyle.Dotted.ToString());
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        Session["message"] = tb_message.Text;
        Response.Redirect("SecondPage.aspx?BorderStyle=" + bdstyle.SelectedItem.ToString());
        /*
        if(bdstyle.SelectedIndex==0)
            Response.Redirect("SecondPage.aspx?BorderStyle=" + BorderStyle.Dashed);
        else
            Response.Redirect("SecondPage.aspx?BorderStyle=" + BorderStyle.Dotted);
            */
    }
}