using System;
using System.Collections;

namespace FlyweightPattern
{
	/// <summary>
	/// The flyweight abstract class.
	/// </summary>
	abstract class Flyweight
	{
		// the intrinsic state of the flyweight instance
		// note that the intrinsic state is an int - change this to whatever you need
		protected int _intrinsicState;

		/// <summary>
		/// Perform an operation on the flyweight object.
		/// </summary>
		/// <param name="extrinsicState">The extrinsic state to use in the operation.</param>
		public abstract void Operation(ExtrinsicState extrinsicState);
	}
	
}
