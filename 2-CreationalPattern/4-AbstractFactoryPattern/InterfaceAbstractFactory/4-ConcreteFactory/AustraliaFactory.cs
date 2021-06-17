namespace FoodchainExample_4_ConcreteFactory
{
    using FoodchainExample_1_Products;
    using FoodchainExample_2_AbstractProduct;
    using FoodchainExample_3_AbstractFactory;

    /// <summary>
    /// The concrete factory class for Australia.
    /// </summary>
    internal class AustraliaFactory : IContinentFactory
    {
        public IHerbivore CreateHerbivore()
        {
            return new Kangaroo();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Dingo();
        }
    }
}