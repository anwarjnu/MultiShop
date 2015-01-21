using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class MasterPages_Other : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (SiteMap.CurrentNode != null)
        {
            Page.Title = SiteMap.CurrentNode.Title;

            if (SiteMap.CurrentNode["keywords"] != null)
            {
                HtmlMeta meta = new HtmlMeta();
                meta.Name = "Keywords";
                meta.Content = SiteMap.CurrentNode["Keywords"];
                Page.Header.Controls.AddAt(1, meta);
            }

            if (SiteMap.CurrentNode.Description != null)
            {
                HtmlMeta meta = new HtmlMeta();
                meta.Name = "Description";
                meta.Content = SiteMap.CurrentNode.Description.ToString();
                Page.Header.Controls.AddAt(2, meta);
            }
        }

        PageaHeader();
        if (Common.SessionInfo == null)
        {
            Common.SessionInfo = new bdoSessionInfo();
            
        }
    }



    private void PageaHeader()
    {

        if (SiteMap.CurrentNode != null)
        {
            if (SiteMap.CurrentNode["PageHeader"] != null)
            {
                string PH = SiteMap.CurrentNode["PageHeader"].ToString();
                lit_PageHeader.Text = SiteMap.CurrentNode["PageHeader"].ToString();
            }
            else
            {
                lit_PageHeader.Text = Page.Title.ToString();
            }



            if (SiteMap.CurrentNode["pagetitle"] != null)
            {
                Page.Title = SiteMap.CurrentNode["pagetitle"].ToString();
            }

            if (SiteMap.CurrentNode["keywords"] != null)
            {
                HtmlMeta meta = new HtmlMeta();
                meta.Name = "Keywords";
                meta.Content = SiteMap.CurrentNode["Keywords"];
                Page.Header.Controls.AddAt(1, meta);
            }

            if (SiteMap.CurrentNode.Description != null)
            {
                HtmlMeta meta = new HtmlMeta();
                meta.Name = "Description";
                meta.Content = SiteMap.CurrentNode.Description.ToString();
                Page.Header.Controls.AddAt(2, meta);
            }
        }
        else
        {
            lit_PageHeader.Text = Page.Title;
        }
        
    }

}
