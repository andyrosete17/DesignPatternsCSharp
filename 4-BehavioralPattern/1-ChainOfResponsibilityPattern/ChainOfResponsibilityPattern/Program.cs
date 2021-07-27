using System;

namespace ChainOfResponsibilityPattern
{
	/// <summary>
	/// The main program class.
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			// initialise the client
			var client = new Client ();

			// feed some requests into the chain
			client.HandleRequest ("2");
			client.HandleRequest ("1");
			client.HandleRequest ("3");
			client.HandleRequest ("12");
		}
	}
}
