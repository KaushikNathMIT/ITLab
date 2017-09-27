<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Bike Desired
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Diablo</asp:ListItem>
            <asp:ListItem>Pulsar</asp:ListItem>
            <asp:ListItem>Endeavour</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Date Desired"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Book Bike" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <asp:Image ID="Image1" runat="server" />
    
    </div>
    </form>
</body>
</html>
