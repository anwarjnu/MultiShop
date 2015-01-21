<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminMasterPage.master" AutoEventWireup="true" Inherits="Admin_AddEditCategory" Title="Add/Edit Category" Codebehind="AddEditCategory.aspx.cs" %>

<%@ Register TagPrefix="val" Namespace="VITLExtendedValidators" Assembly="VITLExtendedValidators" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">
    <table width="800px" class="tableBackground">

        <tr>
            <td colspan="2" align="left">
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="Submit" runat="server" ForeColor="#CC0000" />
            </td>
        </tr>
        <tr>
            <td>Name<span style="color: red">*</span>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ValidationGroup="Submit" ControlToValidate="txtName"
                    ErrorMessage="Enter Category Name">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left">Description:
            </td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td align="left">
                <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Submit" OnClick="btnSave_Click" />
                <asp:Button ID="Button1" runat="server" Text="Back" CausesValidation="false"
                    Width="60" Height="25" PostBackUrl="~/Pages/Admin/CategoryList.aspx" />
            </td>
        </tr>
    </table>
</asp:Content>
