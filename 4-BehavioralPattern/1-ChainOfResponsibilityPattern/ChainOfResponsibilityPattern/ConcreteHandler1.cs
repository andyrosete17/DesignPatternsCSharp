using System;

namespace ChainOfResponsibilityPattern
{
	/// <summary>
	/// A concrete handler class.
	/// </summary>
	class ConcreteHandler1 : Handler
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChainOfResponsibilityPattern.ConcreteHandler1"/> class.
		/// </summary>
		/// <param name="successor">The successor in the chain of handlers.</param>
		public ConcreteHandler1(Handler successor)
		{
			_successor = successor;
		}

		/// <summary>
		/// Handles a request.
		/// </summary>
		/// <param name="request">The request to handle.</param>
		public override void HandleRequest(object request)
		{
			// demo code: handle request if name of handler ends with request number
			if (this.GetType ().Name.EndsWith(request.ToString()))
			{
				Console.WriteLine ("Request {0} handled by {1}", request, this.GetType ().Name);
			}
			else if (_successor != null)
			{
				// pass the request to the successor
				_successor.HandleRequest (request);

			} else
			{
				// escalation code goes here
				Console.WriteLine ("Request {0} escalated", request);
			}
		}
	}
}
