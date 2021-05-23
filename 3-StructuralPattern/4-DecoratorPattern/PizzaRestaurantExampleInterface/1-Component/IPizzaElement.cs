namespace PizzaRestaurantExampleInterface_1_Component
{
    /// <summary>
    /// The component base interface class that defines a pizza element.
    /// </summary>
    public interface IPizzaElement
    {
        /// <summary>
        /// Get the price of the pizza.
        /// </summary>
        /// <returns>The price of the pizza.</returns>

        decimal GetPrice();
    }
}