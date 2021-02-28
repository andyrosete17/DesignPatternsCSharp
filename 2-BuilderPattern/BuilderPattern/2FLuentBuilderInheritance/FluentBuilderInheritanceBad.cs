using System.Text;
using static System.Console;

namespace BuilderPattern.FLuentBuilderInheritance
{
    public  class FluentBuilderInheritanceBad
    {

        public class Person
        {
            public string Name;
            public string Position;

            public override string ToString()
            {
                return $"{nameof(Name)}:{Name}, {nameof(Position)}:{Position}";
            }
        }

        public class PersonInfoBuilder
        {
            protected Person person = new Person();

            //Fluent builder because we are returning a reference of the class
            public PersonInfoBuilder Called(string name)
            {
                person.Name = name;
                return this;
            }
        }

        // If someone required additional funtionality you use the open close principle, and
        // just create  your new builder inherid from the base one
        public class PersonJobBuilder: PersonInfoBuilder
        {
            public PersonJobBuilder WorkAs (string position)
            {
                person.Position = position;
                return this;
            }
        }

        private static void Main(string[] args)
        {
            // As you can see, when you call Called method the class is returning a personInfoBuilder
            // but this one doesnt know aboput personJobBuilder interfaces,so its impossible to accesss to theother interface method within inheritance of fluid interface
            var builder = new PersonJobBuilder();
            builder.Called("Andy");
            builder.WorkAs("Engineer");
            WriteLine(builder.ToString());
        }
    }
}