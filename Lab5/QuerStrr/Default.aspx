﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="dpd_list" OnSelectedIndexChanged="manufacturerSelected" runat="server" AutoPostBack="true"/>
        <br />
        <asp:TextBox ID="tb_model" runat="server"/>
    </div>
    </form>
</body>
</html>
