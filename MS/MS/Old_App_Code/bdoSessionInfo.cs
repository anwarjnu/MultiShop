using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
    /// Summary description for SessionInfo
    /// </summary>
    public class bdoSessionInfo
    {
        string _ColorTheme;
        string _DateFormat;
        string _TimeFormat;
        string _TimeZone;

        Boolean _AdApproveEmail;
        Boolean _AdUnApproveEmail;
        Boolean _AdExpiredEmail;
        Boolean _AdminNewUserEmail;
        Boolean _MemberShipAppovalEmail;

        Boolean _ShowNoOfAdInCategory;
        Boolean _ShowNoOfAdInSubCategory;
        int _NoOfSubCategoryShowUnderCategory=0;
        int _NoOfColumnsInCategoryList;
        int _NoOfAdsPerPage;
        string _Track=string.Empty;


        int _PhotoSize;
        int _NoOfPhoto;
        int _ThumbImageWidth;
        int _ThumbImageHeight;
        int _MediumImageWidth;
        int _MediumImageHeight;
        int _LargeImageWidth;
        int _LargeImageHeight;
        
        public bdoSessionInfo()
        {
        }

        #region Common Members

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
        #endregion



        #region GeneralConfiguration

        public string ColorTheme
        {
            get
            {
                return _ColorTheme;
            }
            set
            {
                _ColorTheme = value;
            }
        }

        public string DateFormat
        {
            get
            {
                return _DateFormat;
            }
            set
            {
                _DateFormat = value;
            }
        }


        public string TimeFormat
        {
            get
            {
                return _TimeFormat;
            }
            set
            {
                _TimeFormat = value;
            }
        }


        public string TimeZone
        {
            get
            {
                return _TimeZone;
            }
            set
            {
                _TimeZone = value;
            }
        }

        #endregion GeneralConfiguration

        #region EmailConfiguration
        public Boolean AdApproveEmail
        {
            get
            {
                return _AdApproveEmail;
            }
            set
            {
                _AdApproveEmail = value;
            }
        }

        public Boolean AdUnApproveEmail
        {
            get
            {
                return _AdUnApproveEmail;
            }
            set
            {
                _AdUnApproveEmail = value;
            }
        }

        public Boolean AdExpiredEmail
        {
            get
            {
                return _AdExpiredEmail;
            }
            set
            {
                _AdExpiredEmail = value;
            }
        }
        public Boolean AdminNewUserEmail
        {
            get
            {
                return _AdminNewUserEmail;
            }
            set
            {
                _AdminNewUserEmail = value;
            }
        }

        public Boolean MemberShipAppovalEmail
        {
            get
            {
                return _MemberShipAppovalEmail;
            }
            set
            {
                _MemberShipAppovalEmail = value;
            }
        }
        #endregion Emailconfiguration

        #region CategorySubCategoryConfiguration
        public Boolean ShowNoOfAdInCategory
        {
            get
            {
                return _ShowNoOfAdInCategory;
            }
            set
            {
                _ShowNoOfAdInCategory = value;
            }
        }

        public string Track
        {
            get
            {
                return _Track;
            }
            set
            {
                _Track = value;
            }
        }

        public Boolean ShowNoOfAdInSubCategory
        {
            get
            {
                return _ShowNoOfAdInSubCategory;
            }
            set
            {
                _ShowNoOfAdInSubCategory = value;
            }
        }

        public int NoOfSubCategoryShowUnderCategory
        {
            get
            {
                return _NoOfSubCategoryShowUnderCategory;
            }
            set
            {
                _NoOfSubCategoryShowUnderCategory = value;
            }
        }

        public int NoOfColumnsInCategoryList
        {
            get
            {
                return _NoOfColumnsInCategoryList;
            }
            set
            {
                _NoOfColumnsInCategoryList = value;
            }
        }

        public int NoOfAdsPerPage
        {
            get
            {
                return _NoOfAdsPerPage;
            }
            set
            {
                _NoOfAdsPerPage = value;
            }
        }

        #endregion CategorySubCategoryConfiguration

        #region ImageConfiguration

        public int NoOfPhoto
        {
            get
            {
                return _NoOfPhoto;
            }
            set
            {
                _NoOfPhoto = value;
            }
        }

        public int PhotoSize
        {
            get
            {
                return _PhotoSize;
            }
            set
            {
                _PhotoSize = value;
            }
        }

        public int ThumbImageWidth
        {
            get
            {
                return _ThumbImageWidth;
            }
            set
            {
                _ThumbImageWidth = value;
            }
        }

        public int ThumbImageHeight
        {
            get
            {
                return _ThumbImageHeight;
            }
            set
            {
                _ThumbImageHeight = value;
            }
        }

        public int MediumImageWidth
        {
            get
            {
                return _MediumImageWidth;
            }
            set
            {
                _MediumImageWidth = value;
            }
        }

        public int MediumImageHeight
        {
            get
            {
                return _MediumImageHeight;
            }
            set
            {
                _MediumImageHeight = value;
            }
        }

        public int LargeImageWidth
        {
            get
            {
                return _LargeImageWidth;
            }
            set
            {
                _LargeImageWidth = value;
            }
        }

        public int LargeImageHeight
        {
            get
            {
                return _LargeImageHeight;
            }
            set
            {
                _LargeImageHeight = value;
            }
        }
        #endregion ImageConfiguration

    }
