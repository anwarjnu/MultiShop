<%@ Page Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" Inherits="ErrorPages_Oops" Title="Project Tracker: Oops" Codebehind="Oops.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">
    <table cellspacing="0" cellpadding="0" border="0" width="100%">
        <tr>
            <td>
                An unexpected error has occured on our website. The website administrator has been
                notified. Please stay tuned and try again later.
                <p>
                </p>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Return to the Homepage</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
