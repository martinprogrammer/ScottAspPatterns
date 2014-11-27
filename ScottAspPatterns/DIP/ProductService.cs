using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.DIP
{
    public class ProductService
    {
        private ILinqProductRepository _productRepository;
        private IProductDiscount _discountStrategy;
        
        public ProductService(ILinqProductRepository repository)
        {
            _productRepository = repository;
            
        }
        public IEnumerable<Product> GetProductsAndApplyDiscount(IProductDiscount discount)
        {
            _discountStrategy = discount;

            IEnumerable<Product> products = _productRepository.FindAll();
            foreach(var p in products)
            {
                p.AdjustPriceWith(_discountStrategy);
            }

            return products;
            
        }
    }
}