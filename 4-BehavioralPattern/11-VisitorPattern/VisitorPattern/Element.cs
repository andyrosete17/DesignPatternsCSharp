using System;

namespace VisitorPattern
{
	/// <summary>
	/// The abstract element class.
	/// </summary>
	public abstract class Element
	{
		/// <summary>
		/// Accept the specified visitor.
		/// </summary>
		/// <param name="visitor">The visitor to accept.</param>
		public abstract void Accept(Visitor visitor);
	}
}
