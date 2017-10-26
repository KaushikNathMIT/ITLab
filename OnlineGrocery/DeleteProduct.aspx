<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteProduct.aspx.cs" Inherits="DeleteProduct" MasterPageFile="~/ManageProducts.master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<br />
	<br />
	<asp:ListBox ID="lb_prod" runat="server" />
	<br />
	<asp:Button ID="button_del_prod" Text="Confirm delete" OnClick="button_del_prod_Click" runat="server"/>
</asp:Content>
