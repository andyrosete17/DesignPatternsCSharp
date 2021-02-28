namespace FoodchainExample
{
    /// <summary>
    /// The abstract product class for carnivores.
    /// </summary>
    public interface ICarnivore
    {
        /// <summary>
        /// Eat a herbivore.
        /// </summary>
        /// <param name="herbivore">The herbivore to eat.</param>
        void Eat(IHerbivore herbivore);
    }
}