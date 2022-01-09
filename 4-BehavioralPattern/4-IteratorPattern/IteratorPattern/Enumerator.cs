using System;
using System.Collections.Generic;
using System.Collections;

namespace IteratorPattern
{
	/// <summary>
	/// The concrete iterator class, called an 'Enumerator' in dotNet. 
	/// </summary>
	public class Enumerator : IEnumerator<int>
	{
		// the enumerable to use
		private Enumerable _enumerable;

		// the index number of the current item 
		private int _current = -1;

		/// <summary>
		/// Initializes a new instance of the <see cref="IteratorPattern.Enumerator"/> class.
		/// </summary>
		/// <param name="enumerable">Enumerable.</param>
		public Enumerator(Enumerable enumerable)
		{
			this._enumerable = enumerable;
		}

		/// <summary>
		/// Reset the enumerator to the first element. 
		/// </summary>
		public void Reset ()
		{
			_current = -1;
		}

		/// <summary>
		/// Gets the current element in the enumerable sequence.
		/// </summary>
		/// <value>The current element in the enumerable sequence.</value>
		public int Current
		{
			get
			{
				switch (_current)
				{
					case 0:
					return _enumerable.first;
					case 1:
					return _enumerable.second;
					case 2:
					return _enumerable.third;
					default:
					throw new IndexOutOfRangeException ();
				}
			}
		}

		// explicitly implement the non-generic IEnumerator.Current property
		object IEnumerator.Current
		{
			get {
				// defer to the generic IEnumerator<T>.Current implementation
				return Current;
			}
		}

		/// <summary>
		/// Move to the next element in the sequence.
		/// </summary>
		/// <returns><c>true</c> if a new element is available, <c>false</c> otherwise.</returns>
		public bool MoveNext()
		{
			if (_current <= 2)
				_current++;
			return _current <= 2;
		}

		/// <summary>
		/// Releases all resource used by the <see cref="IteratorPattern.Enumerator"/> object.
		/// </summary>
		/// <remarks>Call <see cref="Dispose"/> when you are finished using the <see cref="IteratorPattern.Enumerator"/>. The
		/// <see cref="Dispose"/> method leaves the <see cref="IteratorPattern.Enumerator"/> in an unusable state. After
		/// calling <see cref="Dispose"/>, you must release all references to the <see cref="IteratorPattern.Enumerator"/> so
		/// the garbage collector can reclaim the memory that the <see cref="IteratorPattern.Enumerator"/> was occupying.</remarks>
		public void Dispose ()
		{
			// do nothing
		}

	}
}
