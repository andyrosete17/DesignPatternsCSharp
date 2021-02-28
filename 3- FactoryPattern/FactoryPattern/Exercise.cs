using System;

using System.Collections.Generic;

using System.Linq;

namespace FactoryPattern

{
    public class Person

    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static List<Person> personList = new List<Person>();

        private Person(string Name)

        {
            this.Name = Name;
        }

        public override string ToString()

        {
            var retVal = string.Empty;

            int count = 1;

            foreach (var item in personList)

            {
                retVal += $"{(count)}. {nameof(item.Id)}: {(item.Id)}, {nameof(item.Name)}: {(item.Name)}\r\n";
            }

            return retVal;
        }

        public class PersonFactory

        {
            public List<Person> CreatePerson(string Name)

            {
                Person newPerson = new Person(Name);

                int newId = 0;

                if (personList.Any())

                {
                    newId = personList.Max(x => x.Id) + 1;
                }

                newPerson.Id = newId;

                personList.Add(newPerson);

                return personList;
            }
        }

        private static void Main(string[] args)

        {
            var newFactory = new Person.PersonFactory();

            var newList = newFactory.CreatePerson("Aleksandra");

            newFactory.CreatePerson("Goran");

            newFactory.CreatePerson("Nikola");

            foreach (var newListItem in newList)

            {
                Console.WriteLine(newListItem);

                break;
            }

            Console.ReadLine();
        }
    }
}