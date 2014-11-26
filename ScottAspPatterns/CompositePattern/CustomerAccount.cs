using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.CompositePattern
{
    public class CustomerAccount
    {
        private ISpecification<CustomerAccount> _hasReachedRentalThreshold;
       public CustomerAccount()
        {
            _hasReachedRentalThreshold = new HasReachedRentalThresholdSpecification();
        }
       public decimal NumberOfRentalsThisMonth { get; set; }
       public bool AccountActive { get; set; }
       public decimal LateFees { get; set; }

       public bool CanRent()
       {
           return _hasReachedRentalThreshold.IsSatisfied(this);
       }
    }
}