using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScottAspPatterns.CompositePattern
{
    public class AndSpecification<T> : CompositeSpecification<T> where T : class
    {
        private ISpecification<T> _leftSpecification;
        private ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }


        public override bool IsSatisfied(T candidate)
        {
            return _leftSpecification.IsSatisfied(candidate) && _rightSpecification.IsSatisfied(candidate);
        }
    }
}
