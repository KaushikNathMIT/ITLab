using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if(!IsPostBack)
        {
            Dictionary<int, string> states = new Dictionary<int, string>();
            states.Add(1, "Jharkhand");
            states.Add(2, "Madhya Pradesh");
            dpd1.DataSource = states;
            dpd1.DataTextField = "value";
            dpd1.DataValueField = "key";
            dpd1.Items.Insert(0, new ListItem("Select State", "0"));
            this.DataBind();
        }
        this.DataBind();
    }

    protected void dpd1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.DataBind();
    }
}