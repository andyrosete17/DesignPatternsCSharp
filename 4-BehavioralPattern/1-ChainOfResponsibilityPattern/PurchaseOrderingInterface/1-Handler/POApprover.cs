namespace PurchaseOrderingInterface_1_Handler
{
    /// <summary>
    /// The  IPOApprover interface  handler class.
    /// </summary>
    public interface  IPOApprover
    {
        // the reference to the next handler in the chain
        public IPOApprover _successor { get; set; }

        /// <summary>
        /// Process a request.
        /// </summary>
        /// <param name="price">The price of the purchase order request.</param>
        void ProcessRequest(decimal price);
    }
}