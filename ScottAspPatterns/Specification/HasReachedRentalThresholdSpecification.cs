using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Specification
{
    public class HasReachedRentalThresholdSpecification : ISpecification<CustomerAccount>
    {

        public bool IsSatisfiedBy(CustomerAccount candidate)
        {
            return candidate.NumberOfRentalsThisMonth >= 5;
        }
    }
}