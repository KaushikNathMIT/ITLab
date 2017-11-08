<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			Choose image
			<asp:DropDownList ID="dpd_image" runat="server" OnSelectedIndexChanged="dpd_image_SelectedIndexChanged" />
			<br />
			Choose background colour
			<asp:DropDownList ID="dpd_bg_color" runat="server" OnSelectedIndexChanged="dpd_bg_color_SelectedIndexChanged" />
			<br />
			Choose font size : 
			<asp:TextBox ID="tb_font_size" runat="server" />
			<br />
			Choose font colour :
			<asp:DropDownList ID="dpd_font_color" runat="server" />
			<br />
			<asp:Button ID="apply" Text="Apply Theme" runat="server" OnClick="apply_Click" />
		</div>
		<div>
			<br />
			<asp:Image ID="CoverImage" runat="server" Width="50%" BorderWidth="20px"/>
			<br />
			<asp:Label ID="CoverBody" runat="server" />
		</div>
	</form>
</body>
</html>
