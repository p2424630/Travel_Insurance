<%@ Page Language="C#" AutoEventWireup="true" CodeFile="APolicy.aspx.cs" Inherits="APolicy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Policy Form</title>
    <link rel="stylesheet" href="APolicy.css"/>
</head>
<body>
    <form id="policyForm" runat="server">
        <div id="container">
            <div class="policy labels">
                <asp:Label ID="lblPolicyID" runat="server" Text="PolicyID: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <asp:Label ID="lblStaffID" runat="server" Text="StaffID: "></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID: "></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblPolicyDetails" runat="server" Text="PolicyDetails: "></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblPrice" runat="server" Text="Price: "></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblStartDate1" runat="server" Text="StartDate: "></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </div>
           
            
            
            <div class="policy textbox">
                <div class="input-group">
                    <asp:TextBox ID="txtPolicyID" runat="server" Height="16px"></asp:TextBox>
                    <span class="input-group-btn">
                        <asp:Button ID="BtnFind" runat="server" Height="22px" OnClick="BtnFind_Click" Text="Find" Width="42px" />
                    </span>
                </div>
                <br />
                <asp:TextBox ID="txtStaffID" runat="server" Height="16px"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txtCustomerID" runat="server" Height="16px"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txtPolicyDetails" runat="server" Height="16px" style="margin-bottom: 0px"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txtPrice" runat="server" Height="16px"></asp:TextBox>

                <br />

                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                <asp:Calendar ID="calStartDate" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="298px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
                <br />

                <br />
                <asp:CheckBox ID="chkAccepted" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Accepted" TextAlign="Left" />
                <br />
                <br />
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>