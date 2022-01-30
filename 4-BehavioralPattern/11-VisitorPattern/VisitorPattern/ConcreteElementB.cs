using System;

namespace VisitorPattern
{
	/// <summary>
	/// The concrete element B class.
	/// </summary>
	public class ConcreteElementB : Element
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
