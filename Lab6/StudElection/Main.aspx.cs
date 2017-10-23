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
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            dpd_list.Items.Add("");
            dpd_list.Items.Add("Kaushik");
            dpd_list.Items.Add("Ojasva");
            dpd_list.Items.Add("Kanav");
            rbl_house.Items.Add("Red");
            rbl_house.Items.Add("Blue");
        }
    }

    protected void button_submit_Click(object sender, EventArgs e)
    {
        Page.Validate();
    }

    protected void cval_ServerValidate(object source, ServerValidateEventArgs args)
    {
        System.Diagnostics.Debug.WriteLine(args.Value);
        if (args.Value.Length != 10)
        {
            args.IsValid = false;
        }
        else
        {
            try
            {
                long.Parse(args.Value);
                args.IsValid = true;
            }
            catch (Exception e)
            {
                args.IsValid=false;
            }
        }
    }
}