using System;

namespace VisitorPattern
{
	/// <summary>
	/// The abstract visitor class.
	/// </summary>
	public abstract class Visitor
	{
		/// <summary>
		/// Visit the specified element.
		/// </summary>
		/// <param name="concreteElementA">The element to visit.</param>
		public abstract void Visit(ConcreteElementA concreteElementA);

		/// <summary>
		/// Visit the specified element.
		/// </summary>
		/// <param name="concreteElementA">The element to visit.</param>
		public abstract void Visit(ConcreteElementB concreteElementB);
	}
	
}
