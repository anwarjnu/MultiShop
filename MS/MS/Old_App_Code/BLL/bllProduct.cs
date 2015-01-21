using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using multishopbd.DAL;

/// <summary>
/// Summary description for bllProduct
/// </summary>
/// 
namespace multishopbd.BLL
{
    public class bllProduct
    {
        dalProduct objProduct = new dalProduct();
        public bllProduct()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public DataTable GetTopN(int CategoryID)
        {
            return objProduct.GetTopN(CategoryID);
        }
        public DataTable GetByCategoryID(int CategoryID)
        {
            return objProduct.GetByCategoryID(CategoryID);
        }
        public DataTable GetRelatedProduct(int CategoryID,int ProductID)
        {
            return objProduct.GetRelatedProduct(CategoryID, ProductID);
        }
        public DataTable GetByID(int ProductID)
        {
            return objProduct.GetByID(ProductID);
        }
        public DataTable GetAll()
        {
            return objProduct.GetAll();
        }
        public DataTable GetAllFeatued()
        {
            return objProduct.GetAllFeatued();
        }

        public int Insert(string ProductName,string ProductCode, string ShortDescription, double OurPrice, double RetailPrice, int ManufacturerID, int Status, int CategoryID, string Attribute, string ImgeName, int Featured,string Description)
        {
            return objProduct.Insert(ProductName, ProductCode, ShortDescription, OurPrice, RetailPrice, ManufacturerID, Status, CategoryID, Attribute, ImgeName, Featured, Description);
        }
        public int Update(int ProductID, string ProductName,string ProductCode, string ShortDescription, double OurPrice, double RetailPrice, int ManufacturerID, int Status, int CategoryID, string Attribute, string ImgeName, int Featured,string Description)
        {
            return objProduct.Update(ProductID, ProductName, ProductCode, ShortDescription, OurPrice, RetailPrice, ManufacturerID, Status, CategoryID, Attribute, ImgeName, Featured, Description);
        }
        public int ImageDelete(int ProductID)
        {
            return objProduct.ImageDelete(ProductID);
        }
        public int Delete(int ProductID)
        {
            return objProduct.Delete(ProductID);
        }
    }
}