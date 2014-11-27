using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.CompositePattern
{
    public class CustomersAccountHasLateFees : CompositeSpecification<CustomerAccount>
    {

        public override bool IsSatisfied(CustomerAccount candidate)
        {
            return candidate.LateFees > 0; ;
        }
    }
}