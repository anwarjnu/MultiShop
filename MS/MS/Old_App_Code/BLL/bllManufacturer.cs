using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using multishopbd.DAL;

/// <summary>
/// Summary description for bllManufacturer
/// </summary>
/// 
namespace multishopbd.BLL
{
    
    public class bllManufacturer
    {
        dalManufacturer objManufacturer = new dalManufacturer();
        public bllManufacturer()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public DataTable GetByID(int ManufacturerID)
        {
            return objManufacturer.GetByID(ManufacturerID);
        }
        public DataTable GetAll()
        {
            return objManufacturer.GetAll();
        }

        public int Insert(string ManufacturerName, string Description)
        {
            return objManufacturer.Insert(ManufacturerName, Description);
        }
        public int Update(int ManufacturerID, string ManufacturerName, string Description)
        {
            return objManufacturer.Update(ManufacturerID, ManufacturerName, Description);
        }
        public int Delete(int ManufacturerID)
        {
            return objManufacturer.Delete(ManufacturerID);
        }
    }
}