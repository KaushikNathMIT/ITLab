<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SecondPage.aspx.cs" Inherits="SecondPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label_prev_page" runat="server" />
            <br />
            <asp:Button ID="button_cnt_inc" runat="server" OnClick="buttonClicked" Text ="Increase Counter"/>
            <asp:Label ID="label_cnt_val" runat="server" />
        </div>
    </form>
</body>
</html>
