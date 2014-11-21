using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Decorator
{
    public class Product
    {
        public IPrice Price { get; set; }
    }
}