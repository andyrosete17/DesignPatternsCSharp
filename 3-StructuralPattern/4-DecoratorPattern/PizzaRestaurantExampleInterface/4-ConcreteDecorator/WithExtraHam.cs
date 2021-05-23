namespace PizzaRestaurantExampleInterface_4_ConcreteDecorator
{
    using PizzaRestaurantExampleInterface_1_Component;
    using PizzaRestaurantExampleInterface_3_Decorator;

    /// <summary>
    /// The concrete decorator class for extra ham topping.
    /// </summary>
    internal class WithExtraHam : PizzaTopping
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecoratorPattern.WithExtraHam"/> class.
        /// </summary>
        /// <param name="component">Component.</param>
        public WithExtraHam(IPizzaElement component)
            : base(component)
        {
        }

        /// <summary>
        /// Get the price of the pizza.
        /// </summary>
        /// <returns>The price of the pizza.</returns>
        public override decimal GetPrice()
        {
            var basePrice = base.GetPrice();
            return basePrice + 1.50m;
        }
    }
}