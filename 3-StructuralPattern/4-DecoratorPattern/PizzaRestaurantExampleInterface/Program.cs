namespace PizzaRestaurantExample
{
    using System;
    using PizzaRestaurantExampleInterface_2_ConcreteComponent;
    using PizzaRestaurantExampleInterface_4_ConcreteDecorator;

    /// <summary>
    /// The main program class.
    /// </summary>
    internal class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // create a margarita pizza with extra ham
            var pizza =
                new WithExtraHam(
                new Margarita());

            // get the price of the pizza
            var price = pizza.GetPrice();
            Console.WriteLine("Margarita + ham: {0}", price);

            // create a fungi pizza with extra ham and cheese
            var cheesseHamPizza =
                new WithExtraHam(
                new WithExtraCheese(
                new Fungi()));

            var newpizza = new WithExtraCheese(new QuatroStagioni());

            // get the price of the pizza
            price = cheesseHamPizza.GetPrice();
            Console.WriteLine("Fungi + ham,cheese: {0}", price);
        }
    }
}