using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(PreviousPage!=null)
        {
            label_welcome_message.Text = "Welcome " + ((TextBox)PreviousPage.FindControl("tb_user_name")).Text
                +"\nEmail Id " + ((TextBox)PreviousPage.FindControl("tb_email_id")).Text + "\nContactNumber "+((TextBox)PreviousPage.FindControl("tb_contact_number")).Text;
        }
    }
}