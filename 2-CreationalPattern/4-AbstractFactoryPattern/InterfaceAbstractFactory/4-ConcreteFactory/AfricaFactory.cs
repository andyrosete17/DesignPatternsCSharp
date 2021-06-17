namespace FoodchainExample_4_ConcreteFactory
{
    using FoodchainExample_1_Products;
    using FoodchainExample_2_AbstractProduct;
    using FoodchainExample_3_AbstractFactory;

    /// <summary>
    /// The concrete factory class for Africa.
    /// </summary>
    internal class AfricaFactory : IContinentFactory
    {
        public IHerbivore CreateHerbivore()
        {
            return new Zebra();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}