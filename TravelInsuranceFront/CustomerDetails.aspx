<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDetails.aspx.cs" Inherits="CustomerDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CustomerDetails.css"/>

</head>
    <body>
        <form id="customerdetailsForm" runat="server">
            <div id="container" style="width: 500px; height: 582px">
                <div class="customerdetails labels">
                    <asp:Label ID="label_CustomerID" runat="server" Text="CustomerID "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="label_Name" runat="server" Text="Name "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="label_DoB" runat="server" Text="Date of Birth "></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />                                       
                    <br />
                    <br />
                    <asp:Label ID="label_Address" runat="server" Text="Address "></asp:Label>
                    <br />
                    <br />
                    <br />                    
                    <asp:Label ID="label_email" runat="server" Text="E-mail "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="label_contact" runat="server" Text="Contact Number "></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="label_marketingPref" runat="server" Text="Marketing Preferences "></asp:Label>
                </div>

                <div class="customerdetails textbox">    
                    <input id="txtCustomerID" type="text" />
                        <br />
                        <br />
                    <input id="txtName" type="text" /> 
                        <br />
                        <br />
                    <input id="txtDoB" type="text" /><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                        <br />
                        <br />
                    <textarea id="txtAddress" cols="20" name="S1" rows="2"></textarea>
                        <br />
                        <br />
                    <input id="txtEmail" type="text" />
                        <br />
                        <br />
                    <input id="txtContactNumber" type="text" />
                        <br />
                        <br />
                    <input id="Checkbox1" type="checkbox" />
                        <br />
                        <br />
                    <input id="button_Submit" type="button" value="Submit" />
                    <input id="button_cancel" type="button" value="Cancel" />
                </div>

            </div>
                   
    </form>    
        
</body>
</html>
