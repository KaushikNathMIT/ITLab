<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VendorHome.aspx.cs" Inherits="VendorHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<br />
			<asp:Button ID="del_status" Text="Show delivery Schedule" runat="server" OnClick="del_status_Click" />
			<br />
			Vehicle inventory is as follows 
			<br />
			<asp:SqlDataSource ID="ds1" runat="server" SelectCommand="select * from Vehicles" ConnectionString="<%$ConnectionStrings:db%>"/>
			<asp:GridView ID="gv_vehicles" runat="server" DataSourceID="ds1" SkinID="gridviewSkin"/>
			<br />
			Total number of products in inventory
			<asp:TextBox ID="tb_quantity" runat="server" />
			<asp:Button ID="update_quantity" runat="server" OnClick="update_quantity_Click" Text="Update total inventory quantity"/>
        </div>
    </form>
</body>
</html>
