using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern.FunctionalBuilder
{
    public class Person
    {
        public string Name, Position, Experience;

        public override string ToString()
        {
            return $"Name: {Name} -- Position: {Position} -- Experience: {Experience} years";
        }
    }


    /// <summary>
    /// You cant inherid from this class because is sealed
    /// </summary>
    public sealed class PersonBuilder
    {
        public readonly List<Action<Person>> Actions
            = new List<Action<Person>>();

        public PersonBuilder Called(string name)
        {
            Actions.Add(p => { p.Name = name; });
            return this;
        }

        public Person Build()
        {
            var p = new Person();
            Actions.ForEach(a => a(p));
            return p;
        }
    }

    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAsA
            (this PersonBuilder builder, string position)
        {
            builder.Actions.Add(p =>
            {
                p.Position = position;
            });
            return builder;
        }

        public static PersonBuilder Experience
            (this PersonBuilder builder, string experience)
        {
            builder.Actions.Add(p =>
            {
                p.Experience = experience;
            });
            return builder;
        }
    }

    public class FunctionalBuilder
    {
        public static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            var person = pb.Called("Andy").WorksAsA("Developer").Experience("5").Build();
            WriteLine(person.ToString());
        }
    }
}