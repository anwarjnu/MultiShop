<%@ Page Language="C#" MasterPageFile="~/MasterPages/AdminMasterPage.master" AutoEventWireup="true" Inherits="Admin_AddEditAdminUser" Title="Add/Edit admin user" Codebehind="AddEditAdminUser.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server"> 
    <table width="800px" cellpadding="0" cellspacing="0" align="center" class="rowSpacing1 tableBackground">
        
        <tr >
            
            <td>
                <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BorderColor="#E6E2D8"
                    BorderStyle="Solid" BorderWidth="1px" BackColor="#F7F6F3" Font-Names="Verdana"
                    Font-Size="1em">
                    <SideBarStyle BackColor="#5D7B9D" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
                    <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
                    <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                        BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
                    <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                        BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
                    <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em"
                        ForeColor="White" HorizontalAlign="Center" />
                    <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                        BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
                    <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <StepStyle BorderWidth="0px" />
                    <WizardSteps>
                        <asp:CreateUserWizardStep ID="CreateUserWizardStep_1" runat="server">
                            <ContentTemplate>
                                <table cellspacing="0" cellpadding="3" border="0" width="700px" align="center">
                                    <tr>
                                        <td align="center" colspan="2">
                                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="CreateUserWizard1" />
                                            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="createuser">
                                           User Name:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="UserName" runat="server" style="margin-left: 0px" Width="240px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                ErrorMessage="Please enter 'User Name'." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="createuser">
                                           Password:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password"  style="margin-left: 0px" Width="240px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                                ErrorMessage="Please enter 'Password'." ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Password"
                                                ErrorMessage="Password length must be 5 or more" ValidationExpression="\w{5,255}"
                                                ValidationGroup="CreateUserWizard1">*</asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="createuser">
                                           Confirm Password:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"  style="margin-left: 0px" Width="240px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword"
                                                ErrorMessage="Please enter 'Confirm Password'." ToolTip="Confirm Password is required."
                                                ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="createuser">
                                            E-mail:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Email" runat="server" style="margin-left: 0px" Width="240px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email"
                                                ErrorMessage="Please enter 'E-mail'." ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="createuser">
                                            Security Question:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Question" runat="server" style="margin-left: 0px" Width="240px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ControlToValidate="Question"
                                                ErrorMessage="Please enter 'Security question'." ToolTip="Security question is required."
                                                ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="createuser">
                                            Security Answer:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Answer" runat="server" style="margin-left: 0px" Width="240px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer"
                                                ErrorMessage="Please enter 'Security Answer'." ToolTip="Security answer is required."
                                                ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="createuser">
                                            Assign Role:
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="lbxAssignRole" runat="server">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="lbxAssignRole"
                                                ErrorMessage="Please select 'Role'." ToolTip="Role is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left" colspan="2">
                                            <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password"
                                                ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="'Password' and 'Confirmation Password' must match."
                                                ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color: red">
                                            <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                            <CustomNavigationTemplate>
                                <asp:Button ID="btnAddEditUser" runat="server" OnClick="btnAddEditUser_Click" Text="Create User"
                                    EnableViewState="False" ValidationGroup="CreateUserWizard1" />
                            </CustomNavigationTemplate>
                        </asp:CreateUserWizardStep>
                        <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                        </asp:CompleteWizardStep>
                    </WizardSteps>
                </asp:CreateUserWizard>
            </td>
        </tr>
    </table>
</asp:Content>
