using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void buttonClicked(object sender, EventArgs e)
    {
        if (tb_user_name.Text.Trim().Equals(""))
        {
            label_message.Text = "User Name can't be empty";
        }
        else
        {
            button_submit.PostBackUrl = "Success.aspx";
        }
    }
}