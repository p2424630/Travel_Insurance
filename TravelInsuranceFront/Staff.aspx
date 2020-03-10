<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Staff.css" rel ="stylesheet" type="text/css" />
</head>
<body>
    <%--    <div class ="grid">
        <div class ="FullName">FullName</div>
        <div class ="Address">Address</div>
        <div class ="Salary">Salary</div>
        <div class ="PhoneNumber">PhoneNumber</div>
        <div class ="StartDate">StartDate</div>
        <div class ="IsValid?">IsValid?</div>
    </div>--%>
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
        <p>
            <asp:Button ID="OK" runat="server" Text="OK" OnClick="OK_Click" />
            <asp:Button ID="Cancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>


</html>
