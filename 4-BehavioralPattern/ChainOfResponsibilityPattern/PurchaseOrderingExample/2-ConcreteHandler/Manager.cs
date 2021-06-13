
namespace PurchaseOrderingExample_2_ConcreteHandler
{
using System;
    using PurchaseOrderingExample_1_Handler;

    /// <summary>
    /// The concrete Manager handler class.
    /// </summary>
    class Manager : POApprover
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PurchaseOrderingExample.Manager"/> class.
		/// </summary>
		/// <param name="successor">The successor in the chain of handlers.</param>
		public Manager(POApprover successor)
		{
			_successor = successor;
		}

		/// <summary>
		/// Process a request.
		/// </summary>
		/// <param name="price">The price of the purchase order request.</param>
		public override void ProcessRequest(decimal price)
		{
			// handle PO if the price is less than $10,000
			if (price <= 10000)
			{
				Console.WriteLine ("${0} purchase approved by {1}", price, this.GetType ().Name);
			}
			else if (_successor != null)
			{
				// pass the request to the successor
				_successor.ProcessRequest (price);

			}
		}
	}
}
