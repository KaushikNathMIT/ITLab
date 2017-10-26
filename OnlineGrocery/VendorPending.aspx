<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VendorPending.aspx.cs" Inherits="VendorPending" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<br />
			<asp:SqlDataSource ID="ds1" ConnectionString="<%$ConnectionStrings:db%>" SelectCommand="select * from OrderStatus" runat="server" />
			<asp:GridView DataSourceID="ds1" runat="server" SkinID="gridviewSkin"/>
			<br />
			<asp:Button ID="btn_ff" Text="Fast forward 1/4th day" runat="server" OnClick="btn_ff_Click"/>
		</div>
	</form>
</body>
</html>
