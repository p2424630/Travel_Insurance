<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Staff.css" rel="stylesheet" type="text/css"/>
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
    <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
    <div>
        <asp:Label ID="lbl_Address" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txt_Address" runat="server"></asp:TextBox>
    </div>
    <p>
        <asp:Label ID="lbl_Salary" runat="server" Text="Salary"></asp:Label>
        <asp:TextBox ID="txt_Salary" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbl_PhoneNo" runat="server" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="txt_PhoneNo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbl_StartDate" runat="server" Text="Start Date"></asp:Label>
        <asp:TextBox ID="txt_StartDate" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lbl_isValid" runat="server" Text="IsValid?"></asp:Label>
        <asp:CheckBox ID="cbox_isValid" runat="server"/>
    </p>
    <p>
        <asp:Button ID="OK" runat="server" Text="OK" OnClick="OK_Click"/>
        <asp:Button ID="Cancel" runat="server" Text="Cancel"/>
    </p>
</form>
</body>
</html>