using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VITL.AdsCMS.Manager;

public partial class UserControls_Menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
                SetMenu("Annonymous");

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
}