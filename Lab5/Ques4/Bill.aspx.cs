using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bill : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int quantity = (int)Session["quantity"];
        label_bill.Text = "The bill is as follows\n" + Session["item"] + "\t(" + quantity + ")\tRs." + quantity * 1000;
    }
}