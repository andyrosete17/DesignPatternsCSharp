using System;
using System.Collections.Generic;

namespace VisitorPattern
{
	/// <summary>
	/// The object structure class.
	/// </summary>
	public class ObjectStructure
	{
		// a list of elements
		private List<Element> _elements = new List<Element>();

		/// <summary>
		/// Attach the specified element to the structure.
		/// </summary>
		/// <param name="element">The element to attach.</param>
		public void Attach(Element element)
		{
			_elements.Add(element);
		}

		/// <summary>
		/// Detach the specified element from the structure.
		/// </summary>
		/// <param name="element">The element to detach.</param>
		public void Detach(Element element)
		{
			_elements.Remove(element);
		}

		/// <summary>
		/// Accept the specified visitor.
		/// </summary>
		/// <param name="visitor">The visitor to accept.</param>
		public void Accept(Visitor visitor)
		{
			foreach (Element element in _elements)
			{
				element.Accept(visitor);
			}
		}
	}
}
