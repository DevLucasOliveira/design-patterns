﻿namespace OpenClosedPrinciple.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T entitiy);
    }
}
