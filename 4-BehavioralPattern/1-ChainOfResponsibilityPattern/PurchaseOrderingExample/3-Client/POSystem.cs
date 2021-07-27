namespace PurchaseOrderingExample_3_Client
{
    using PurchaseOrderingExample_1_Handler;
    using PurchaseOrderingExample_2_ConcreteHandler;

    /// <summary>
    /// The POSystem client class.
    /// </summary>
    public class POSystem
    {
        // the PO approval chain
        protected POApprover approvalChain = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderingExample.POSystem"/> class.
        /// </summary>
        public POSystem()
        {
            // set up a chain of purchase order approvers
            approvalChain = new Manager(
                new VicePresident(
                new CEO(null)));
        }

        /// <summary>
        /// Process a request.
        /// </summary>
        /// <param name="price">The price of the purchase order request.</param>
        public void ProcessRequest(decimal price)
        {
            approvalChain.ProcessRequest(price);
        }
    }
}