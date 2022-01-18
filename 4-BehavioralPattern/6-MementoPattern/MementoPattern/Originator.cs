using System;

namespace MementoPattern
{
	/// <summary>
	/// The originator class.
	/// </summary>
	public class Originator
	{
		/// <summary>
		/// The memento class. The class is private and sealed to shield the state from the outside world. 
		/// </summary>
		private sealed class Memento
		{
			// the recorded state of the originator
			private string _state;

			/// <summary>
			/// Initializes a new instance of the <see cref="MementoPattern.Memento"/> class.
			/// </summary>
			/// <param name="state">The state to record.</param>
			public Memento(string state)
			{
				this._state = state;
			}

			/// <summary>
			/// Gets the state of the memento.
			/// </summary>
			/// <value>The state of the memento.</value>
			public string State
			{
				get { return _state; }
			}
		}

		// the internal state of the originator
		// in this example the state is a string
		private string _state;

		/// <summary>
		/// Gets or sets the state of the originator.
		/// </summary>
		/// <value>The state of the originator.</value>
		public string State
		{
			get { return _state; }
			set
			{
				_state = value;
				Console.WriteLine("Current state: {0}", _state);
			}
		}

		/// <summary>
		/// Creates a new memento holding the current state.
		/// </summary>
		/// <returns>The memento holding the current state.</returns>
		public object CreateMemento()
		{
			Console.WriteLine("Recording state in memento");
			return (new Originator.Memento(_state));
		}

		/// <summary>
		/// Restore the state using the specified memento.
		/// </summary>
		/// <param name="memento">The memento instance holding the state to restore.</param>
		public void SetMemento(object memento)
		{
			Console.WriteLine("Restoring state from memento");
			State = (memento as Memento).State;
		}
	}
	
}
