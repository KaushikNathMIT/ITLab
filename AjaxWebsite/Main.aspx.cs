using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			Session["custid"] = -1;
			HttpCookie httpCookie = new HttpCookie("pref");
			httpCookie["num"] = "-1";
			Response.Cookies.Add(httpCookie);
			rb_list.Items.Add("Male");
			rb_list.Items.Add("Female");
			dpd_list.Items.Add("Select preferred payment method");
			dpd_list.Items.Add("Online Payment");
			dpd_list.Items.Add("Cash On Delivery");
		}
	}

	protected void button_submit_Click(object sender, EventArgs e)
	{
		this.Validate();
		if (IsValid)
		{
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
			string s = "insert into Customer values(" + getNewCustomerID() + ", '" + tb_name.Text + "', '" + rb_list.SelectedValue + "', '" + dpd_list.SelectedValue + "')";
			SqlCommand command = new SqlCommand(s, connection);
			connection.Open();
			using (connection)
			{
				command.ExecuteNonQuery();
			}
			HttpCookie httpCookie = Request.Cookies["pref"];
			label_num.Text = httpCookie["num"];
			this.DataBind();
		}
	}

	private int getNewCustomerID()
	{
		int currNum = int.Parse(Session["custid"].ToString());
		currNum++;
		HttpCookie httpCookie = Request.Cookies["pref"];
		httpCookie["num"] = currNum.ToString();
		Session["custid"] = currNum;
		return currNum;
	}
}