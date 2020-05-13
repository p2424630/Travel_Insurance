<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PolicyList.aspx.cs" Inherits="PolicyList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 781px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 500px; width: 450px">
            <asp:Label ID="lblInfo" runat="server" Text="List of Customer IDs:"></asp:Label>
            <asp:ListBox ID="lstPolicyList" runat="server" Height="88%" Width="100%"></asp:ListBox>
            <div style="display: grid; grid-template-columns: 150px 150px 150px; grid-template-rows: 100%">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </div>
            <div style="display: grid; grid-template-columns: 35% 65%; grid-template-rows: 100%; width: 450px">
                <asp:Label ID="lblCustomerId" runat="server" Text="Enter Customer ID:"></asp:Label>
                <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
            </div>
            <br />
            <div style="display: grid; grid-template-columns: 50% 50%; grid-template-rows: 100%; width: 450px">
                <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
                <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            </div>
            <br />
            <p>
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
