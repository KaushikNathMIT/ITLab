<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label>User Name</asp:Label>
            <asp:TextBox ID="tb_user_name" runat="server" />
            <br />
            <asp:Label>Password</asp:Label>
            <asp:TextBox ID="tb_password" runat="server" TextMode="Password" />
            <br />
            <asp:Label>Email Id</asp:Label>
            <asp:TextBox ID="tb_email_id" runat="server" />
            <br />
            <asp:Label>Contact Number</asp:Label>
            <asp:TextBox ID="tb_contact_number" runat="server" />
            <br />
            <asp:Button ID="button_submit" Text="Submit" runat="server" OnClick="buttonClicked" />
            <br />
            <asp:Label ID="label_message" runat="server" />
        </div>
    </form>
</body>
</html>
