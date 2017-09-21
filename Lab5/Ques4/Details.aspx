<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="dpd_list" runat="server"/>
            <asp:CheckBoxList ID="cb_list" runat="server" />
            <asp:Label runat="server">Quantity</asp:Label>
            <asp:TextBox ID="tb_quantity" runat ="server" />
            <asp:Button runat="server" Text="Produce Bill" OnClick ="produceBill"/>
        </div>
    </form>
</body>
</html>