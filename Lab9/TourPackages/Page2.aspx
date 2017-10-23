<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page2.aspx.cs" Inherits="Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="ds1" runat="server" SelectCommand="select * from tourpackages where name=@name" ConnectionString="<%$ConnectionStrings:db%>">
                <SelectParameters>
                    <asp:QueryStringParameter Name="name" QueryStringField="name" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="gv1" DataSourceID="ds1" runat="server" />
        </div>
    </form>
</body>
</html>
