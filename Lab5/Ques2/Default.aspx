<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tb_name" runat="server" />
            <asp:TextBox ID="tb_roll" runat="server" />
            <asp:DropDownList ID="dpd_list" runat="server" />
            <asp:Button ID="button_def" runat="server" OnClick="buttonClicked" Text="Submit"/>
        </div>
    </form>
</body>
</html>
