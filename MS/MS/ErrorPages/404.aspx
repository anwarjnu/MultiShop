<%@ Page Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" Inherits="ErrorPages_404" Title="Project Tracker: Resource Could Not Be Found" Codebehind="404.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">
    <table cellspacing="0" cellpadding="0" border="0" width="100%">
        <tr>
            <td>
                <b>The requested resource could not be found.</b>
                <p>
                    It seems that the page you were trying to reach doesn't exist anymore, or maybe
                    it has just moved. Please feel free to contact us if the problem persists or if
                    you think it is a problem with our website.</p>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Return to the Homepage</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
