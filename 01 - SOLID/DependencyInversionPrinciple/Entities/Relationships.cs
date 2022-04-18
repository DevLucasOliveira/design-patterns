using DependencyInversionPrinciple.Enums;
using DependencyInversionPrinciple.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple.Entities
{
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person, ERelationship, Person)> relations = new();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, ERelationship.Parent, child));
            relations.Add((child, ERelationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations.Where(x => x.Item1.Name == name && x.Item2 == ERelationship.Parent).Select(r => r.Item3);
        }
    }

}
