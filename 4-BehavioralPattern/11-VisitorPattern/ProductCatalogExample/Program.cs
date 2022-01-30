namespace ProductCatalogExample
{
    using System;
    using ProductCatalogExample_2_ConcreteVisitor;
    using ProductCatalogExample_4_ConcreteElement;
    using ProductCatalogExample_5_ObjectStructure;

    /// <summary>
    /// The main program class.
    /// </summary>
    internal class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // set up a product catalog with 4 books, 3 movies, 2 toys and 1 item of clothing
            var catalog = new Catalog();
            catalog.Add(new Book());
            catalog.Add(new Book());
            catalog.Add(new Book());
            catalog.Add(new Book());
            catalog.Add(new Movie());
            catalog.Add(new Movie());
            catalog.Add(new Movie());
            catalog.Add(new Toy());
            catalog.Add(new Toy());
            catalog.Add(new Clothing());

            // partition the catalog
            var partitioner = new ProductPartitioner();
            catalog.Accept(partitioner);

            // show results
            Console.WriteLine("{0} books", partitioner.Books);
            Console.WriteLine("{0} movies", partitioner.Movies);
            Console.WriteLine("{0} toys", partitioner.Toys);
            Console.WriteLine("{0} clothing", partitioner.Clothing);
        }
    }
}