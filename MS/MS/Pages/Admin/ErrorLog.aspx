<%@ Page Language="C#" AutoEventWireup="true" Inherits="ErrorLog"
    ValidateRequest="false" MasterPageFile="~/MasterPages/AdminMasterPage.master" Title="Powerman : Error Log" Codebehind="ErrorLog.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">
    <table cellspacing="0" cellpadding="0" width="100%" class="ContentTopSpace">
        <tr>
            <td valign="top">
                <div class="RoundTop">
                </div>
            </td>
        </tr>
        <tr>
            <td valign="top" class="ErrorBackground">
                <iframe width="100%" height="800" src="elmah.axd" frameborder="0" scrolling="auto">
                </iframe>
            </td>
        </tr>
    </table>
</asp:Content>
