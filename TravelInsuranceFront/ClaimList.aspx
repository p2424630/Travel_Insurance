<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClaimList.aspx.cs" Inherits="ClaimList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display: inline-block; height: 500px; width: 500px">
            <asp:ListBox ID="lstClaimList" runat="server" Height="93%" Width="100%"></asp:ListBox>
            <asp:Button ID="btnDelete" runat="server" style="float: right" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="btnAdd" runat="server" style="float: left" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" style="position: relative; left: 20%;" OnClick="btnEdit_Click" Text="Edit" />
        </div>
        <div style="width: 500px">
            <p>
                <asp:Label ID="lblEnterClaimReason" runat="server" Text="Enter Claim Reason:"></asp:Label>
                <asp:TextBox ID="txtClaimReason" style="float: right;" runat="server" Width="300px"></asp:TextBox>
            </p>
            <asp:Button ID="btnClear" runat="server" style="float: left" OnClick="btnClear_Click" Text="Clear" />
            <asp:Button ID="btnApply" runat="server" style="float: right" OnClick="btnApply_Click" Text="Apply" />
        </div>

        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
