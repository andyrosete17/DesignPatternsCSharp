namespace ProductCatalogExampleInterface_5_ObjectStructure
{
    using System.Collections.Generic;
    using ProductCatalogExampleInterface_1_Visitor;
    using ProductCatalogExampleInterface_3_Element;

    /// <summary>
    /// The product catalog class (the object structure).
    /// </summary>
    public class Catalog
    {
        // a list of elements
        private List<IProduct> _products = new List<IProduct>();

        /// <summary>
        /// Add the specified product to the catalog.
        /// </summary>
        /// <param name="product">The product to add.</param>
        public void Add(IProduct product)
        {
            _products.Add(product);
        }

        /// <summary>
        /// Accept the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor to accept.</param>
        public void Accept(IVisitor visitor)
        {
            foreach (IProduct product in _products)
            {
                product.Accept(visitor);
            }
        }
    }
}