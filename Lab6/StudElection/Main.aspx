<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose a candidate
            <asp:DropDownList ID="dpd_list" runat="server" />
            <br />
            Choose a house
            <asp:RadioButtonList ID="rbl_house" runat="server" />
            Choose a class
            <asp:TextBox ID="tb_class" runat="server" />
            <br />
            Enter EmailID
            <asp:TextBox ID="tb_email" runat="server" />
            <br />
            Enter Parent contact number
            <asp:TextBox ID="tb_contact" runat="server" />
            <asp:Button ID="button_submit" Text="Submit" runat="server" OnClick="button_submit_Click" />
            <br />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="dpd_list" ErrorMessage="You have to choose a candidate" InitialValue="" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="rbl_house" ErrorMessage="You have to choose a house" InitialValue="" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="tb_class" ErrorMessage="You have to choose a class" InitialValue="" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="tb_email" ErrorMessage="You have to enter your email ID" InitialValue="" />
            <asp:RangeValidator runat="server" ControlToValidate="tb_class" ErrorMessage="Class must be between 2 to 6" MinimumValue="2" MaximumValue="6" />
            <asp:RegularExpressionValidator runat="server" ControlToValidate="tb_email" ValidationExpression=".+@.+" ErrorMessage="Not a valid email id" />
            <asp:CustomValidator runat="server" ID="cval" ControlToValidate="tb_contact" ValidateEmptyText="true" OnServerValidate="cval_ServerValidate" ErrorMessage="Not a valid Contact number"/>
            <asp:ValidationSummary ID="val_summary" runat="server" ShowMessageBox="true" ShowSummary="true" />
        </div>
    </form>
</body>
</html>
