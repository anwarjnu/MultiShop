using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.IO;
using multishopbd.BLL;

public partial class Admin_AddEditCategory : System.Web.UI.Page
{
    bllCategory objAdCategory = new bllCategory();
    int CategoryId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!User.IsInRole("Admin"))
            Response.Redirect("~/Login.aspx", true);
        if (!IsPostBack)
        {
            if (Request.QueryString["CategoryID"] != null)
            {
                CategoryId = Convert.ToInt16(Request.QueryString["CategoryID"].ToString());
                LoadAdCategory();
            }
        }
        else
        {
            if (Request.QueryString["CategoryID"] != null)
            {
                CategoryId = Convert.ToInt16(Request.QueryString["CategoryID"].ToString());
            }
        }
    }

    private void LoadAdCategory()
    {
        DataTable dt = objAdCategory.GetByID(CategoryId);

        if (dt.Rows.Count > 0)
        {
            txtName.Text = dt.Rows[0]["CategoryName"].ToString();
            txtDescription.Text = dt.Rows[0]["Description"].ToString();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (CategoryId == 0)
        {
           objAdCategory.Insert(txtName.Text, txtDescription.Text);
           MessageController.Show(MessageCode._SaveSucceeded, MessageType.Information, Page);
        }
        else
        {
            objAdCategory.Update(CategoryId, txtName.Text, txtDescription.Text);
            MessageController.Show(MessageCode._UpdateSucceeded, MessageType.Information, Page);
        }
    }
}
