using System;
namespace ScottAspPatterns.DIP
{
    public interface ILinqProductRepository
    {
        System.Collections.Generic.IEnumerable<Product> FindAll();
    }
}
