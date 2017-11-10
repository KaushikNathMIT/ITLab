using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{

		}
	}

	protected void gv1_RowDataBound(object sender, GridViewRowEventArgs e)
	{
		if (e.Row.RowState == DataControlRowState.Edit)
			e.Row.BackColor = Color.Yellow;
		if (e.Row.RowType == DataControlRowType.DataRow)
			if ((int)DataBinder.Eval(e.Row.DataItem, "age") > 35)
			{
				e.Row.BackColor = Color.Beige;
			}
	}

}