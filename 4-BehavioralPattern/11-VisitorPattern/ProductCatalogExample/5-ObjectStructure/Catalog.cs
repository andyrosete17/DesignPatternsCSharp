namespace ProductCatalogExample_5_ObjectStructure
{
    using System.Collections.Generic;
    using ProductCatalogExample_1_Visitor;
    using ProductCatalogExample_3_Element;

    /// <summary>
    /// The product catalog class (the object structure).
    /// </summary>
    public class Catalog
    {
        // a list of elements
        private List<Product> _products = new List<Product>();

        /// <summary>
        /// Add the specified product to the catalog.
        /// </summary>
        /// <param name="product">The product to add.</param>
        public void Add(Product product)
        {
            _products.Add(product);
        }

        /// <summary>
        /// Accept the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor to accept.</param>
        public void Accept(Visitor visitor)
        {
            foreach (Product product in _products)
            {
                product.Accept(visitor);
            }
        }
    }
}