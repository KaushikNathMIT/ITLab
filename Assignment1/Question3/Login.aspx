<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label runat="server">User Name</asp:Label>
            <asp:TextBox ID="username" type="text" runat="server" />
            <asp:Label runat="server">Password</asp:Label>
            <asp:TextBox ID="password" type="password" runat="server" />
            <asp:Button ID="login_button" type="submit" Text="Login" runat="server" OnClick="AttemptLogin" />
        </div>
        <div>
            <asp:Label ID="message" runat="server" />
        </div>
    </form>
</body>
</html>
