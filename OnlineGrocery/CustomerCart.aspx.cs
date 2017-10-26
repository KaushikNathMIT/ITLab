﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class CustomerCart : System.Web.UI.Page
{
	private string orderID=null;
	private string productid;
	protected void Page_PreLoad(object sender, EventArgs e)
	{
		/*
		if (orderID == null)
		{
			orderID = GenerateNewOrderID();
		}
		orderid.Text = orderID;
		this.DataBind();
		*/
	}
	protected void Page_Load(object sender, EventArgs e)
	{
		cust_id_label.Text = Session["custid"].ToString();
		orderID = Request.QueryString["orderid"];
		orderid.Text = orderID;
		//this.DataBind();
	}

	

	protected void btn_add_Click(object sender, EventArgs e)
	{
		SqlConnection connection = new SqlConnection();
		connection.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
		Debug.WriteLine(dpd_list_prod.SelectedValue);
		SqlCommand command = new SqlCommand("insert into [Order] values ('" + orderID + "','" + dpd_list_prod.SelectedValue + "','" + tb_quantity.Text + "')", connection);
		connection.Open();
		using (connection)
		{
			command.ExecuteNonQuery();
		}
		this.DataBind();
	}

	protected void checkout_button_Click(object sender, EventArgs e)
	{
		Response.Redirect("CustomerHome.aspx");
	}
}