<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_LeftMenu" Codebehind="LeftMenu.ascx.cs" %>
<table cellspacing="0" cellpadding="0" class="tableBorder">
    <tr>
        <td class="tableHeader1">
            Admin Panel
        </td>
    </tr>
    <tr>
        <td class="leftNavigationBody" align="left">
            <table>
                <tr>
                    <td>
                        <asp:Menu ID="SampleMenu" runat="server" StaticDisplayLevels="2" ItemWrap="true"
                            RenderingMode="Table" StaticEnableDefaultPopOutImage="false" 
                            Width="100px">
                        </asp:Menu>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="leftNavigationBot"><asp:LoginStatus runat="server" LoginText="LogIn" LogoutText="LogOut" OnLoggedOut="Unnamed1_LoggedOut"/></td>
    </tr>
</table>
