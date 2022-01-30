namespace ProductCatalogExample_3_Element
{
    using ProductCatalogExample_1_Visitor;

    /// <summary>
    /// The abstract product class (the element class).
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// Accept the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor to accept.</param>
        public abstract void Accept(Visitor visitor);
    }
}