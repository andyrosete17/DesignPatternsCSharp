namespace ProductCatalogExampleInterface_1_Visitor
{
    using ProductCatalogExampleInterface_4_ConcreteElement;

    /// <summary>
    /// The abstract visitor class.
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Visit the specified book.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public void Visit(Book product);

        /// <summary>
        /// Visit the specified movie.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public void Visit(Movie product);

        /// <summary>
        /// Visit the specified toy.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public void Visit(Toy product);

        /// <summary>
        /// Visit the specified item of clothing.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public void Visit(Clothing product);
    }
}