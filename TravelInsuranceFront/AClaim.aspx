<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AClaim.aspx.cs" Inherits="AClaim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Claim Reason:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtClaimReason" runat="server"></asp:TextBox>
            <br />
            Claim ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtClaimID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            Claim Amount:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtClaimAmnt" runat="server"></asp:TextBox>
            <br />
            Claim Status:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtClaimStatus" runat="server"></asp:TextBox>
            <br />
            Claim Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtClaimDate" runat="server"></asp:TextBox>
            <br />
            Staff ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            <br />
            Customer ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            Error:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />

            </div>

            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
    </form>
</body>
</html>
