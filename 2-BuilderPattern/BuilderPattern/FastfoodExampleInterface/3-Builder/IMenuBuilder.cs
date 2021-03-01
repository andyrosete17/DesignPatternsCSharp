namespace FastfoodExample
{
    /// <summary>
    /// The abstract menu builder class.
    /// </summary>
    public interface IMenuBuilder
    {
        /// <summary>
        /// Build burger or salad.
        /// </summary>
        void BuildBurgerOrSalad();

        /// <summary>
        /// Build fries.
        /// </summary>
        void BuildFries();

        /// <summary>
        /// Build dessert.
        /// </summary>
        void BuildDessert();

        /// <summary>
        /// Build drink.
        /// </summary>
        void BuildDrink();

        /// <summary>
        /// Build toy.
        /// </summary>
        void BuildToy();

        /// <summary>
        /// Gets the finished menu.
        /// </summary>
        /// <returns>The finished menu.</returns>
        Menu GetResult();
    }
}