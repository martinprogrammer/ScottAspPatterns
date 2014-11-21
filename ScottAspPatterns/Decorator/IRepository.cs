using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Decorator
{
    public interface IRepository
    {
        IEnumerable<Product> FindAll();
    }
}