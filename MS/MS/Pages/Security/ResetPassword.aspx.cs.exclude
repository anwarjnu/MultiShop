using System;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Threading;

public partial class Pages_Security_ResetPassword : BasePage
{

    protected void Page_Load(object sender, EventArgs e)
    {

        lblMessage.Text = "";

        if (!IsPostBack)
        {
            if (Request.QueryString["un"] != null)
                UserDataBind();
            else
            {
                Response.Redirect("UserAdministration.aspx", false);
            }
        }
    }



    private void UserDataBind()
    {
        txtUserName.Text = Request.QueryString["un"].ToString();

        MembershipUser user = Membership.GetUser(txtUserName.Text);

        txtUserName.BorderStyle = BorderStyle.None;
        txtUserName.Enabled = false;

    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        Validate("User");
        if (!IsValid) return;

            if (Request.QueryString["un"] != null)
            {
                MembershipUser user = Membership.GetUser(txtUserName.Text);

                string oldPassword = user.ResetPassword();
                if (oldPassword.Length > 0 && Password.Text.Length > 0)
                {
                    if (user.ChangePassword(oldPassword, Password.Text))
                    {

                        #region Notification

                        //string strMessage =
                        //    "Your password has been changed  <br />in <a href='http://www.bcs18admin.org.bd'>http://www.bcs18admin.org.bd</a>";

                        //strMessage += "<p><b>User Name:</b> " + txtUserName.Text;
                        //strMessage += "<b>Password:</b> " + Password.Text + "</b>";

                        //try
                        //{
                        //    Email.Send(user.Email, "Password Change Notification", strMessage);
                        //}
                        //catch (Exception)
                        //{
                        //}

                        #endregion
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Text = "Password has been reset.";
                    }
                }
            }
    }
}


