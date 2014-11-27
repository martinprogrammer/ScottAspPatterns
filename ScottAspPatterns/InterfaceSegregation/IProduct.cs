using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.InterfaceSegregation
{
    public interface IProduct
    {
        decimal Price { get; set; }
        decimal WeightInKg { get; set; }
        int Stock { get; set; }
      
    }
}