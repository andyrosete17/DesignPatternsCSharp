using System;
using System.Collections.Generic;
using System.Collections;

namespace IteratorPattern
{
	/// <summary>
	/// The concrete aggregate class, called an 'Enumerable' in dotNet.
	/// </summary>
	public class Enumerable : IEnumerable<int>
	{
		// DEMO: provide three interal fields that the enumerator will access sequentially
		internal int first = 1;
		internal int second = 2;
		internal int third = 3;

		// explicitly implement the non-generic IEnumerable interface
		System.Collections.IEnumerator IEnumerable.GetEnumerator()
		{
			// defer to the generic IEnumerable<T> implementation
			return this.GetEnumerator();
		}

		/// <summary>
		/// Gets the enumerator for sequentially accessing elements.
		/// </summary>
		/// <returns>The enumerator to sequentially access elements.</returns>
		public IEnumerator<int> GetEnumerator()
		{
			return new Enumerator(this);
		}
	}
	
}
