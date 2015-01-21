<%@ Control Language="C#" AutoEventWireup="true" Inherits="UserControls_Menu" Codebehind="Menu.ascx.cs" %>
<table cellspacing="0" cellpadding="0" class="tableBorder">
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
</table>