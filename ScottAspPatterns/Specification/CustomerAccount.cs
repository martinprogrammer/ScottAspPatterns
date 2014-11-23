using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Specification
{
    public class CustomerAccount
    {
        public int NumberOfRentalsThisMonth { get; set; }
        private ISpecification<CustomerAccount> _hasReachedRentalThreshold;
        public CustomerAccount()
        {
            _hasReachedRentalThreshold = new HasReachedRentalThresholdSpecification();
        }

        public bool CanRent()
        {
            return !_hasReachedRentalThreshold.IsSatisfiedBy(this);
        }

    }
}