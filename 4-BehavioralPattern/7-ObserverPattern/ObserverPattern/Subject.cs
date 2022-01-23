using System;

namespace ObserverPattern
{
	/// <summary>
	/// A delegate that defines the Notify event and Update method signatures.
	/// </summary>
	public delegate void NotifyEvent<T>(T subject, NotifyEventArgs args);

	/// <summary>
	/// The subject class.
	/// </summary>
	public class Subject
	{
		// the notify event
		public event NotifyEvent<Subject> Notify;

		// the internal state of the subject
		private string _subjectState;

		/// <summary>
		/// Changes the state of the subject.
		/// </summary>
		/// <param name="state">The new state.</param>
		public void ChangeState(string state)
		{
			Console.WriteLine ("Changing subject state to {0}", state);
			_subjectState = state;

			// fire the notify event
			if (Notify != null)
			{
				Notify(this, new NotifyEventArgs(_subjectState));
			}
		}
	}
}
