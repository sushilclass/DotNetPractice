using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_BasicTutorial.Areas.List_Items.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        //public List<Product> AvailabeProduct
        //{
        //    get
        //    {
        //        List<Product> products = new List<Product>();
        //        products.Add(new Product(1, "LED", "Watching Latest Video", 199.99m));
        //    products.Add(new Product(2, "MP3 player", "Listen to your favourite tunes on the move", 99.99m));
        //    products.Add(new Product(3, "Mobile", "Apps,Games,Fun and More", 399.99m));
        //    products.Add(new Product(4, "Digital Camera", "take photo with high quality", 49.99m));
        //    products.Add(new Product(5, "Speaker", "singing a song", 149.99m));
        //    products.Add(new Product(6, "extra one", "All of season one plus exclusive extras", 39.99m));
        //    return products;
        //    }

            

        //}

        public Product(int id, string name, string description, decimal rate)
        {
            Id = id;
            Name = name;
            Description = description;
            Rate = rate;
        }

       //public static List<Product> AvailabeProduct = new List<Product>()
       // {
       //     new Product(1, "LED", "Watching Latest Video", 199.99m),
       //     new Product(2, "MP3 player", "Listen to your favourite tunes on the move", 99.99m),
       //     new Product(3, "Mobile", "Apps,Games,Fun and More", 399.99m),
       //     new Product(4, "Digital Camera", "take photo with high quality", 49.99m),
       //     new Product(5, "Speaker", "singing a song", 149.99m),
       //     new Product(6, "extra one", "All of season one plus exclusive extras", 39.99m)

       // };

      public  static List<Product> GetAvailabeProduct()
        {
            return new List<Product>();
        }

      public List<Product> AvailableProducts { get; set; }
    }
}