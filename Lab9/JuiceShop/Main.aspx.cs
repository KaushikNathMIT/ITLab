using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Data;
using System.Web.Configuration;

public partial class Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con;
        if (!IsPostBack)
        {
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM FRUITS", con);
                da = new SqlDataAdapter(command);
                da.Fill(ds, "Fruits");
                SqlCommand command1 = new SqlCommand("select * from IceCreams", con);
                da = new SqlDataAdapter(command1);
                da.Fill(ds1, "IceCreams");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            foreach (DataRow row in ds.Tables["Fruits"].Rows)
            {
                ListItem ls = new ListItem();
                ls.Text = row["FruitName"].ToString();
                ls.Value = row["Cost"].ToString();
                checkboxlist1.Items.Add(ls);
            }
            foreach (DataRow row in ds1.Tables["IceCreams"].Rows)
            {
                ListItem ls = new ListItem();
                ls.Text = row["Name"].ToString();
                ls.Value = row["Cost"].ToString();
                RadioButtonList1.Items.Add(ls);
            }
            this.DataBind();

        }
    }
    protected void btn_click(object sender, EventArgs e)
    {
        if (checkboxlist1 != null)
        {
            string s = "Milk Shake of " + checkboxlist1.SelectedItem.Text + " with " + RadioButtonList1.SelectedItem.Text + " Ice-Creams\n Cost=";
            int val2 = int.Parse(RadioButtonList1.SelectedValue);
            int val1 = int.Parse(checkboxlist1.SelectedValue);
            int val = val1 + val2;
            s += val.ToString();

            label1.Text = s;

        }
    }
}