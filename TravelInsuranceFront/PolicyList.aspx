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
        <div style="height: 386px; width: 408px">
        <asp:ListBox ID="lstPolicyList" runat="server" Height="304px" Width="380px"></asp:ListBox>
            <div style="width: 377px; height: 45px">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
                <asp:Button ID="btnEdit" runat="server" Text="Edit" />
            </div>
        </div>
    </form>
</body>
</html>
