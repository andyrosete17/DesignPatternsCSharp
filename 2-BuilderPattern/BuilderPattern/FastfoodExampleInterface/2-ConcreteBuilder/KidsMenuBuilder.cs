namespace FastfoodExample
{
    /// <summary>
    /// The concrete builder class for a kids menu.
    /// </summary>
    internal class KidsMenuBuilder : IMenuBuilder
    {
        // the menu being constructed
        private Menu _menu = new Menu();

        /// <summary>
        /// Build burger or salad.
        /// </summary>
        public void BuildBurgerOrSalad()
        {
            _menu.Add("Burger");
        }

        /// <summary>
        /// Build fries.
        /// </summary>
        public void BuildFries()
        {
            _menu.Add("Fries");
        }

        /// <summary>
        /// Build dessert.
        /// </summary>
        public void BuildDessert()
        {
            // the kid menu has no dessert
        }

        /// <summary>
        /// Build drink.
        /// </summary>
        public void BuildDrink()
        {
            _menu.Add("Drink");
        }

        /// <summary>
        /// Build toy.
        /// </summary>
        public void BuildToy()
        {
            _menu.Add("Toy");
        }

        /// <summary>
        /// Gets the finished menu.
        /// </summary>
        /// <returns>The finished menu.</returns>
        public Menu GetResult()
        {
            return _menu;
        }
    }
}