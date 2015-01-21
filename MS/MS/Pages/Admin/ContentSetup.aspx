<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminMasterPage.master" AutoEventWireup="true" Inherits="Pages_Admin_ContentSetup" Codebehind="ContentSetup.aspx.cs" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" Runat="Server">

    <table border="0" width="100%">
        <tr>
            <td valign="top" style="width: 70px;">
                Page Title:
            </td>
            <td align="left" valign="top">
                <asp:DropDownList runat="server" DataTextField="pagename" DataValueField="virtualpath"
                    ID="lstPages"  OnSelectedIndexChanged="lstPages_SelectedIndexChanged"
                     AutoPostBack="True"></asp:DropDownList>
                <br />
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2" valign="top">
                Content:
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2" valign="top">
                <cc1:Editor ID="txtBodyText" runat="server" Width="100%" Height="500px" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button runat="Server" ID="btnSave" Text="Save" OnClick="OnBtnSave_Click" />
                <asp:Button PostBackUrl="~/Default.aspx" runat="Server" ID="btnClose" Text="Close" />
            </td>
        </tr>
    </table>
</asp:Content>

