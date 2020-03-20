<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeletePolicy.aspx.cs" Inherits="DeletePolicy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 113px">
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="height: 32px">
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <div style="height: 27px">
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
        </div>
    </form>
</body>
</html>
