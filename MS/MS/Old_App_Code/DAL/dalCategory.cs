using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TVL.DataLogicLayer;

/// <summary>
/// Summary description for dalCategory
/// </summary>
/// 
namespace multishopbd.DAL
{
    public class dalCategory
    {
        public dalCategory()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataTable GetByID(int CategoryID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@CategoryID", CategoryID));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("usp_tblcategory_getbyid",altparams);
        }
        public DataTable GetAll()
        {
            ArrayList altparams = new ArrayList();

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("usp_tblcategory_getall", altparams);
        }
        public int Insert(string CategoryName,string Description)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@CategoryName", CategoryName));
            altparams.Add(new SqlParameter("@Description", Description));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblcategory_insert", altparams);
        }
        public int Update(int CategoryID,string CategoryName, string Description)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@CategoryID", CategoryID));
            altparams.Add(new SqlParameter("@CategoryName", CategoryName));
            altparams.Add(new SqlParameter("@Description", Description));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblcategory_update", altparams);
        }
        public int Delete(int CategoryID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@CategoryID", CategoryID));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblcategory_delete", altparams);
        }


    }
}