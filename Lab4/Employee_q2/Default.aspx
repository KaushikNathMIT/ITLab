<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Select1 {
            width: 140px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Employee ID:
        <select id="Select1"  runat="server">
            <option value="140905454" runat="server">140905454</option>
            <option value="140905568" runat="server">140905568</option>
            <option value="140905458" runat="server">140905458</option>
        </select>
        
        <img alt="" src="" id="EmpImage" runat="server"/><br />
        Employee Name:
        <input id="Text1" type="text" runat="server"/><br />
        Date of Joining:
        <input id="Text2" type="text" runat="server"/><br />
        <br />
        <input id="Button1" type="button" value="Am I Eligible for Promotion" runat="server" onserverclick="PromotionCheck"/></div>

        <input type="text" id="Promotion" runat="server" value="Promo?" />
    </form>
    
</body>
</html>
