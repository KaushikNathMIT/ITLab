<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Electronics.aspx.cs" Inherits="Electronics" MasterPageFile="~/MasterPage.master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Electronics</h2>
    Categories:
        <asp:RadioButtonList runat="server">
            <asp:ListItem Text="Mobiles" />
            <asp:ListItem Text="Laptops" />
            <asp:ListItem Text="Printers" />
        </asp:RadioButtonList>
    Vendors:
        <asp:DropDownList ID="dropdown" runat="server" />
</asp:Content>
