using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScottAspPatterns.DIP
{
    public class ChristmasProductDiscount : ScottAspPatterns.DIP.IProductDiscount
    {
        public decimal Adjust(Product product)
        {
            return product.Price * 0.75m;
        }
    }
}
