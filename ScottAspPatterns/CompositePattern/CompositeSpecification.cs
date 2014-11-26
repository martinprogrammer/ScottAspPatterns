using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.CompositePattern
{
    public abstract class CompositeSpecification<T> :  ISpecification<T> where T : class
    {
        public abstract bool IsSatisfied(T candidate);

        public ISpecification<T> And (ISpecification<T> other)
        {
            return new AndSpecification<T>(this, other);
        }

        public ISpecification<T>Not()
        {
            return new NotSpecification<T>(this);
        }

      
    }
}