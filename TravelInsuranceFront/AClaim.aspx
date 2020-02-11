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
        <div style="width: 20%; height: 50%; float: left">
            Claim Reason:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtClaimReason" runat="server"></asp:TextBox>
            <br />
            Claim ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtClaimID" runat="server"></asp:TextBox>
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
            Policy ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPolicyID" runat="server"></asp:TextBox>
            </div>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
        </p>
    </form>
</body>
</html>
