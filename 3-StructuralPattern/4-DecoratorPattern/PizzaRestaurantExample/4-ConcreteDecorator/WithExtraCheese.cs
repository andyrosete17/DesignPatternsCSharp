namespace PizzaRestaurantExample_4_ConcreteDecorator
{
    using PizzaRestaurantExample_1_Component;
    using PizzaRestaurantExample_3_Decorator;

    /// <summary>
    /// The concrete decorator class for extra cheese topping.
    /// </summary>
    internal class WithExtraCheese : PizzaTopping
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecoratorPattern.WithExtraCheese"/> class.
        /// </summary>
        /// <param name="component">Component.</param>
        public WithExtraCheese(PizzaElement component)
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
            return basePrice + 1m;
        }
    }
}