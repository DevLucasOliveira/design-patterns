using OpenClosedPrinciple.Interfaces;
using System;

namespace OpenClosedPrinciple.Extensions
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(T entitiy)
        {
            return first.IsSatisfied(entitiy) && second.IsSatisfied(entitiy);
        }
    }
}
