using System;

namespace ToyFactoryExample
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            // create a firetruck
            Console.WriteLine("Creating a firetruck toy:");
            ToyCreator creator = new FiretruckCreator();
            creator.MakeToy();
            Console.WriteLine();

            // create a superman
            Console.WriteLine("Creating a superman toy:");
            creator = new SupermanCreator();
            creator.MakeToy();
            Console.WriteLine();

            var name = "firetruck";
            ToyCreationSelector(name);
            name = "superman";
            ToyCreationSelector(name);
            name = "weird";
            ToyCreationSelector(name);
        }

        private static void ToyCreationSelector(string name)
        {
            switch (name)
            {
                case "firetruck":
                    new FiretruckCreator().MakeToy();
                    break;

                case "superman":
                    new SupermanCreator().MakeToy();
                    break;

                default:
                    new DuckCreator().MakeToy();
                    break;
            }
        }
    }
}