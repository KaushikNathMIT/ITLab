<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="ds1" runat="server" SelectCommand="select CityName from city where stateid = @stateid" ConnectionString="<%$ConnectionStrings:db%>" >
                <SelectParameters>
                    <asp:ControlParameter Name="stateid" ControlID="dpd1" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:DropDownList ID="dpd1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dpd1_SelectedIndexChanged"/>
            <asp:DropDownList ID="dpd2" runat="server" DataSourceID="ds1" DataTextField="CityName" />
        </div>
    </form>
</body>
</html>
