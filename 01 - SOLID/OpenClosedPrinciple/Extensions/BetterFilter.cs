﻿using OpenClosedPrinciple.Entities;
using OpenClosedPrinciple.Interfaces;
using System.Collections.Generic;

namespace OpenClosedPrinciple.Extensions
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            foreach (var item in items)
            {
                if (specification.IsSatisfied(item))
                    yield return item;
            }
        }
    }
}
