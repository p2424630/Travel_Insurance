<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Review.aspx.cs" Inherits="Review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text2 {
            margin-bottom: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        &nbsp;<asp:Label ID="Label1" runat="server" Text="CustomerId:           "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerReview" runat="server" ></asp:TextBox><br />
        Review Title:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtReviewTitle" runat="server"></asp:TextBox>
        <br />
        Review Text:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtReviewText" runat="server"></asp:TextBox>
        <br />
        Date Published:&nbsp;&nbsp;&nbsp; <asp:Calendar ID="calendar" runat="server"></asp:Calendar>
        Is Complaint Recorded?<input id="complaintCheckbox" type="checkbox" /><br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="ok" />
    </form>
</body>
</html>
