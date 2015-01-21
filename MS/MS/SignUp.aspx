<%@ Page Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" Inherits="SignUp" Title="Sign Up" Codebehind="SignUp.aspx.cs" %>

<%--<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel ID="pnlContent" runat="server">
                <table border="0" cellpadding="1" cellspacing="1" class="defaultTable">
                    <tr>
                        <td>
                            <table border="0" cellpadding="5" cellspacing="1" align="center">
                                <tr>
                                    <td colspan="2" class="labelMessage" align="left">
                                        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="GeneraltdLabel">User Name:&nbsp;<font color="red">*</font>
                                    </td>
                                    <td class="GeneraltdText">
                                        <asp:TextBox ID="tbxName" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldAnimatedValidator2" runat="server" ErrorMessage="Enter User Name."
                                            ControlToValidate="tbxName">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="GeneraltdLabel">Password:&nbsp;<font color="red">*</font>
                                    </td>
                                    <td class="GeneraltdText">
                                        <asp:TextBox ID="tbxPassword" TextMode="Password" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Password."
                                            ControlToValidate="tbxPassword">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="GeneraltdLabel">Confirm Password:&nbsp;<font color="red">*</font>
                                    </td>
                                    <td class="GeneraltdText">
                                        <asp:TextBox ID="tbxConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Confirm Password."
                                            ControlToValidate="tbxConfirmPassword">*</asp:RequiredFieldValidator>
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tbxConfirmPassword"
                                            Operator="Equal" ControlToCompare="tbxPassword" ErrorMessage="Password and Confirm Password are not same.">*</asp:CompareValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="GeneraltdLabel">Email:<%--&nbsp;<font color="red">*</font>--%></td>
                                    <td class="GeneraltdText">
                                        <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
                                        <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator342" runat="server" ErrorMessage="Enter Email Address"
                                            ControlToValidate="tbxEmail">*</asp:RequiredFieldValidator>--%>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email Address."
                                            ControlToValidate="tbxEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="GeneraltdLabel">Sign up as:&nbsp;<font color="red">*</font>
                                    </td>
                                    <td class="GeneraltdText">
                                        <asp:DropDownList runat="server" ID="ddlRole">
                                            <asp:ListItem Value="1">Buyer</asp:ListItem>
                                            <asp:ListItem Value="2">Seller</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="GeneraltdLabel">Contact:&nbsp;<font color="red">*</font>
                                    </td>
                                    <td class="GeneraltdText">
                                        <asp:TextBox ID="tbxContact" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter tbxContact #."
                                            ControlToValidate="tbxContact">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;
                                    </td>
                                    <td>
                                        <asp:Button ID="btnSave" runat="server" Text="Sign Up" OnClick="btnSave_Click" />&nbsp;&nbsp;<input
                                            type="reset" value="Reset" class="Button">
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <ajaxToolkit:RoundedCornersExtender ID="rcepnlContent" runat="server" BorderColor="#8a9e99"
                Corners="Top" Radius="3" TargetControlID="pnlContent" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
