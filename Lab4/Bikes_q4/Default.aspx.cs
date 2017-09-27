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

    protected void Button1_Click(object sender, EventArgs e)
    {
        Image1.ImageUrl = DropDownList1.SelectedValue + ".jpg";
        String details = "";
        details += "Name: " + TextBox1.Text +
                    ", Bike: " + DropDownList1.SelectedValue +
                    ", Date: " + Calendar1.SelectedDate.ToLongDateString();
        Label3.Text = "Final Details: " + details;
        
    }
}