<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:DropDownList ID="dpd" runat="server" />
			<asp:TextBox ID="tb" runat="server" />
			<asp:Button ID="btn" Text="Validate" runat="server" OnClick="btn_Click"/>
			<asp:CustomValidator runat="server" ControlToValidate="tb" ErrorMessage="Not valid" OnServerValidate="Unnamed_ServerValidate"/>
        </div>
    </form>
</body>
</html>
