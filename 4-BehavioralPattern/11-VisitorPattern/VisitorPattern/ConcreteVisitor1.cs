using System;

namespace VisitorPattern
{
	/// <summary>
	/// A concrete visitor class.
	/// </summary>
	public class ConcreteVisitor1 : Visitor
	{
		/// <summary>
		/// Visit the specified element.
		/// </summary>
		/// <param name="concreteElementA">The element to visit.</param>
		public override void Visit(ConcreteElementA concreteElementA)
		{
			Console.WriteLine ("ConcreteVisitor1 visiting ConcreteElementA");
		}

		/// <summary>
		/// Visit the specified element.
		/// </summary>
		/// <param name="concreteElementA">The element to visit.</param>
		public override void Visit(ConcreteElementB concreteElementB)
		{
			Console.WriteLine ("ConcreteVisitor1 visiting ConcreteElementB");
		}
	}
	
}
