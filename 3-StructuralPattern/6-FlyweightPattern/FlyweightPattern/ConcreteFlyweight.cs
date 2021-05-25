using System;
using System.Collections;

namespace FlyweightPattern
{
	/// <summary>
	/// The concrete implementation of a shared flyweight instance. 
	/// </summary>
	class ConcreteFlyweight : Flyweight
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FlyweightPattern.ConcreteFlyweight"/> class.
		/// </summary>
		/// <param name="intrinsicState">The intrinsic state.</param>
		public ConcreteFlyweight(int intrinsicState)
		{
			_intrinsicState = intrinsicState;
		}

		/// <summary>
		/// Perform an operation on the flyweight object.
		/// </summary>
		/// <param name="extrinsicState">The extrinsic state to use in the operation.</param>
		public override void Operation(ExtrinsicState extrinsicState)
		{
			Console.WriteLine("Concrete Flyweight: (intrinsic: {0} extrinsic: {1})", _intrinsicState, extrinsicState);
		}
	}
	
}
