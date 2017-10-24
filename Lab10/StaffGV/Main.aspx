<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="ds1" runat="server" SelectCommand="select CityName from city where stateid = @stateid" ConnectionString="<%$ConnectionStrings:db%>" />
            <asp:GridView ID=""
        </div>
    </form>
</body>
</html>
