<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteClaim.aspx.cs" Inherits="DeleteClaim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 25%; width: 15%">
            <div>Are you sure you want to delete this record?</div>
            <asp:Button ID="btnNo" runat="server" style="float: right" Text="No" OnClick="btnNo_Click" />
            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" Width="56px" />
        </div>
  </form>
</body>
</html>
