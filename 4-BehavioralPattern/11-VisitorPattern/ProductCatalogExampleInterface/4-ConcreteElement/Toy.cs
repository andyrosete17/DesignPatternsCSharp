namespace ProductCatalogExampleInterface_4_ConcreteElement
{
    using ProductCatalogExampleInterface_1_Visitor;
    using ProductCatalogExampleInterface_3_Element;

    /// <summary>
    /// The toy class (a concrete element).
    /// </summary>
    public class Toy : IProduct
    {
        /// <summary>
        /// Accept the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor to accept.</param>
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}