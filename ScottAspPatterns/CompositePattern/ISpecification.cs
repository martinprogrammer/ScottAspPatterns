using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.CompositePattern
{
    public interface ISpecification<T> where T : class
    {
        bool IsSatisfied(T candidate);
        ISpecification<T> And(ISpecification<T> other);
        ISpecification<T> Not();
    }
}