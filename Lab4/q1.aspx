<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Magazine Cover Designer</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 232px">
    
        <asp:Label ID="Label1" runat="server" Text="Image"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Background Colour"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Blue</asp:ListItem>
            <asp:ListItem>Red</asp:ListItem>
            <asp:ListItem>Green</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Font Size"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>24</asp:ListItem>
            <asp:ListItem>32</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Font Colour"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>Black</asp:ListItem>
            <asp:ListItem>Red</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Input Text"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
        <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem Selected="True">Select Font</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
