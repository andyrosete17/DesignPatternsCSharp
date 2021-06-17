namespace FoodchainExample_3_AbstractFactory
{
    using FoodchainExample_2_AbstractProduct;

    /// <summary>
    /// The abstract factory class.
    /// </summary>
    public interface IContinentFactory
    {
        ICarnivore CreateCarnivore();

        IHerbivore CreateHerbivore();
    }
}