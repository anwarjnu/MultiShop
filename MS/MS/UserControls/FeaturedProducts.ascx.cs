using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using multishopbd.BLL;

public partial class UserControls_Products : System.Web.UI.UserControl
{
    bllProduct objProduct = new bllProduct();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Loadgallery();
            Panel1.DataBind();
        }
    }

    public DataTable GetUnFeaturedAdTable()
    {
        DataTable dt = new DataTable("FeaturedTable");
        dt.Columns.Add("IDn", typeof(Int32));
        dt.Columns.Add("IsFeatured", typeof(int));
        return dt;
    }
    private void Loadgallery()
    {
        DataTable dt = objProduct.GetAllFeatued();
        RepeaterProduct.DataSource = dt;
        RepeaterProduct.DataBind();
    }

}