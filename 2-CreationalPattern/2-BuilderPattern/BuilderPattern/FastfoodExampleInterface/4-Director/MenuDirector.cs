namespace FastfoodExample
{
    /// <summary>
    /// The menu director class.
    /// </summary>
    internal class MenuDirector
    {
        /// <summary>
        /// Construct the menu using the specified builder.
        /// </summary>
        /// <param name="builder">The builder to use to construct the menu.</param>
        public void Construct(IMenuBuilder builder)
        {
            builder.BuildBurgerOrSalad();
            builder.BuildFries();
            builder.BuildDessert();
            builder.BuildDrink();
            builder.BuildToy();
        }
    }
}