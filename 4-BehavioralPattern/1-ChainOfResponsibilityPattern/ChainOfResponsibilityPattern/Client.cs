using System;

namespace ChainOfResponsibilityPattern
{
	/// <summary>
	/// The Client class.
	/// </summary>
	public class Client
	{
		// the chain of handlers
		protected Handler handlers = null;

		/// <summary>
		/// Initializes a new instance of the <see cref="ChainOfResponsibilityPattern.Client"/> class.
		/// </summary>
		public Client ()
		{
			// set up a chain of handlers
			handlers = new ConcreteHandler1 (
				new ConcreteHandler2 (
				new ConcreteHandler3 (null)));
		}

		/// <summary>
		/// Handles a request.
		/// </summary>
		/// <param name="request">The request to handle.</param>
		public void HandleRequest(object request)
		{
			handlers.HandleRequest (request);
		}
	}
}

