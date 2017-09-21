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
        if(!IsPostBack)
        {
            dpd_list.Items.Add("");
            dpd_list.Items.Add("Maruti");
            dpd_list.Items.Add("Hyundai");
        }
    }
    protected void manufacturerSelected(object sender, EventArgs e)
    {
        Console.WriteLine("here");
        Response.Redirect("SecondPage.aspx?manu="+dpd_list.SelectedItem.ToString()+"&model="+tb_model.Text);
    }
}