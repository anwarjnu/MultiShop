using System;

namespace VITL.AdsCMS.Manager
{
    public class SiteConfig
    {
        public string NewAdNeedApproval;
        public string PayPalAllowed;
        public int PhotoSize;
        public int NoOfPhoto;
        public string SendMailAfterAdPlaced;
        public string SendMailAfterAdAccepted;
        public string SendMailAfterAdRejected;
        public string ShowTotalVisitors;
        public string ShowNoOfAdInCategory;
        public string ShowNoOfAdInSubCategory;
        public int NoOfAdsPerPage;
        public string HighlightingAllow;

        public SiteConfig()
        {
        }
    }
}