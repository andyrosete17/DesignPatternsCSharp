namespace ProductCatalogExampleInterface_3_Element
{
    using ProductCatalogExampleInterface_1_Visitor;

    /// <summary>
    /// The abstract product class (the element class).
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Accept the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor to accept.</param>
        public void Accept(IVisitor visitor);
    }
}