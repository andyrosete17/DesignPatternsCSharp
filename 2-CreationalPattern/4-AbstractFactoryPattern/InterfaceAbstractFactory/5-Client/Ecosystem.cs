namespace FoodchainExample_5_Client
{
    using FoodchainExample_2_AbstractProduct;
    using FoodchainExample_3_AbstractFactory;

    /// <summary>
    /// The client class.
    /// </summary>
    internal class Ecosystem
    {
        // products
        private IHerbivore _herbivore;

        private ICarnivore _carnivore;

        /// <summary>
        /// Initializes a new instance of the <see cref="FoodchainExample.Ecosystem"/> class.
        /// </summary>
        /// <param name="factory">The factory to use to create carnivores and herbivores.</param>
        public Ecosystem(IContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        /// <summary>
        /// Let the carnivore eat the herbivore.
        /// </summary>
        public void Run()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}