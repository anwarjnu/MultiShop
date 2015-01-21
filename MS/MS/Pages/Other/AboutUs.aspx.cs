using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Other_AboutUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
           //  LitContent.Text = ContentResources.GetResourceByCulture("About Us", "en-US").ToString();
            LitContent.Text = ContentResources.GetResourceByCulturePage("About Us", "en-US");
        }
       
    }
}