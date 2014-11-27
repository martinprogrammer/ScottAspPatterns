using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.DIP
{
    public class Product
    {
        private decimal _price;
        public void AdjustPriceWith(IProductDiscount discount)
        {
            discount.Adjust(this);
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }

}