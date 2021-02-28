using static System.Console;
/// <summary>
/// This approach is more complex due to the use of generics, it brings a nice solution but its not the best approach
/// </summary>


namespace BuilderPattern.FLuentBuilderInheritance
{
    public class FluentBuilderInheritanceGood
    {
        public class Person
        {
            public string Name;
            public string Position;

            public class Builder : PersonJobBuilder<Builder>
            {
            }

            public static Builder New => new Builder();

            public override string ToString()
            {
                return $"{nameof(Name)}:{Name}, {nameof(Position)}:{Position}";
            }
        }

        public abstract class PersonBuilder
        {
            protected Person person = new Person();

            public Person Build()
            {
                return person;
            }
        }

        public class PersonInfoBuilder<SELF>
            : PersonBuilder
            where SELF : PersonInfoBuilder<SELF>
        {
            //Fluent builder because we are returning a reference of the class
            public SELF Called(string name)
            {
                person.Name = name;
                return (SELF)this;
            }
        }

        // If someone required additional funtionality you use the open close principle, and
        // just create  your new builder inherid from the base one
        public class PersonJobBuilder<SELF>
            : PersonInfoBuilder<PersonJobBuilder<SELF>>
            where SELF : PersonJobBuilder<SELF>
        {
            public SELF WorkAs(string position)
            {
                person.Position = position;
                return (SELF)this;
            }
        }

        private static void Main(string[] args)
        {
            // As you can see, when you call Called method the class is returning a personInfoBuilder
            // but this one doesnt know aboput personJobBuilder interfaces,so its impossible to accesss to theother interface method within inheritance of fluid interface
            var me = Person.New
                           .Called("Andy")
                           .WorkAs("Developer")
                           .Build();

            WriteLine(me);
        }
    }
}