using System;

namespace TimerExample
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
			// instantiate a new timer
			var timer = new Timer ();

			// instantiate a new console clock
			var clock = new ConsoleClock ();

			// connect the clock to the timer
			timer.Notify += clock.Update;

			// start the timer
			timer.Start ();
		}
	}
}
