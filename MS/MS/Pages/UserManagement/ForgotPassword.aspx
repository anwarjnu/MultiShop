<%@ Page Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" Inherits="ForgotPassword" Title="BDAdList -- Forgot Password" Codebehind="ForgotPassword.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">
    <table cellspacing="1" cellpadding="0" border="0" align="center" bgcolor="gray">
        <tr>
            <td>
                <table cellspacing="0" cellpadding="3" border="0" width="100%" bgcolor="#ffffff">
                    <tr>
                        <td>
                            <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" SuccessPageUrl="~/Default.aspx">
                                <MailDefinition From="info@vintageitltd.com" IsBodyHtml="True" Priority="High" Subject="Your Password">
                                </MailDefinition>
                                <TextBoxStyle/>
                                <TitleTextStyle/>
                                <SubmitButtonStyle/>
                            </asp:PasswordRecovery>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
