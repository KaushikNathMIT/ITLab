using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
			foreach (KnownColor r in Enum.GetValues(typeof(KnownColor)))
			{
				ListItem item = new ListItem(Enum.GetName(typeof(KnownColor), r), r.ToString());
				dpd_bg_color.Items.Add(item);
				dpd_font_color.Items.Add(item);
			}

			DirectoryInfo diFiles = new DirectoryInfo(Server.MapPath("~/bgImages/"));
			dpd_image.DataSource = diFiles.GetFiles("*.jpg");
			dpd_image.DataBind();
		}
	}

	protected void dpd_image_SelectedIndexChanged(object sender, EventArgs e)
	{

	}

	protected void dpd_bg_color_SelectedIndexChanged(object sender, EventArgs e)
	{

	}

	protected void apply_Click(object sender, EventArgs e)
	{
		//preview.Style[HtmlTextWriterStyle.BackgroundColor] = backgroundList.SelectedItem.Value;
		CoverImage.ImageUrl = "~/bgImages/" + dpd_image.SelectedItem.Text; ;
		CoverImage.Style[HtmlTextWriterStyle.BorderColor] = dpd_bg_color.SelectedItem.Value;
		CoverBody.Style[HtmlTextWriterStyle.Color] = dpd_font_color.SelectedItem.Value;
		CoverBody.Text = "Hello";
		int fontSize;
		if (int.TryParse(tb_font_size.Text, out fontSize))
		{
			CoverBody.Font.Size = fontSize;
		}

	}
}