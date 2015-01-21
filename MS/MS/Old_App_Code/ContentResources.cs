using System;
using System.Data;
using TVL.DataLogicLayer;


public static class ContentResources
{

    public static void CreateConnection()
    {
    }

    public static DataTable GetPageControls(string page)
    {
        DataTable dt = new DataTable();
        try
        {
            string sql = "SELECT resourcedescription, resourcevalue FROM Localization Where pagename='" + page + "'";
            //ds = dataAccess.ExecuteDataSet(sql);
            dt = DatabaseManager.GetInstance().GetDataTable(sql);

        }
        catch
        {
        }
        return (dt);
    }

    public static DataSet GetPages(string page)
    {
        DataSet ds = new DataSet();
        try
        {
            string sql = "SELECT Distinct pagename, virtualpath FROM Localization";
            ds = DatabaseManager.GetInstance().GetDataset(sql);//dataAccess.ExecuteDataSet(sql);
        }
        catch
        {
        }
        return (ds);
    }


    public static DataSet GetLanguages(string page)
    {
        DataSet ds = new DataSet();
        string sql = "SELECT Distinct culturename FROM Localization";
        try
        {
            //ds = dataAccess.ExecuteDataSet(sql);
            ds = DatabaseManager.GetInstance().GetDataset(sql);
        }
        catch
        {
        }
        return (ds);
    }

    public static string GetResourceByCulturePage(string page, string culturename)
    {
        string s = "";

        string sql = "SELECT resourcevalue FROM Localization Where pagename='" + page + "' and culturename='" + culturename + "'";
        try
        {
            s = DatabaseManager.GetInstance().ExecuteScalar(sql) as string;
            //  cache.Add("GetResourceByCultureKey" + page + culturename, s, CacheItemPriority.Normal, new RefreshCache(), new SlidingTime(TimeSpan.FromSeconds(60)));
        }
        catch
        {
        }

        return (s);
    }


    public static DataSet GetLeftNavResourceByCulture(string culture)
    {
        DataSet ds = new DataSet();
        string sql = "SELECT distinct resourcename, resourcevalue FROM Localization Where (virtualpath='LeftNav.ascx') and culturename='" + culture + "' and resourcename like '%.Text'";
        try
        {
            //ds = dataAccess.ExecuteDataSet(sql);
            ds = DatabaseManager.GetInstance().GetDataset(sql);
        }
        catch
        {
        }
        return (ds);
    }

    public static string GetResourceByCultureKey(string page, string key)
    {
        string s = "";

        string sql = "SELECT resourcevalue FROM Localization Where pagename='" + page + "' and resourcedescription='" + key + "'";
        try
        {
            s = DatabaseManager.GetInstance().ExecuteScalar(sql) as string;
        }
        catch
        {
        }

        return (s);
    }

    public static bool UpdateResource(string page, string key, string keyValue)
    {
        bool bol = false;
        int value;
        keyValue = keyValue.Replace("'", "''");
        string sql = "UPDATE Localization SET resourcevalue = '" + keyValue + "' Where pagename='" + page + "' and resourcedescription='" + key + "'";
        try
        {
            value = int.Parse(DatabaseManager.GetInstance().ExecuteSQLQueryAction(sql, null).ToString());//dataAccess.ExecuteQuery(sql);
            if (value > 0) bol = true;
        }
        catch
        {
        }
        return (bol);
    }
}
