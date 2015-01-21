using System;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;
using TVL.DataLogicLayer;
using System.Data.SqlClient;

namespace multishopbd.DAL
{
    
    public class dalCommon
    {
        public int ClearErrorLog(DateTime pTimeUtc)
        {
            ArrayList altParams = new ArrayList();

            altParams.Add(new SqlParameter("@pTimeUtc", pTimeUtc));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("ELMAH_LogError_Clear", altParams);

        }
       
    } //class
} //namespace