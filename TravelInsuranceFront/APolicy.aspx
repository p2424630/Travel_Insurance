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
mso-ansi-language:EN-GB;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">PolicyID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
        </div>
        <p>
            <span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:major-latin;mso-fareast-font-family:
Arial;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;
mso-ansi-language:EN-GB;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">QuoteID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <div>
            <span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:major-latin;mso-fareast-font-family:
Arial;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;
mso-ansi-language:EN-GB;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">CustomerID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox3" runat="server" Height="16px"></asp:TextBox>
        </div>
        <p>
            <span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:major-latin;mso-fareast-font-family:
Arial;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;
mso-ansi-language:EN-GB;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Calendar ID="Calendar1" runat="server" Caption="PolicyBuyDate"></asp:Calendar>
        </p>
        <div>
            <span style="font-size:11.0pt;line-height:115%;
font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:major-latin;mso-fareast-font-family:
Arial;mso-hansi-theme-font:major-latin;mso-bidi-theme-font:major-latin;
mso-ansi-language:EN-GB;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">PolicyDetails:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="TextBox5" runat="server" Height="16px"></asp:TextBox>
        </div>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Accepted" TextAlign="Left" />
        </p>
    </form>
</body>
</html>
