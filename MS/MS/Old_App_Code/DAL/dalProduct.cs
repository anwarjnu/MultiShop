using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TVL.DataLogicLayer;

/// <summary>
/// Summary description for dalProduct
/// </summary>


namespace multishopbd.DAL
{
    public class dalProduct
    {
        public dalProduct()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public DataTable GetTopN(int CategoryID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@CategoryID", CategoryID));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("usp_tblproduct_getnbycategoryid", altparams);
        }
        public DataTable GetByCategoryID(int CategoryID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@CategoryID", CategoryID));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("usp_tblproduct_getbycategoryid", altparams);
        }
        public DataTable GetRelatedProduct(int CategoryID,int ProductID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@CategoryID", CategoryID));
            altparams.Add(new SqlParameter("@ProductID", ProductID));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("usp_tblproduct_getrelatedproduct", altparams);
        }
        public DataTable GetByID(int ProductID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@ProductID", ProductID));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("usp_tblproduct_getbyid", altparams);
        }
        public DataTable GetAllFeatued()
        {
            ArrayList altparams = new ArrayList();

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("usp_tblproduct_getallfeatured", altparams);
        }
        public DataTable GetAll()
        {
            ArrayList altparams = new ArrayList();

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("usp_tblproduct_getall", altparams);
        }
        public int Insert(string ProductName, string ProductCode, string ShortDescription, double OurPrice, double RetailPrice, int ManufacturerID, int Status, int CategoryID, string Attribute, string ImageName, int Featured, string Description)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@ProductName", ProductName));
            altparams.Add(new SqlParameter("@ProductCode", ProductCode));
            altparams.Add(new SqlParameter("@Description", Description));
            altparams.Add(new SqlParameter("@ShortDescription", ShortDescription));
            altparams.Add(new SqlParameter("@OurPrice", OurPrice));
            altparams.Add(new SqlParameter("@RetailPrice", RetailPrice));
            altparams.Add(new SqlParameter("@ManufacturerID", ManufacturerID));
            altparams.Add(new SqlParameter("@Status", Status));
            altparams.Add(new SqlParameter("@CategoryID", CategoryID));
            altparams.Add(new SqlParameter("@Attribute", Attribute));
            altparams.Add(new SqlParameter("@ImageName", ImageName));
            altparams.Add(new SqlParameter("@Featured", Featured));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblproduct_insert", altparams);
        }
        public int Update(int ProductID, string ProductName, string ProductCode, string ShortDescription, double OurPrice, double RetailPrice, int ManufacturerID, int Status, int CategoryID, string Attribute, string ImageName, int Featured, string Description)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@ProductID", ProductID));
            altparams.Add(new SqlParameter("@ProductName", ProductName));
            altparams.Add(new SqlParameter("@ProductCode", ProductCode));
            altparams.Add(new SqlParameter("@ShortDescription", ShortDescription));
            altparams.Add(new SqlParameter("@Description", Description));
            altparams.Add(new SqlParameter("@OurPrice", OurPrice));
            altparams.Add(new SqlParameter("@RetailPrice", RetailPrice));
            altparams.Add(new SqlParameter("@ManufacturerID", ManufacturerID));
            altparams.Add(new SqlParameter("@Status", Status));
            altparams.Add(new SqlParameter("@CategoryID", CategoryID));
            altparams.Add(new SqlParameter("@Attribute", Attribute));
            altparams.Add(new SqlParameter("@ImageName", ImageName));
            altparams.Add(new SqlParameter("@Featured", Featured));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblproduct_update", altparams);
        }
        public int ImageDelete(int ProductID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@ProductID", ProductID));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblproduct_updateimagepath", altparams);
        }
        public int Delete(int ProductID)
        {
            ArrayList altparams = new ArrayList();
            altparams.Add(new SqlParameter("@ProductID", ProductID));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("usp_tblproduct_delete", altparams);
        }
    }
}