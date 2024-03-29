﻿using DependencyInversionPrinciple.Entities;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.Interfaces
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

}
