using System;

namespace ObserverPattern
{
	/// <summary>
	/// The observer class.
	/// </summary>
	public class Observer
	{
		// the name of the observer
		private string _name;

		// the state of the observer, which is kept in sync with the subject
		private string _observerState;

		/// <summary>
		/// Initializes a new instance of the <see cref="ObserverPattern.Observer"/> class.
		/// </summary>
		/// <param name="name">The name of the observer.</param>
		public Observer(string name)
		{
			this._name = name;
		}

		/// <summary>
		/// Update the state of the observer.
		/// </summary>
		/// <param name="sender">The subject sending the notify event.</param>
		/// <param name="args">The event arguments holding the new subject state.</param>
		public void Update(Subject sender, NotifyEventArgs args)
		{
			_observerState = args.State;
			Console.WriteLine ("{0} syncing state to {1}", _name, _observerState);
		}
	}
}
