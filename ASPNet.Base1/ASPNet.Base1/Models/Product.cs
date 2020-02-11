using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNet.Base1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
        public decimal ProductPrice { get; set; }
        public string Discription { get; set; }
        public IList<int> Rating { get; set; }
    }
}