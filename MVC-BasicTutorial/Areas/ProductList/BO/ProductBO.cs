using MVC_BasicTutorial.Areas.ProductList.DAL;
using MVC_BasicTutorial.Areas.ProductList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_BasicTutorial.Areas.ProductList.BO
{
    public class ProductBO
    {
        ProductDal productdal = new ProductDal();
        public List<ProductCategory> getAllCategories()
        {
            return productdal.getProductCategories();
        }

        public List<Product> getProductByCategory(string categoryId)
        {

            return productdal.getProducts(categoryId);
        }

    }
}