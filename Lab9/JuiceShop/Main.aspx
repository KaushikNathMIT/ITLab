<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Fruits :
            <asp:CheckBoxList Id="checkboxlist1" runat="server" /><br /><br />
            Ice Creams :
            <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList><br /><br />
            <asp:Button ID="btn" Text="Display" runat="server" onClick="btn_click"/><br /><br />
            <asp:Label ID="label1" runat="server" />
        </div>
    </form>
</body>
</html>

