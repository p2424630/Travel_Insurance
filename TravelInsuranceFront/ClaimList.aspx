<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClaimList.aspx.cs" Inherits="ClaimList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 500px;  width: 450px">
        <asp:ListBox ID="lstClaimList" runat="server" Height="88%" Width="100%"></asp:ListBox>
            <div style="display: grid; grid-template-columns: 150px 150px 150px; grid-template-rows: 100%">
                <asp:Button ID="btnAdd" runat="server"  OnClick="btnAdd_Click" Text="Add" />
                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
                <asp:Button ID="btnDelete" runat="server"  OnClick="btnDelete_Click" Text="Delete" />
            </div>
        </div>
        <div style="display: grid; grid-template-columns: 35% 65%; grid-template-rows: 100%; width: 450px">
            <asp:Label ID="lblEnterClaimReason" runat="server" Text="Enter Claim Reason:"></asp:Label>
            <asp:TextBox ID="txtClaimReason" runat="server"></asp:TextBox>
        </div>  
        <br />
        <div style="display: grid; grid-template-columns: 50% 50%; grid-template-rows: 100%; width: 450px">
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
        </div>
        <br />
        <p><asp:Label ID="lblError" runat="server"></asp:Label></p>
    </form>
</body>
</html>
