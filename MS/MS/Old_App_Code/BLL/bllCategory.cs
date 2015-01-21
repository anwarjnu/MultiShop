using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using multishopbd.DAL;

/// <summary>
/// Summary description for bllCategory
/// </summary>
/// 
namespace multishopbd.BLL
{
    public class bllCategory
    {
        dalCategory objCategory = new dalCategory();
        public bllCategory()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataTable GetByID(int CategoryID)
        {
            return objCategory.GetByID(CategoryID);
        }
        public DataTable GetAll()
        {
            return objCategory.GetAll();
        }

        public int Insert(string CategoryName,string Description)
        {
            return objCategory.Insert(CategoryName, Description);
        }
        public int Update(int CategoryID,string CategoryName, string Description)
        {
            return objCategory.Update(CategoryID, CategoryName, Description);
        }
        public int Delete(int CategoryID)
        {
            return objCategory.Delete(CategoryID);
        }
    }
}