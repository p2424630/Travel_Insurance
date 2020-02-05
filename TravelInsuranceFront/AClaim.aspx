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
            <input id="txtClaimReason" type="text" /><br />
            Claim ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="txtClaimID" type="text" /><br />
            Claim Amount:&nbsp;&nbsp;&nbsp;
            <input id="txtClaimAmnt" type="text" /><br />
            Claim Status:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="txtClaimStatus" type="text" /><br />
            Claim Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="txtClaimDate" type="text" /><br />
            Policy ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="txtPolicyID" type="text" /></div>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
        </p>
    </form>
</body>
</html>
