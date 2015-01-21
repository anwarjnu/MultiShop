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
using VITL.AdsCMS.Manager;


public partial class UserControls_LeftMenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            if (Page.User.Identity.Name != "")
            {
                string[] strUserRole = Roles.GetRolesForUser(Page.User.Identity.Name);
                if (strUserRole.Length > 0)
                 SetMenu(strUserRole[0].ToString());
            }
            else
            {
                SetMenu("Annonymous");
            }
            
    }

    protected void LoginStatus1_LoggedOut(object sender, EventArgs e)
    {
        Session["RedirectFrom"] = null;

        Response.Redirect("~/Default.aspx", true);
    }

    public void SetMenu(string strRole)
    {
        SampleMenu.DataSource = NavigationController.GetSiteMapDataSource(strRole);
        SampleMenu.DataBind();
    }
    protected void Unnamed1_LoggedOut(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx", true);
    }
}
