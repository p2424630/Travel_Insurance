<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/style1.css" rel ="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbl_Name" runat="server" Text="Full Name"></asp:Label>
        <input id="txt_Name" type="text" /><div>
            <asp:Label ID="lbl_Address" runat="server" Text="Address"></asp:Label>
            <input id="txt_Address" type="text" /></div>
        <p>
            <asp:Label ID="lbl_Salary" runat="server" Text="Salary"></asp:Label>
            <input id="txt_Salary" type="text" /></p>
        <p>
            <asp:Label ID="lbl_PhoneNo" runat="server" Text="Phone Number"></asp:Label>
            <input id="txt_PhoneNo" type="text" /></p>
        <p>
            <asp:Label ID="lbl_StartDate" runat="server" Text="Start Date"></asp:Label>
            <input id="txt_StartDate" type="text" /></p>
        <p>
            <asp:Label ID="lbl_isValid" runat="server" Text="IsValid?"></asp:Label>
            <input id="cbox_isValid" type="checkbox" /></p>
    </form>
</body>
</html>
