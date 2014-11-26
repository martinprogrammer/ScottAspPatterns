using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.CompositePattern
{
    public class CustomerAccountStillActive : ISpecification<CustomerAccount>
    {
        public bool IsSatisfied(CustomerAccount candidate)
        {
            return candidate.AccountActive;
        }
    }
}