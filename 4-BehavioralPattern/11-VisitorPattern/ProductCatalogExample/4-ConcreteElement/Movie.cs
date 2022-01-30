namespace ProductCatalogExample_4_ConcreteElement
{
    using ProductCatalogExample_1_Visitor;
    using ProductCatalogExample_3_Element;

    /// <summary>
    /// The movie class (a concrete element).
    /// </summary>
    public class Movie : Product
    {
        /// <summary>
        /// Accept the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor to accept.</param>
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}