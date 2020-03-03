<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDetails.aspx.cs" Inherits="CustomerDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            margin-top: 2px;
        }
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            <asp:Label ID="label_CustomerID" runat="server" Text="CustomerID "></asp:Label>
            <input id="txtCustomerID" type="text" /></p>
        <p class="auto-style1">
            <asp:Label ID="label_name" runat="server" Text="Name "></asp:Label>
            <input id="txtName" type="text" /></p>
        <p class="auto-style1">
            <asp:Label ID="label_DoB" runat="server" Text="Date of Birth "></asp:Label>
            <input id="txtDoB" type="text" /><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p class="auto-style1">
            <asp:Label ID="label_Address" runat="server" Text="Address "></asp:Label>
            <textarea id="txtAddress" cols="20" name="S1" rows="2"></textarea></p>
        <p class="auto-style1">
            <asp:Label ID="label_email" runat="server" Text="E-mail "></asp:Label>
            <input id="txtEmail" type="text" /></p>
        <asp:Label ID="label_contactNumber" runat="server" Text="Contact Number "></asp:Label>
        <input id="txtContactNumber" type="text" /><p class="auto-style1">
            <asp:Label ID="label_MarketingPrefs" runat="server" Text="Marketing Preferences "></asp:Label>
            <input id="Checkbox1" type="checkbox" /></p>
    </form>
    <p>
        <input id="button_Submit" type="button" value="Submit" /><input id="button_cancel" type="button" value="Cancel" /></p>
</body>
</html>
