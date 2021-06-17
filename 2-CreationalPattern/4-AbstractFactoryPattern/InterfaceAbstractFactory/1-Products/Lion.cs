namespace FoodchainExample_1_Products
{
    using System;
    using FoodchainExample_2_AbstractProduct;

    /// <summary>
    /// The concrete product class for carnivores in Africa.
    /// </summary>
    internal class Lion : ICarnivore
    {
        /// <summary>
        /// Eat a herbivore.
        /// </summary>
        /// <param name="herbivore">The herbivore to eat.</param>
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine("{0} eats {1}", this.GetType().Name, herbivore.GetType().Name);
        }
    }
}