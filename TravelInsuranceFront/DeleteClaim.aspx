<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteClaim.aspx.cs" Inherits="DeleteClaim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display: grid; grid-template-columns: auto; grid-template-rows: 50% 50%; width: 300px">
                <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
                <br/>
                <div style="display: grid; grid-template-columns: 35% 35% 35%">
                    <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
                    <a></a>
                    <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
                </div>
            </div>
    </form>
</body>
</html>
