using System;
using System.Collections.Generic;

namespace IteratorPattern
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
			// instantiate a new enumerable collection
			var collection = new Enumerable ();

			// sequentially access each element with the foreach keyword
			foreach (var value in collection)
				Console.WriteLine (value);
		}
	}
}
