using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScottAspPatterns.CompositePattern
{
    public class NotSpecification<T> : CompositeSpecification<T> where T : class
    {
        ISpecification<T> _innerSpecification;
    

        public NotSpecification(ISpecification<T> innerSpecification)
        {
            _innerSpecification = innerSpecification;

        }

        public override bool IsSatisfied(T candidate)
        {
            return !_innerSpecification.IsSatisfied(candidate) ;
        }
    }
}
