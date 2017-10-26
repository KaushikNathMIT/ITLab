<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerHome.aspx.cs" Inherits="CustomerHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
		<asp:RequiredFieldValidator ControlToValidate="tb_cust_id" runat="server" ErrorMessage="Please fill a customer id"/>
        <div>
			Please enter your customer id
			<br />
			<asp:TextBox ID="tb_cust_id" runat="server" />
			<asp:Button Text="Place a new order" ID="place_order" runat="server" OnClick="place_order_Click" />
			<asp:Button ID="check_status" Text="Check previous order status" OnClick="check_status_Click" runat="server"/>
        </div>
		<br />
		Previous Order status
		<br />
		<div>
			<asp:SqlDataSource ID="ds1" ConnectionString="<%$ConnectionStrings:db%>" runat="server" SelectCommand="select CustID, Customer.OrderID, [OrderStatus].Status from Customer inner join [OrderStatus] on Customer.OrderID = OrderStatus.OrderID" />
			<asp:GridView ID="gv_status" DataSourceID="ds1" runat="server" />
		</div>
    </form>
</body>
</html>
