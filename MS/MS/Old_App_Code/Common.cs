using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;

/// <summary>
/// Summary description for Common
/// </summary>
public class Common
{
    public Common()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bdoSessionInfo SessionInfo
    {
        get
        {
            try
            {
                if (HttpContext.Current.Session["SessionInfo"] != null)
                    return HttpContext.Current.Session["SessionInfo"] as bdoSessionInfo;
                else
                    return null;
            }
            catch (Exception)
            {

                return null;
            }
        }
        set
        {
            HttpContext.Current.Session["SessionInfo"] = value;
        }
    }


    public static int totalItem
    {
        get
        {
            try
            {
                if (HttpContext.Current.Session["totalItem"] != null)
                    return Convert.ToInt32(HttpContext.Current.Session["totalItem"]);
                else
                    return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["totalItem"] = value;
        }
    }

    public static decimal totalAmount
    {
        get
        {
            try
            {
                if (HttpContext.Current.Session["totalAmount"] != null)
                    return Convert.ToDecimal(HttpContext.Current.Session["totalAmount"]);
                else
                    return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["totalAmount"] = value;
        }
    }

    public static decimal subTotal
    {
        get
        {
            try
            {
                if (HttpContext.Current.Session["subTotal"] != null)
                    return Convert.ToDecimal(HttpContext.Current.Session["subTotal"]);
                else
                    return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["subTotal"] = value;
        }
    }

    public static DataTable dtProductBusket
    {
        get
        {
            try
            {
                if (HttpContext.Current.Session["ProductBasket"] != null)
                    return HttpContext.Current.Session["ProductBasket"] as DataTable;
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        set
        {
            HttpContext.Current.Session["ProductBasket"] = value;
        }
    }


    public static System.Drawing.Image GetThumsImage(string path, int width, int height)
    {
        System.Drawing.Image image = System.Drawing.Image.FromFile(path);

        if (image.Width > width && image.Height > height)
            image = image.GetThumbnailImage(width, height, null, new IntPtr());
        else if (image.Width > width && image.Height < height)
            image = image.GetThumbnailImage(width, image.Height, null, new IntPtr());
        else if (image.Width < width && image.Height > height)
            image = image.GetThumbnailImage(image.Width, height, null, new IntPtr());
        else
            image = image.GetThumbnailImage(image.Width, image.Height, null, new IntPtr());

        return image;
    }
    public static string GetImage(string path)
    {
        var serverpath = HttpContext.Current.Server.MapPath(path);
        try
        {
            Image image = Image.FromFile(serverpath);
            return path;
        }
        catch
        {
            return "~/App_Themes/Default/Images/NoImage.jpg";
        }
    }

    public static void DeleteFile(string path)
    {
        try
        {
            System.IO.File.Delete(path);
        }
        catch (Exception)
        {
        }
    }
    public static string LocalizeDigit(string strString)
    {
        if (Thread.CurrentThread.CurrentCulture.Name == "bn-BD")
        {
            string[] nativeDigits = Thread.CurrentThread.CurrentCulture.NumberFormat.NativeDigits;
            return strString.Replace('0', nativeDigits[0].ToCharArray()[0])
                    .Replace('1', nativeDigits[1].ToCharArray()[0])
                    .Replace('2', nativeDigits[2].ToCharArray()[0])
                    .Replace('3', nativeDigits[3].ToCharArray()[0])
                    .Replace('4', nativeDigits[4].ToCharArray()[0])
                    .Replace('5', nativeDigits[5].ToCharArray()[0])
                    .Replace('6', nativeDigits[6].ToCharArray()[0])
                    .Replace('7', nativeDigits[7].ToCharArray()[0])
                    .Replace('8', nativeDigits[8].ToCharArray()[0])
                    .Replace('9', nativeDigits[9].ToCharArray()[0]);

        }
        else
        {
            return strString;
        }
    }
    public static DateTime GetTimeZone()
    {
        DateTime dt = DateTime.Now;
        if (!string.IsNullOrEmpty(Common.SessionInfo.TimeZone))
            dt = dt.AddHours(Convert.ToInt32(Common.SessionInfo.TimeZone));
        else
            dt = dt.AddHours(0);
        return dt;


        //for TimeZone just call the folling line as a variable
        //  Common.GetTimeZone()

        //For DateFormat
        // dt.Rows[0]["Date"].ToString(Common.SessionInfo.DateFormat);

    }
    public static bool IsDate(string sdate)
    {
        DateTime dt;
        bool isDate = true;
        try
        {
            dt = DateTime.Parse(sdate);
            // dt = Convert.ToDateTime(sdate,System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
        }
        catch
        {
            isDate = false;
        }
        return isDate;
    }




}