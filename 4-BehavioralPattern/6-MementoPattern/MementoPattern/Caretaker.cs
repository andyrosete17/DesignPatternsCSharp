using System;

namespace MementoPattern
{
	/// <summary>
	/// The caretaker class.
	/// </summary>
	class Caretaker
	{
		// a reference to the memento instance to use
		private object _memento;

		/// <summary>
		/// Gets or sets the memento.
		/// </summary>
		/// <value>The memento to get or set.</value>
		public object Memento
		{
			set { _memento = value; }
			get { return _memento; }
		}
	}
}
