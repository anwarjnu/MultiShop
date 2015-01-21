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

public partial class UserControls_Login : System.Web.UI.UserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_LoggedIn(object sender, EventArgs e)
    {


        if (Roles.IsUserInRole(Login1.UserName, "Seller"))
        {
            if (Common.SessionInfo == null)
            {
                Common.SessionInfo = new bdoSessionInfo();
            }

            Response.Redirect("~/Pages/Admin/AdminHome.aspx", true);
        }

        if (Roles.IsUserInRole(Login1.UserName, "Buyer"))
        {
            if (Common.SessionInfo == null)
            {
                Common.SessionInfo = new bdoSessionInfo();
            }
            Response.Redirect("~/Pages/Admin/AdminHome.aspx", true);
        }




    }
    
}