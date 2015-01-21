using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Threading;
using System.Globalization;
using System.Collections;

public class BasePage : Page
{
    protected override void OnPreInit(EventArgs e)
    {
        if (Request.Cookies["MyTheme"] != null)
        {
            if (Request.Cookies["MyTheme"]["Name"] != null)
                Page.Theme = Request.Cookies["MyTheme"]["Name"];
            else
                Page.Theme = "Blue";
        }
        else
        {
            Page.Theme = "Blue";
        }
    }
}