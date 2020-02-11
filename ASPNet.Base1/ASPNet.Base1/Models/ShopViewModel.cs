using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNet.Base1.Models
{
    public class ShopViewModel
    {
        public class StoryPageViewModel
        { 
            public IList<Product> Products { get; set; }
        }

        public class ProductPageViewModel
        {
            public Product Product { get; set; }
        }

    }
}