<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeletePolicy.aspx.cs" Inherits="DeletePolicy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Policy</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display: grid; grid-template-columns: auto; grid-template-rows: 50% 50%; width: 300px">
            <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            <div style="display: grid; grid-template-columns: 35% 35% 35%">
                <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
            </div>
        </div>
    </form>
</body>
</html>
