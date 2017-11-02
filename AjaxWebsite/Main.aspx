<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<asp:ScriptManager ID="sm" runat="server" />
			<br />
			<br />
			<asp:UpdatePanel ID="UpdatePanel1" runat="server">
				<ContentTemplate>
					<asp:Panel ID="panel_counter" GroupingText="Customers" runat="server"/>
					<br />
					Number of customers
					<asp:Label ID="label_num" runat="server" />
					<br />
					<asp:Label ID="Label2" runat="server" Text="Enter your name"/>
					<asp:TextBox ID="tb_name" runat="server" />
					<br />
					<asp:RequiredFieldValidator ControlToValidate="tb_name" runat="server" ErrorMessage="Name can't be empty"/>
					<br />
					<asp:DropDownList ID="dpd_list" runat="server" />
					<br />
					Select your gender
					<asp:RadioButtonList ID="rb_list" runat="server" />
					<br />
					<asp:Button ID="button_submit" Text="Add user" OnClick="button_submit_Click" runat="server" />
					<br />
					<asp:SqlDataSource ID="ds" runat="server" SelectCommand="select * from Customer" ConnectionString="<%$ConnectionStrings:db%>"/>
					<asp:GridView DataSourceID="ds" runat="server" />
					<br />
				</ContentTemplate>
			</asp:UpdatePanel>
		</div>
	</form>
</body>
</html>
