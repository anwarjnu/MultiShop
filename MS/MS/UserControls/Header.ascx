<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_Header" Codebehind="Header.ascx.cs" %>
<%@ Register TagPrefix="WUC" TagName="Menu" Src="~/UserControls/Menu.ascx" %>
<table border="0" cellpadding="0px" cellspacing="0px" class="PageHeader">
    <tr>
        <td align="left">
            <asp:HyperLink ID="Img" runat="server" NavigateUrl="~/Default.aspx" ImageUrl="~/App_Themes/Default/Images/Logo.PNG" />
        </td>
        <td valign="top">
            <asp:Label ID="lblArea" runat="server" CssClass="Area"></asp:Label>
        </td>
        <td valign="top" align="right">
            <asp:LoginStatus runat="server" LoginText="LogIn" LogoutText="LogOut" OnLoggedOut="Unnamed1_LoggedOut"/>
        </td>
    </tr>
</table>

