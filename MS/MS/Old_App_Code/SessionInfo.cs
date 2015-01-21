using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SessionInfo
/// </summary>
public class SessionInfo
{
	public SessionInfo()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string SessionID
    {
        get { return HttpContext.Current.Session.SessionID; }
    }
    public int TimeOut
    {
        get
        {
            try
            {
                return HttpContext.Current.Session.Timeout;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session.Timeout = value;
        }
    }

 #region GeneralConfiguration


    public string ColorTheme
    {
        get
        {
            try
            {
                return HttpContext.Current.Session["ColorTheme"].ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        set
        {
            HttpContext.Current.Session["ColorTheme"] = value;
        }
    }

    public string DateFormat
    {
        get
        {
            try
            {
                return HttpContext.Current.Session["DateFormat"].ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        set
        {
            HttpContext.Current.Session["DateFormat"] = value;
        }
    }


    public string TimeFormat
    {
        get
        {
            try
            {
                return HttpContext.Current.Session["TimeFormat"].ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        set
        {
            HttpContext.Current.Session["TimeFormat"] = value;
        }
    }


    public string TimeZone
    {
        get
        {
            try
            {
                return HttpContext.Current.Session["TimeZone"].ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        set
        {
            HttpContext.Current.Session["TimeZone"] = value;
        }
    }

 #endregion GeneralConfiguration

    #region EmailConfiguration
    public Boolean AdApproveEmail
    {
        get
        {
            try
            {

                return Convert.ToBoolean(HttpContext.Current.Session["AdApproveEmail"].ToString());
            }
            catch (Exception)
            {
                return false;
            }
        }
        set
        {
            HttpContext.Current.Session["AdApproveEmail"] = value;
        }
    }

    public Boolean AdUnApproveEmail
    {
        get
        {
            try
            {
                return Convert.ToBoolean(HttpContext.Current.Session["AdUnApproveEmail"].ToString());
            }
            catch (Exception)
            {
                return false;
            }
        }
        set
        {
            HttpContext.Current.Session["AdUnApproveEmail"] = value;
        }
    }

    public Boolean AdExpiredEmail
    {
        get
        {
            try
            {
                return Convert.ToBoolean(HttpContext.Current.Session["AdExpiredEmail"].ToString());
            }
            catch (Exception)
            {
                return false;
            }
        }
        set
        {
            HttpContext.Current.Session["AdExpiredEmail"] = value;
        }
    }

    //public Boolean EmailAdExpired
    //{
    //    get
    //    {
    //        try
    //        {
    //            return Convert.ToBoolean(HttpContext.Current.Session["EmailAdExpired"].ToString());
    //        }
    //        catch (Exception)
    //        {
    //            return false;
    //        }
    //    }
    //    set
    //    {
    //        HttpContext.Current.Session["EmailAdExpired"] = value;
    //    }
    //}

    public Boolean AdminNewUserEmail
    {
        get
        {
            try
            {
                return Convert.ToBoolean(HttpContext.Current.Session["AdminNewUserEmail"].ToString());
            }
            catch (Exception)
            {
                return false;
            }
        }
        set
        {
            HttpContext.Current.Session["AdminNewUserEmail"] = value;
        }
    }

    public Boolean MemberShipAppovalEmail
    {
        get
        {
            try
            {
                return Convert.ToBoolean(HttpContext.Current.Session["MemberShipAppovalEmail"].ToString());
            }
            catch (Exception)
            {
                return false;
            }
        }
        set
        {
            HttpContext.Current.Session["MemberShipAppovalEmail"] = value;
        }
    }
    #endregion Emailconfiguration

    #region CategorySubCategoryConfiguration
    public Boolean ShowNoOfAdInCategory
    {
        get
        {
            try
            {
                return Convert.ToBoolean(HttpContext.Current.Session["ShowNoOfAdInCategory"].ToString());
            }
            catch (Exception)
            {
                return false;
            }
        }
        set
        {
            HttpContext.Current.Session["ShowNoOfAdInCategory"] = value;
        }
    }

    public Boolean ShowNoOfAdInSubCategory
    {
        get
        {
            try
            {
                
                return Convert.ToBoolean(HttpContext.Current.Session["ShowNoOfAdInSubCategory"].ToString());
            }
            catch (Exception)
            {
                return false;
            }
        }
        set
        {
            HttpContext.Current.Session["ShowNoOfAdInSubCategory"] = value;
        }
    }

    public int NoOfSubCategoryShowUnderCategory
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["NoOfSubCategoryShowUnderCategory"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["NoOfSubCategoryShowUnderCategory"] = value;
        }
    }

    public int NoOfColumnsInCategoryList
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["NoOfColumnsInCategoryList"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["NoOfColumnsInCategoryList"] = value;
        }
    }

    public int NoOfAdsPerPage
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["NoOfAdsPerPage"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["NoOfAdsPerPage"] = value;
        }
    }

    #endregion CategorySubCategoryConfiguration

    #region ImageConfiguration

    public int NoOfPhoto
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["NoOfPhoto"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["NoOfPhoto"] = value;
        }
    }

    public int PhotoSize
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["PhotoSize"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["PhotoSize"] = value;
        }
    }

    public int ThumbImageWidth
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["ThumbImageWidth"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["ThumbImageWidth"] = value;
        }
    }

    public int ThumbImageHeight
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["ThumbImageHeight"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["ThumbImageHeight"] = value;
        }
    }

    public int MediumImageWidth
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["MediumImageWidth"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["MediumImageWidth"] = value;
        }
    }

    public int MediumImageHeight
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["MediumImageHeight"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["MediumImageHeight"] = value;
        }
    }

    public int LargeImageWidth
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["LargeImageWidth"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["LargeImageWidth"] = value;
        }
    }

    public int LargeImageHeight
    {
        get
        {
            try
            {
                return Convert.ToInt32(HttpContext.Current.Session["LargeImageHeight"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        set
        {
            HttpContext.Current.Session["LargeImageHeight"] = value;
        }
    }
    #endregion ImageConfiguration

}