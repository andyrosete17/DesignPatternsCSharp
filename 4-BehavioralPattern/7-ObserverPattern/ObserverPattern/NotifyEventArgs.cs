using System;

namespace ObserverPattern
{
	/// <summary>
	/// The notify event arguments class.
	/// </summary>
	public class NotifyEventArgs : EventArgs
	{
		// the state of the subject
		private string _state = null;

		/// <summary>
		/// Gets the state of the subject.
		/// </summary>
		/// <value>The state of the subject.</value>
		public string State 
		{
			get 
			{
				return _state;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ObserverPattern.NotifyEventArgs"/> class.
		/// </summary>
		/// <param name="state">The current state of the subject.</param>
		public NotifyEventArgs (string state)
		{
			_state = state;
		}
	}
}

