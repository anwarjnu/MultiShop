using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using multishopbd.DAL;

/// <summary>
/// Summary description for bllMember
/// </summary>

namespace multishopbd.BLL
{
    public class bllMember
    {
        dalMember objMember = new dalMember();
        public bllMember()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int Insert(string userID, string adress, string contact,int cityID)
        {
            return objMember.Insert(userID, adress, contact,cityID);
        }
        public int Update(string userID, string adress, string contact, int cityID)
        {
            return objMember.Update(userID, adress, contact, cityID);
        }


    }
}