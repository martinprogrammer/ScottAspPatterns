using System;
namespace ScottAspPatterns.DIP
{
    public interface IProductDiscount
    {
        decimal Adjust(Product product);
    }
}
