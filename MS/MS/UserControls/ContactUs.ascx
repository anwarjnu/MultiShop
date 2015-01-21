<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_ContactUs" Codebehind="ContactUs.ascx.cs" %>
<table border="0" cellspacing="0" cellpadding="4" width="970px">
        <tr>
            <td>
                Your Email Address*:
            
            </td>
            <td>
                <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="tbxEmail"
                                ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>
                Query*:
            
            </td>
            <td>
                <asp:TextBox ID="tbxMessage"  TextMode="MultiLine" Rows="5" Columns="45" runat="server"></asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbxMessage"
                                ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" />
            </td>
        </tr>
    </table>