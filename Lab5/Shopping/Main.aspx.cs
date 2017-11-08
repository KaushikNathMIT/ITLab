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
		HttpCookie httpCookie;
		if (!IsPostBack)
		{
			if (Request.Cookies["pref"] == null)
			{
				httpCookie = new HttpCookie("pref");
				httpCookie["numLaptop"] = "0";
				httpCookie["numMobile"] = "0";
				httpCookie.Expires = DateTime.Now.AddYears(2);
				Response.Cookies.Add(httpCookie);
			}
			else httpCookie = Request.Cookies["pref"];
			dpd_prod.Items.Add("Laptop");
			dpd_prod.Items.Add("Mobile");
		}
		else httpCookie = Request.Cookies["pref"];
		label_cart_details.Text = "Laptops : " + httpCookie["numLaptop"] + "\t Mobiles : " + httpCookie["numMobile"];
	}

	protected void add_Click(object sender, EventArgs e)
	{
		HttpCookie httpCookie = Request.Cookies["pref"];
		int quantity = int.Parse(tb_quant.Text);
		if (dpd_prod.SelectedItem.ToString().Equals("Laptop"))
		{
			httpCookie["numLaptop"] = (int.Parse(httpCookie["numLaptop"]) + quantity).ToString();
		}
		else if (dpd_prod.SelectedItem.ToString().Equals("Mobile"))
		{
			httpCookie["numMobile"] = (int.Parse(httpCookie["numMobile"]) + quantity).ToString();
		}
		httpCookie.Expires = DateTime.Now.AddYears(2);
		Response.Cookies.Add(httpCookie);
		label_cart_details.Text = "Laptops : " + httpCookie["numLaptop"] + "\t Mobiles : " + httpCookie["numMobile"];
	}
}