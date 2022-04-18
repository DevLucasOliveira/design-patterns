using DependencyInversionPrinciple.Interfaces;
using System;

namespace DependencyInversionPrinciple.Entities
{
    public class Research
    {
        public Research(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
                Console.WriteLine($"John has a child called {p.Name}");
        }
    }

}
