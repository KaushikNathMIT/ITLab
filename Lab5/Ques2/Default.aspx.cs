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
        if (!IsPostBack)
        {
            dpd_list.Items.Add("English");
            dpd_list.Items.Add("Mathematics");
            dpd_list.Items.Add("Science");
        }
    }

    protected void buttonClicked(object sender, EventArgs e)
    {
        Session["Subject"] = dpd_list.SelectedItem.ToString();
        Session["Name"] = tb_name.Text;
        Session["Roll"] = tb_roll.Text;
        Response.Redirect("SecondPage.aspx");
    }
}