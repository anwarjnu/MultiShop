/*
Usage:
    tvwMenu.DataSource = NavigationController.GetSiteMapDataSource(Session["UserRole"].ToString());
    tvwMenu.DataBind();
 */

using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for NavigationController
/// </summary>
namespace VITL.AdsCMS.Manager
{
    public class NavigationController
    {
        public static SiteMapDataSource GetSiteMapDataSource(string strRole)
        {
            System.Collections.Specialized.NameValueCollection myCollection = new System.Collections.Specialized.NameValueCollection(1);
            myCollection.Add("siteMapFile", "~/Web.sitemap");

            XmlSiteMapProvider xmlSiteMap = new XmlSiteMapProvider();
            xmlSiteMap.Initialize("provider", myCollection);
            xmlSiteMap.BuildSiteMap();

            SiteMapDataSource siteMap = new SiteMapDataSource();
            siteMap.StartingNodeUrl = "~/" + strRole + "Dummy.aspx";
            siteMap.ShowStartingNode = false;

            return siteMap;
        }
        public static SiteMapDataSource GetSiteMapDataSource()
        {
            System.Collections.Specialized.NameValueCollection myCollection = new System.Collections.Specialized.NameValueCollection(1);
            myCollection.Add("siteMapFile", "~/Web.sitemap");

            XmlSiteMapProvider xmlSiteMap = new XmlSiteMapProvider();
            xmlSiteMap.Initialize("provider", myCollection);
            xmlSiteMap.BuildSiteMap();

            SiteMapDataSource siteMap = new SiteMapDataSource();
            siteMap.StartingNodeUrl = "~/" + "Default.aspx";
            siteMap.ShowStartingNode = false;

            return siteMap;
        }
    }
}