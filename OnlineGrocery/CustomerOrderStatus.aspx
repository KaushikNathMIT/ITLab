<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerOrderStatus.aspx.cs" Inherits="CustomerOrderStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Previous Order status
		<br />
		<div>
			<asp:SqlDataSource ID="ds1" ConnectionString="<%$ConnectionStrings:db%>" runat="server" SelectCommand="select CustID, Customer.OrderID, [OrderStatus].Status from Customer inner join [OrderStatus] on Customer.OrderID = OrderStatus.OrderID where Customer.custid=@custid" >
				<SelectParameters>
					<asp:QueryStringParameter Name="custid" QueryStringField="custid" Type="String" />
				</SelectParameters>
			</asp:SqlDataSource>
			<asp:GridView ID="gv_status" DataSourceID="ds1" runat="server" SkinID="gridviewSkin"/>
		</div>
    </form>
</body>
</html>
