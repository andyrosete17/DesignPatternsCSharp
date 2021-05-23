namespace PizzaRestaurantExampleInterface_2_ConcreteComponent
{
    using PizzaRestaurantExampleInterface_1_Component;

    /// <summary>
    /// The concrete component class for a fungi pizza.
    /// </summary>
    public class Fungi : IPizzaElement
    {
        /// <summary>
        /// Get the price of the pizza.
        /// </summary>
        /// <returns>The price of the pizza.</returns>
        public decimal GetPrice()
        {
            return 10m;
        }
    }
}