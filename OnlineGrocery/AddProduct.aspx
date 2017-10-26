<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="AddProduct" MasterPageFile="~/ManageProducts.master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<br />
	<br />
	<br />
	Enter product ID
	<asp:TextBox ID="tb_pid" runat="server" />
	<br />
	Enter Product Name
	<asp:TextBox ID="tb_pname" runat="server" />
	<br />
	Enter Product Price
	<asp:TextBox ID="tb_price" runat="server" />
	<br />
	Is the Product Perishable?
	<asp:RadioButtonList ID="rbl_prod" runat="server" />
	<asp:Button ID="btn_add_product" Text="Confirm New Product" OnClick="btn_add_product_Click" runat="server"/>
</asp:Content>
