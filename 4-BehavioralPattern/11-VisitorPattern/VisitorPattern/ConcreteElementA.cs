using System;

namespace VisitorPattern
{
	/// <summary>
	/// The concrete element A class.
	/// </summary>
	public class ConcreteElementA : Element
	{
		/// <summary>
		/// Accept the specified visitor.
		/// </summary>
		/// <param name="visitor">The visitor to accept.</param>
		public override void Accept(Visitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
