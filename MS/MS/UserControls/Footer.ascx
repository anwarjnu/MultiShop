<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_Footer" Codebehind="Footer.ascx.cs" %>
<table border="0" cellspacing="5" cellpadding="5" class="PageFooter">
    <tr>
        <td valign="top">Copyright  © Multishop-2015 | 
            <asp:LoginStatus runat="server" ID="footerlogin" LoginText="LogIn" LogoutText="LogOut" OnLoggedOut="Unnamed1_LoggedOut" />
        </td>
    </tr>
</table>
