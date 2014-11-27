using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.DIP
{
    public class LinqProductRepository : ScottAspPatterns.DIP.ILinqProductRepository
    {
      


        public IEnumerable<Product> FindAll()
        {
            return new List<Product>();
        }
    }
}