<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList runat="server" ID="bdstyle" />
            <br />
            <asp:TextBox runat="server" ID="tb_message" />
            <br />
            <asp:Label runat="server" >Type the message</asp:Label>
            <br />
            <asp:Button runat="server" ID="submit" Text="Display" OnClick="submit_Click"/>
        </div>
    </form>
</body>
</html>
