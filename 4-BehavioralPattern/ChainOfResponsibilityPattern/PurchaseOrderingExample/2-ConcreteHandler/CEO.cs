namespace PurchaseOrderingExample_2_ConcreteHandler
{
    using System;
    using PurchaseOrderingExample_1_Handler;

    /// <summary>
    /// The concrete CEO handler class.
    /// </summary>
    internal class CEO : POApprover
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderingExample.CEO"/> class.
        /// </summary>
        /// <param name="successor">The successor in the chain of handlers.</param>
        public CEO(POApprover successor)
        {
            _successor = successor;
        }

        /// <summary>
        /// Process a request.
        /// </summary>
        /// <param name="price">The price of the purchase order request.</param>
        public override void ProcessRequest(decimal price)
        {
            // handle PO if the price is less than $100,000
            if (price <= 100000)
            {
                Console.WriteLine("${0} purchase approved by {1}", price, this.GetType().Name);
            }
            else
            {
                // escalate request (because CEO is at the end of the chain)
                Console.WriteLine("Plan executive meeting to approve ${0} purchase", price);
            }
        }
    }
}