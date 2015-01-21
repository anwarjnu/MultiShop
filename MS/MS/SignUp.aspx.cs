using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Threading;
using multishopbd.BLL;

public partial class SignUp : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Literal lit_PageHeader = Page.Master.FindControl("lit_PageHeader") as Literal;
            //if (lit_PageHeader != null)
            //    lit_PageHeader.Text = "Sign Up";

            //lblIP.Text = Request.UserHostAddress;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            Membership.CreateUser(tbxName.Text.Trim(), tbxPassword.Text, tbxEmail.Text.Trim());

            if (ddlRole.SelectedItem.Text == "Buyer")
                Roles.AddUserToRole(tbxName.Text.Trim(), "Buyer");
            else
                Roles.AddUserToRole(tbxName.Text.Trim(), "Seller");

            MembershipUser currentUser = Membership.GetUser(tbxName.Text.Trim());
            string userID = currentUser.ProviderUserKey.ToString();

            new bllMember().Insert(userID, "", tbxContact.Text.Trim(), 0);
            FormsAuthentication.RedirectFromLoginPage(tbxName.Text, false);

            if (ddlRole.SelectedItem.Text == "Buyer")
                Response.Redirect("~/Pages/Admin/AdminHome.aspx", false);
            else
                Response.Redirect("~/Pages/Admin/AdminHome.aspx", false);

        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
            lblMessage.ForeColor = System.Drawing.Color.Red;
            //MessageController.Show(ex.Message.ToString(), MessageType.Error, Page);
            //tbxCaptcha.Text = "";
        }
    }
}
