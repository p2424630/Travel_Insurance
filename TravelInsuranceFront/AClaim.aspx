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
        <div style="display: grid; grid-template-columns: auto; grid-template-rows: auto; width: 350px">
            <div style="display: grid; grid-template-columns: 35% 65%;">
                <asp:Label ID="lblClaimReason" runat="server" Text="Claim Reason:"></asp:Label>
                <asp:TextBox ID="txtClaimReason" runat="server"></asp:TextBox>
            </div>
            <div style="display: grid; grid-template-columns: 35% 35% 30%;">
                <asp:Label ID="lblClaimID" runat="server" Text="ClaimID:"></asp:Label>
                <asp:TextBox ID="txtClaimID" runat="server"></asp:TextBox>
                <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            </div>
            <div style="display: grid; grid-template-columns: 35% 65%;">
                <asp:Label ID="lblClaimStatus" runat="server" Text="ClaimStatus:"></asp:Label>
                <asp:TextBox ID="txtClaimStatus" runat="server"></asp:TextBox>
            </div>    
            <div style="display: grid; grid-template-columns: 35% 65%;">
                <asp:Label ID="lblClaimDate" runat="server" Text="ClaimDate:"></asp:Label>
                <asp:TextBox ID="txtClaimDate" runat="server"></asp:TextBox>
            </div>    
            <div style="display: grid; grid-template-columns: 35% 65%;">
                <asp:Label ID="lblStaffID" runat="server" Text="StaffID:"></asp:Label>
                <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            </div>    
            <div style="display: grid; grid-template-columns: 35% 65%;">
                <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID:"></asp:Label>
                <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            </div>    
            <div style="display: grid; grid-template-columns: 35% 65%;">
                <asp:Label ID="lblClaimAmnt" runat="server" Text="ClaimAmnt:"></asp:Label>
                <asp:TextBox ID="txtClaimAmnt" runat="server"></asp:TextBox>
            </div>
            <br/>
            <div>
                <asp:Button ID="btnOk" style="width: 25%" runat="server" OnClick="btnOk_Click" Text="OK" />
            </div>
            <div>
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </div>
        </div>

          
    </form>
</body>
</html>
