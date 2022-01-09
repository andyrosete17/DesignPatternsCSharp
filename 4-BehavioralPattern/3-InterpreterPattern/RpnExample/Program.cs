using System;

namespace RpnExample
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
			// instantiate a new evaluator
			var evaluator = new Evaluator ();

			// ask user for RPN expression basic one 5 42 10 - +
			Console.Write ("Enter RPN expression: ");
			string text = Console.ReadLine ();

			// parse text and build expression tree
			var tree = evaluator.Parse (text);

			// get result of expression
			Console.WriteLine ("Result: {0}", tree.Interpret ());
		}
	}
}
