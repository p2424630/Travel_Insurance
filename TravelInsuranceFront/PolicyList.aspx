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
<body style="height: 802px">
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="height: 362px; width: 408px">
        <asp:ListBox ID="lstPolicyList" runat="server" Height="304px" Width="380px"></asp:ListBox>
            <div style="width: 377px; height: 45px">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
                <br />
            </div>
        </div>
    </form>
</body>
</html>
