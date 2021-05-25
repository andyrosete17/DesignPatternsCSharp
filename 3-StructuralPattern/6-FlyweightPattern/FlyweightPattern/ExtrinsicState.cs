using System;

namespace FlyweightPattern
{
	/// <summary>
	/// The extrinsic state of a flyweight instance.
	/// </summary>
	public class ExtrinsicState
	{
		// the extrinsic state
		// note that the extrinsic state is a string - change this to whatever you need
		private string _state = null;

		/// <summary>
		/// Initializes a new instance of the <see cref="FlyweightPattern.ExtrinsicState"/> class.
		/// </summary>
		/// <param name="state">State.</param>
		public ExtrinsicState (string state)
		{
			_state = state;
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="FlyweightPattern.ExtrinsicState"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="FlyweightPattern.ExtrinsicState"/>.</returns>
		public override string ToString ()
		{
			return _state;
		}
	}
}

