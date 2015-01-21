using System;
using System.Web.Security;
using System.Web.UI;
using VITL.AdsCMS.Manager;

public partial class UserControls_SideMenu : UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                //SetMenu("Annonymous");
            }
        }
        catch (Exception)
        {

        }
    }

    private void SetMenu(string strRole)
    {
        //ButtomMenu.DataSource = NavigationController.GetSiteMapDataSource(strRole);
        //ButtomMenu.DataBind();
    }


}




