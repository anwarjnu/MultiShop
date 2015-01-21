<%@ Page Title="Login323" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" Inherits="Login" Codebehind="Login.aspx.cs" %>
<%@ Register TagPrefix="WUC" TagName="Login" Src="~/UserControls/Login.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" Runat="Server">
    <table cellpadding="0" cellspacing="0" >
        <tr>
            <td width="200px" height="350px"></td>
            <td>
                <WUC:Login ID="Login1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>