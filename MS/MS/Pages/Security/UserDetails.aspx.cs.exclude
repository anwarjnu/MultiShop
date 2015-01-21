using System;
using System.Web.Security;


public partial class UserDetails : BasePage
{

    protected void Page_Load(object sender, EventArgs e)
    {
    
        if (!IsPostBack)
        {
            if (Request.QueryString["UN"] != null && Request.QueryString["UN"].ToString().Length > 0)
                LoadControls();
        }
    }

    private void LoadControls()
    {
        MembershipUser msu = Membership.GetUser(Request.QueryString["UN"].ToString());
        
        if (msu.UserName != "")
        {
            tbxUserName.Text = msu.UserName;
            tbxEmail.Text = msu.Email;

            string[] str = Roles.GetRolesForUser(msu.UserName);
            string strRole = "";
            foreach (string s in str)
            {
                strRole = strRole + s;
            }
            tbxRole.Text = strRole;
        }
    }
}
