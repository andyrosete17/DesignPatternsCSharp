namespace PizzaRestaurantExampleInterface_3_Decorator
{
    using PizzaRestaurantExampleInterface_1_Component;

    /// <summary>
    /// The decorator abstract base class that defines a pizza topping.
    /// </summary>
    public abstract class PizzaTopping : IPizzaElement
    {
        // a reference to the decorated component
        protected IPizzaElement _component;

        /// <summary>
        /// Initializes a new instance of the <see cref="DecoratorPattern.Decorator"/> class.
        /// </summary>
        /// <param name="component">Component.</param>
        protected PizzaTopping(IPizzaElement component)
        {
            _component = component;
        }

        /// <summary>
        /// Get the price of the pizza.
        /// </summary>
        /// <returns>The price of the pizza.</returns>
        public virtual decimal GetPrice()
        {
            return _component.GetPrice();
        }
    }
}