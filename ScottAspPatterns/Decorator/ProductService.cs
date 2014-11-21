using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Decorator
{
    public class ProductService
    {
        IRepository _repository;
        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> _products =  _repository.FindAll();
            _products.ApplyCurrencyMultiplier(0.25m);
            _products.ApplyTradeDiscountMultiplier();
            return _products;
        }
    }
}