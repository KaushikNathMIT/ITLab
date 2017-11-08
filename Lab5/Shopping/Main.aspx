<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:DropDownList ID="dpd_prod" runat="server" />
			<br />
			Set quantity
			<asp:TextBox ID="tb_quant" runat="server" />
			<br />
			<asp:Button ID="add" Text="Add" runat="server" OnClick="add_Click" />
			<br />
			<asp:Label ID="label_cart_details" runat="server"/>
        </div>
    </form>
</body>
</html>
