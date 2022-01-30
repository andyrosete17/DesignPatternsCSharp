namespace ProductCatalogExample_1_Visitor
{
    using ProductCatalogExample_4_ConcreteElement;

    /// <summary>
    /// The abstract visitor class.
    /// </summary>
    public abstract class Visitor
    {
        /// <summary>
        /// Visit the specified book.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public abstract void Visit(Book product);

        /// <summary>
        /// Visit the specified movie.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public abstract void Visit(Movie product);

        /// <summary>
        /// Visit the specified toy.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public abstract void Visit(Toy product);

        /// <summary>
        /// Visit the specified item of clothing.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public abstract void Visit(Clothing product);
    }
}