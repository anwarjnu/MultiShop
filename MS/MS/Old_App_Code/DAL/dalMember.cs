using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TVL.DataLogicLayer;

/// <summary>
/// Summary description for dalMember
/// </summary>

namespace multishopbd.DAL
{
    public class dalMember
    {
        public dalMember()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int Insert(string userID, string adress, string contact,int cityID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@UserId", userID));
            altparams.Add(new SqlParameter("@Address", adress));
            altparams.Add(new SqlParameter("@Contact", contact));
            altparams.Add(new SqlParameter("@CityID", cityID));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblMember_insert", altparams);
        }

        public int Update(string userID, string adress, string contact, int cityID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@UserId", userID));
            altparams.Add(new SqlParameter("@Address", adress));
            altparams.Add(new SqlParameter("@Contact", contact));
            altparams.Add(new SqlParameter("@CityID", cityID));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblMember_update", altparams);
        }

    }
}