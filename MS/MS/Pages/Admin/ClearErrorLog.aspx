<%@ Page Language="C#" AutoEventWireup="true" Inherits="ClearErrorLog"
    ValidateRequest="false" MasterPageFile="~/MasterPages/AdminMasterPage.master" Title="Powerman : Clear Error Log" Codebehind="ClearErrorLog.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">
    <table width="100%" cellspacing="0" cellpadding="0" class="ContentTopSpace">
        <tr>
            <td>
                <div class="RoundTop">
                </div>
            </td>
        </tr>
        <tr class="ThirdContentBackground">
            <td align="center" style="padding-top: 20px;">
                <asp:Label ID="lblError" runat="server" Font-Bold="true"></asp:Label>
            </td>
        </tr>
        <tr class="ThirdContentBackground">
            <td align="center" valign="top">
                Clear Error Log Before:
                <asp:TextBox ID="tbxDate" runat="server" Width="100px" SkinID="s" />
                <ajaxToolkit:CalendarExtender runat="server" TargetControlID="tbxDate" Format="dd-MMM-yyyy"
                    ID="ce1" />
            </td>
        </tr>
        <tr class="ThirdContentBackground">
            <td align="center" style="padding-top: 20px; padding-left:112px;">
                <asp:Button runat="Server" ID="btnSave" Text="Clear" OnClick="OnBtnSave_Click" Height="25" Width="70"/>
            </td>
        </tr>
    </table>
</asp:Content>
