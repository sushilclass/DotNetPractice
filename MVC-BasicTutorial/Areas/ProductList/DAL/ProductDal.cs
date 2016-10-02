using MVC_BasicTutorial.Areas.ProductList.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_BasicTutorial.Areas.ProductList.DAL
{
    public class ProductDal : BaseDal
    {
        public List<ProductCategory> getProductCategories()
        {
            List<ProductCategory> categories = new List<ProductCategory>();

            categories.Add(new ProductCategory { Name = "Select Category", Id = "0" });

            categories.Add(new ProductCategory { Name = "Beverages", Id = "1" });

            categories.Add(new ProductCategory { Name = "Condiments", Id = "2" });

            categories.Add(new ProductCategory { Name = "Confections", Id = "3" });

            categories.Add(new ProductCategory { Name = "Dairy Products", Id = "4" });

            categories.Add(new ProductCategory { Name = "Grains/Cereals", Id = "5" });

            categories.Add(new ProductCategory { Name = "Meat/Poultry", Id = "6" });

            categories.Add(new ProductCategory { Name = "Produce", Id = "7" });

            categories.Add(new ProductCategory { Name = "Seafood", Id = "8" });

            return categories;
        }

        public List<Product> getProducts (string categoryId)
        {
            List<Product> products = new List<Product>();

            string query = string.Format("SELECT  [ProductID], [ProductName], [QuantityPerUnit],[UnitPrice],[UnitsInStock],[ReorderLevel] " +
                               " FROM [Test].[dbo].[tblProduct] WHERE CategoryID = {0}", categoryId);
            SqlConnection connection = getConnection();
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(createProduct(reader));
                }
            }
            return products;
        }

        private  Product createProduct(SqlDataReader reader)
        {
            return new Product
            {
                ProductID = reader.GetValue(0).ToString(),
                ProductName = reader.GetString(1),
                QuantityPerUnit = reader.GetString(2),
                UnitPrice = reader.GetValue(3).ToString(),
                UnitsInStock = reader.GetValue(4).ToString(),
                ReorderLevel = reader.GetValue(5).ToString()

            };
        }
    }
}