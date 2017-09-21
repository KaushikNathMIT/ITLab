using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SecondPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        label_prev_page.Text = "Name :" + Session["Name"] + "\nRoll :" + Session["Roll"] + "\nSubject:" + Session["Subject"];
        HttpCookie cookie = new HttpCookie("Counter");
        cookie["counter"] = "0";
        label_cnt_val.Text = "0";
        Response.Cookies.Add(cookie);
    }
    protected void buttonClicked(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["Counter"];
        if(cookie!=null)
        {
            int counter = int.Parse(cookie["counter"]);
            counter++;
            cookie["counter"] = counter.ToString();
            Response.Cookies.Add(cookie);
            label_cnt_val.Text = cookie["counter"];
        }
    }
}