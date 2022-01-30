using System;

namespace TemplateMethodPattern
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
			// execute method with overrides in concrete class A
			AbstractClass variation1 = new ConcreteClassA();
			variation1.TemplateMethod();

			// execute method with overrides in concrete class B
			AbstractClass variation2 = new ConcreteClassB();
			variation2.TemplateMethod();
		}
	}
}
