using System;
using multishopbd.DAL;

namespace multishopbd.BLL
{
    public class bllCommon 
    {
      
        dalCommon objCommon= new dalCommon(); 
       
        public int ClearErrorLog(DateTime pTimeUtc)
        {
            return objCommon.ClearErrorLog(pTimeUtc);
        }

    } // class
} // namespace