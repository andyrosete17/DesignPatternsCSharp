namespace ProductCatalogExampleInterface_2_ConcreteVisitor
{
    using ProductCatalogExampleInterface_1_Visitor;
    using ProductCatalogExampleInterface_4_ConcreteElement;

    /// <summary>
    /// The product partitioner class (the concrete visitor).
    /// </summary>
    public class ProductPartitioner : IVisitor
    {
        // product subtotal counters
        protected int _books = 0;

        protected int _movies = 0;
        protected int _toys = 0;
        protected int _clothing = 0;

        #region Product count properties

        /// <summary>
        /// Gets the number of books.
        /// </summary>
        /// <value>The number of books.</value>
        public int Books
        {
            get { return _books; }
        }

        /// <summary>
        /// Gets the number of movies.
        /// </summary>
        /// <value>The number of movies.</value>
        public int Movies
        {
            get { return _movies; }
        }

        /// <summary>
        /// Gets the number of toys.
        /// </summary>
        /// <value>The number of toys.</value>
        public int Toys
        {
            get { return _toys; }
        }

        /// <summary>
        /// Gets the number of items of clothing.
        /// </summary>
        /// <value>The number of items of clothing.</value>
        public int Clothing
        {
            get { return _clothing; }
        }

        #endregion Product count properties

        /// <summary>
        /// Visit the specified book.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public void Visit(Book product)
        {
            _books++;
        }

        /// <summary>
        /// Visit the specified movie.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public void Visit(Movie product)
        {
            _movies++;
        }

        /// <summary>
        /// Visit the specified toy.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public void Visit(Toy product)
        {
            _toys++;
        }

        /// <summary>
        /// Visit the specified item of clothing.
        /// </summary>
        /// <param name="product">The product to visit.</param>
        public void Visit(Clothing product)
        {
            _clothing++;
        }
    }
}