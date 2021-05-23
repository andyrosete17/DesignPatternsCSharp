namespace PizzaRestaurantExample_3_Decorator
{
    using PizzaRestaurantExample_1_Component;

    /// <summary>
    /// The decorator abstract base class that defines a pizza topping.
    /// </summary>
    public abstract class PizzaTopping : PizzaElement
    {
        // a reference to the decorated component
        protected PizzaElement _component;

        /// <summary>
        /// Initializes a new instance of the <see cref="DecoratorPattern.Decorator"/> class.
        /// </summary>
        /// <param name="component">Component.</param>
        protected PizzaTopping(PizzaElement component)
        {
            _component = component;
        }

        /// <summary>
        /// Get the price of the pizza.
        /// </summary>
        /// <returns>The price of the pizza.</returns>
        public override decimal GetPrice()
        {
            return _component.GetPrice();
        }
    }
}