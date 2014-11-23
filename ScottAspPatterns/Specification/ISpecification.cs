using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Specification
{
    public interface ISpecification<T> where T : class
    {
        bool IsSatisfiedBy(T candidate);
    }
}