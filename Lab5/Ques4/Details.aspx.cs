using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //dpd_list.DataSource = new String[] {"HP","Nokia","Samsung"};
        dpd_list.Items.Add("HP");
        dpd_list.Items.Add("Nokia");
        dpd_list.Items.Add("Samsung");
        cb_list.Items.Add("Mobile");
        cb_list.Items.Add("Laptop");
    }
    protected void produceBill(object sender, EventArgs e)
    {
        Session["item"] = dpd_list.Items[dpd_list.SelectedIndex];
        Session["quantity"] = int.Parse(tb_quantity.Text); 
        Response.Redirect("Bill.aspx");
    }
}