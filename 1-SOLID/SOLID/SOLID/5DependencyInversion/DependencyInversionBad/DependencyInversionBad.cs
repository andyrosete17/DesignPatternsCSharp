using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace SOLID._5DependencyInversion.DependencyInversionBad
{
    // hl modules should not depend on low-level; both should depend on abstractions
    // abstractions should not depend on details; details should depend on abstractions

    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }

    public class Person
    {
        public string Name;
        // public DateTime DateOfBirth;
    }

    public class Relationships  // low-level
    {
        private List<(Person, Relationship, Person)> relations
          = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public List<(Person, Relationship, Person)> Relations => relations;
    }

    public class Research
    {
        public Research(Relationships relationships)
        {
            // high-level: find all of john's children Yhe research class doesnt need to know what have relationship class
            var relations = relationships.Relations;
            foreach (var r in relations
              .Where(x => x.Item1.Name == "John"
                          && x.Item2 == Relationship.Parent))
            {
                WriteLine($"John has a child called {r.Item3.Name}");
            }
        }

        private static void Main(string[] args)
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Matt" };

            // low-level module
            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Research(relationships);
        }
    }
}