using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScottAspPatterns.CompositePattern
{
    public class HasReachedRentalThresholdSpecification : CompositeSpecification<CustomerAccount>
    {


        public override bool IsSatisfied(CustomerAccount candidate)
        {
            return candidate.NumberOfRentalsThisMonth > 5;
        }
    }
}
