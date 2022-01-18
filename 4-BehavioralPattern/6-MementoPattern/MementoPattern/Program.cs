using System;

namespace MementoPattern
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
			// instantiate an originator
			var originator = new Originator();
			originator.State = "On";

			// use memento to take snapshot of internal state
			var memento = originator.CreateMemento();

			// put memento in caretaker for safekeeping
			var caretaker = new Caretaker();
			caretaker.Memento = memento;

			// change originator state
			originator.State = "Off";

			// restore saved state
			originator.SetMemento(caretaker.Memento);
		}
	}
}
