using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_BasicTutorial.Areas.List_Items.Models
{
    public class ViewModel
    {
        public List<Product> AvailableProducts { get; set; }
        public List<Product> SelectedProduct { get; set; }

        public decimal RequestTotal
        {
            get
            {
                if (SelectedProduct == null)
                    return 0m;
                else
                    return SelectedProduct.Sum(prod => prod.Rate);
            }
        }

        public int[] AvailableSelected { get; set; }
        public int[] RequestedSelected { get; set; }
        public string SaveRequested { get; set; }

    }
}