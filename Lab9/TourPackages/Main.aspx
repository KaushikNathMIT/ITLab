<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="ds1" runat="server" SelectCommand="select name from tourpackages" ConnectionString="<%$ConnectionStrings:db%>" />
            <asp:ListBox ID="lb_1" DataSourceID="ds1" DataTextField="name" AutoPostBack="true" runat="server" OnSelectedIndexChanged="lb_1_SelectedIndexChanged"/>
        </div>
    </form>
</body>
</html>
