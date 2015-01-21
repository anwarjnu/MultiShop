using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ErrorPages_Oops : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Literal lit_PageHeader = Page.Master.FindControl("lit_PageHeader") as Literal;
        if (lit_PageHeader != null)
            lit_PageHeader.Text = "Oops";
    }
}