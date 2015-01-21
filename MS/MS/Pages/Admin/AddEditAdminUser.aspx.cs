using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Admin_AddEditAdminUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!User.IsInRole("Admin"))
            Response.Redirect("~/Login.aspx", true);
        if (Request.QueryString["UN"] != null && Request.QueryString["UN"].ToString().Length > 0)
        {
            Button btnAddEditUser = (Button)CreateUserWizardStep_1.CustomNavigationTemplateContainer.FindControl("btnAddEditUser");
            btnAddEditUser.Text = "Edit User";

            TextBox tbxUserName = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("UserName");
            TextBox tbxPassword = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Password");
            TextBox tbxConfirmPassword = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("ConfirmPassword");
            TextBox tbxQuestion = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Question");
            TextBox tbxAnswer = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Answer");
            RequiredFieldValidator PasswordRequired = (RequiredFieldValidator)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("PasswordRequired");
            RequiredFieldValidator ConfirmPasswordRequired = (RequiredFieldValidator)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("ConfirmPasswordRequired");
            RequiredFieldValidator QuestionRequired = (RequiredFieldValidator)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("QuestionRequired");
            RequiredFieldValidator AnswerRequired = (RequiredFieldValidator)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("AnswerRequired");
            Label lblMessage = (Label)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("lblMessage");

            lblMessage.Text = "";
            tbxUserName.Enabled = false;
            tbxPassword.Enabled = false;
            tbxConfirmPassword.Enabled = false;
            tbxQuestion.Enabled = false;
            tbxAnswer.Enabled = false;
            PasswordRequired.ValidationGroup = "";
            ConfirmPasswordRequired.ValidationGroup = "";
            QuestionRequired.ValidationGroup = "";
            AnswerRequired.ValidationGroup = "";
        }

        if (!IsPostBack)
        {
            BindRole();

            Button btnAddEditUser = (Button)CreateUserWizardStep_1.CustomNavigationTemplateContainer.FindControl("btnAddEditUser");
            TextBox tbxUserName = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("UserName");
            TextBox tbxPassword = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Password");
            TextBox tbxConfirmPassword = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("ConfirmPassword");
            TextBox tbxQuestion = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Question");
            TextBox tbxAnswer = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Answer");
            RequiredFieldValidator PasswordRequired = (RequiredFieldValidator)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("PasswordRequired");
            RequiredFieldValidator ConfirmPasswordRequired = (RequiredFieldValidator)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("ConfirmPasswordRequired");
            RequiredFieldValidator QuestionRequired = (RequiredFieldValidator)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("QuestionRequired");
            RequiredFieldValidator AnswerRequired = (RequiredFieldValidator)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("AnswerRequired");

            if (Request.QueryString["UN"] != null && Request.QueryString["UN"].ToString().Length > 0)
            {
                btnAddEditUser.Text = "Edit User";
                tbxUserName.Enabled = false;
                tbxPassword.Enabled = false;
                tbxConfirmPassword.Enabled = false;
                tbxQuestion.Enabled = false;
                tbxAnswer.Enabled = false;
                PasswordRequired.ValidationGroup = "";
                ConfirmPasswordRequired.ValidationGroup = "";
                QuestionRequired.ValidationGroup = "";
                AnswerRequired.ValidationGroup = "";
                LoadControls();
            }
            else
            {
                btnAddEditUser.Text = "Create User";
            }
        }
    }

    private void BindRole()
    {
        DropDownList lbxAssignRole = (DropDownList)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("lbxAssignRole");
        lbxAssignRole.DataSource = Roles.GetAllRoles();
        lbxAssignRole.DataBind();
    }

    private void LoadControls()
    {
        TextBox tbxUserName = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("UserName");
        TextBox tbxEmail = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Email");
        DropDownList lbxAssignRole = (DropDownList)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("lbxAssignRole");

        MembershipUser mu = Membership.GetUser(Request.QueryString["UN"].ToString());
        tbxUserName.Text = mu.UserName;
        tbxEmail.Text = mu.Email;
        lbxAssignRole.SelectedValue = Roles.GetRolesForUser(Request.QueryString["UN"].ToString())[0];
    }

    protected void btnAddEditUser_Click(object sender, EventArgs e)
    {
        Label lblMessage = (Label)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("lblMessage");
        TextBox tbxUserName = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("UserName");
        TextBox tbxPassword = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Password");
        TextBox tbxConfirmPassword = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("ConfirmPassword");
        TextBox tbxEmail = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Email");
        TextBox tbxQuestion = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Question");
        TextBox tbxAnswer = (TextBox)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("Answer");
        DropDownList lbxAssignRole = (DropDownList)CreateUserWizardStep_1.ContentTemplateContainer.FindControl("lbxAssignRole");
        Button btnAddEditUser = (Button)CreateUserWizardStep_1.CustomNavigationTemplateContainer.FindControl("btnAddEditUser");

        if (btnAddEditUser.Text == "Create User") // Create
        {
            if (Membership.FindUsersByName(tbxUserName.Text).Count != 0)
            {
                lblMessage.Text = "User Name Already Exists";
                return;
            }
            // Create user
            MembershipCreateStatus mcsStatus;
            Membership.CreateUser(tbxUserName.Text, tbxPassword.Text, tbxEmail.Text, tbxQuestion.Text, tbxAnswer.Text, true, out mcsStatus);

            // Insert role
            Roles.AddUserToRole(tbxUserName.Text, lbxAssignRole.SelectedValue);
        }
        else // Update
        {
            MembershipUser mu = Membership.GetUser(Request.QueryString["UN"].ToString());

            mu.Email = tbxEmail.Text;
            Membership.UpdateUser(mu);

            Roles.RemoveUserFromRole(Request.QueryString["UN"].ToString(), Roles.GetRolesForUser(Request.QueryString["UN"].ToString())[0]);
            Roles.AddUserToRole(tbxUserName.Text, lbxAssignRole.SelectedValue);
        }

        Response.Redirect("~/Pages/Security/UserAdministration.aspx");
    }
}
