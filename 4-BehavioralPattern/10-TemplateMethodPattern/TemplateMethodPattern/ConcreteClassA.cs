using System;

namespace TemplateMethodPattern
{
	/// <summary>
	/// The concrete class A.
	/// </summary>
	class ConcreteClassA : AbstractClass
	{
		/// <summary>
		/// The overridable primitive operation 1.
		/// </summary>
		protected override void PrimitiveOperation1()
		{
			Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
		}

		/// <summary>
		/// The overridable primitive operation 2.
		/// </summary>
		protected override void PrimitiveOperation2()
		{
			Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
		}
	}
	
}
