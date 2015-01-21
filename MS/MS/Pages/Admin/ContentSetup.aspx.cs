using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Admin_ContentSetup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindPagesList();
        }
    }
    protected void BindPagesList()
    {
        DataSet ds = ContentResources.GetPages("");
        lstPages.DataSource = ds.Tables[0];

        lstPages.DataBind();
    }

    public void OnBtnSave_Click(object sender, EventArgs e)
    {
        bool ret = ContentResources.UpdateResource(lstPages.SelectedItem.Text, "Page Content", txtBodyText.Content);
        if (ret)
        {

            this.Cache.Remove(lstPages.SelectedValue.ToLower());
            MessageController.Show(MessageCode._SaveSucceeded, MessageType.Information, Page);
        }
        else
        {
            MessageController.Show(MessageCode._SaveFailed, MessageType.Error, Page);
        }
    }

    protected void lstPages_SelectedIndexChanged(object sender, EventArgs e)
    {
        if ((lstPages.SelectedIndex != -1))
        {
            string values = ContentResources.GetResourceByCultureKey(lstPages.SelectedItem.Text, "Page Content");
            if (values != null)
            {
                txtBodyText.Content = values;
            }
        }
    }
}