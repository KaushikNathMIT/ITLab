<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body class="bgimg">
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList runat="server" ID="theme" AutoPostBack="true" OnSelectedIndexChanged="theme_SelectedIndexChanged">
                <asp:ListItem Text="Select a theme" Value="NA"></asp:ListItem>
                <asp:ListItem Text="Summer theme" Value="Summer"></asp:ListItem>
                <asp:ListItem Text="Monsoon theme" Value="Monsoon"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label runat="server">Here is some sample text.</asp:Label>
        </div>
    </form>
</body>
</html>
