using System;

namespace VisitorPattern
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
			// set up an object structure
			ObjectStructure o = new ObjectStructure();
			o.Attach(new ConcreteElementA());
			o.Attach(new ConcreteElementB());

			// create two visitor objects
			ConcreteVisitor1 v1 = new ConcreteVisitor1();
			ConcreteVisitor2 v2 = new ConcreteVisitor2();

			// have the visitors visit the structure
			o.Accept(v1);
			o.Accept(v2);		
		}
	}
}

