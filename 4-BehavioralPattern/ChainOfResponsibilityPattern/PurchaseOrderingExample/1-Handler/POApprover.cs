namespace PurchaseOrderingExample_1_Handler
{
    /// <summary>
    /// The abstract POApprover handler class.
    /// </summary>
    public abstract class POApprover
    {
        // the reference to the next handler in the chain
        protected POApprover _successor;

        /// <summary>
        /// Process a request.
        /// </summary>
        /// <param name="price">The price of the purchase order request.</param>
        public abstract void ProcessRequest(decimal price);
    }
}