using System;
using System.Collections;

namespace FlyweightPattern
{
	/// <summary>
	/// The main program class.
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			// instantiate a new client
			var client = new Client ();

			// perform a client operation
			client.Operation ();
		}
	}
}
