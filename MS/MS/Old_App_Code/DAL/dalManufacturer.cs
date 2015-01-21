using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TVL.DataLogicLayer;

/// <summary>
/// Summary description for dalManufacturer
/// </summary>
/// 
namespace multishopbd.DAL
{
    public class dalManufacturer
    {
        public dalManufacturer()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public DataTable GetByID(int ManufacturerID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@ManufacturerID", ManufacturerID));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("usp_tblmanufacturer_getbyid", altparams);
        }
        public DataTable GetAll()
        {
            ArrayList altparams = new ArrayList();

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("usp_tblmanufacturer_getall", altparams);
        }
        public int Insert(string ManufacturerName, string Description)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@ManufacturerName", ManufacturerName));
            altparams.Add(new SqlParameter("@Description", Description));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblmanufacturer_insert", altparams);
        }
        public int Update(int ManufacturerID, string ManufacturerName, string Description)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@ManufacturerID", ManufacturerID));
            altparams.Add(new SqlParameter("@ManufacturerName", ManufacturerName));
            altparams.Add(new SqlParameter("@Description", Description));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblmanufacturer_update", altparams);
        }
        public int Delete(int ManufacturerID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@ManufacturerID", ManufacturerID));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblmanufacturer_delete", altparams);
        }
    }
}