<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerCart.aspx.cs" Inherits="CustomerCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Label ID="orderid" runat="server" />
			<br />
			<asp:SqlDataSource ID="ds2" runat="server" SelectCommand="select ProductName from Product" ConnectionString="<%$ConnectionStrings:db%>" />
			<asp:DropDownList ID="dpd_list_prod" runat="server" DataSourceID="ds2" DataTextField="productname" /> 
			<asp:TextBox ID="tb_quantity" runat="server" />
			<asp:Button Text="Update" ID="btn_add" OnClick="btn_add_Click" runat="server" />
		</div>
		<div>
            <asp:SqlDataSource ID="ds1" runat="server" SelectCommand="select * from [Order] where orderid = @orderid" ConnectionString="<%$ConnectionStrings:db%>" >
				<SelectParameters>
					<asp:ControlParameter Name="orderid" ControlID="orderid" Type="String" />
				</SelectParameters>	
			</asp:SqlDataSource>
            <asp:GridView DataSourceID="ds1" runat="server" ID="gv_cart"/>
        </div>
    </form>
</body>
</html>
