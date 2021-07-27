using System;

namespace ChainOfResponsibilityPattern
{
	/// <summary>
	/// The abstract handler class.
	/// </summary>
	public abstract class Handler
	{
		// the reference to the next handler in the chain
		protected Handler _successor;

		/// <summary>
		/// Handles a request.
		/// </summary>
		/// <param name="request">The request to handle.</param>
		public abstract void HandleRequest(object request);
	}
}
