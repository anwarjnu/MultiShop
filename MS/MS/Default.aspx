<%@ Page Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" Inherits="_Default" Title="Multishopbd -- Online shoping from anywhere" Codebehind="Default.aspx.cs" %>

<%@ Register Src="UserControls/DefaultMessage.ascx" TagName="DefaultMessage" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="Server">
<table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td valign="top">
                <uc1:DefaultMessage ID="DefaultMessage2" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
