using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScottAspPatterns.CompositePattern
{
    public class HasReachedRentalThresholdSpecification : ISpecification<CustomerAccount>
    {
        public bool IsSatisfied(CustomerAccount candidate)
        {
            return candidate.LateFees == 0;
        }

      
    }
}
