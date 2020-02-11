<%@ Page Language="C#" AutoEventWireup="true" CodeFile="APolicy.aspx.cs" Inherits="APolicy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:major-latin;mso-fareast-font-family:
Arial;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;
mso-ansi-language:EN-GB;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">PolicyID:</span><asp:TextBox ID="PolicyID" runat="server" Height="16px" OnTextChanged="PolicyID_TextChanged"></asp:TextBox>
        </div>
        <p>
            StaffID<span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:major-latin;mso-fareast-font-family:
Arial;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;
mso-ansi-language:EN-GB;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">:</span><asp:TextBox ID="QuoteID" runat="server"></asp:TextBox>
        </p>
        <div>
            <span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:major-latin;mso-fareast-font-family:
Arial;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;
mso-ansi-language:EN-GB;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">CustomerID:</span><asp:TextBox ID="CustomerID" runat="server" Height="16px"></asp:TextBox>
        </div>
        <p>
            StartDate:<asp:TextBox ID="StartDate" runat="server"></asp:TextBox>
        </p>
        <div>
            <span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:major-latin;mso-fareast-font-family:
Arial;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;
mso-ansi-language:EN-GB;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">PolicyDetails:</span><asp:TextBox ID="PolicyDetails" runat="server" Height="16px"></asp:TextBox>
        </div>
        <p>
            Price:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="Accepted" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Accepted" TextAlign="Left" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
