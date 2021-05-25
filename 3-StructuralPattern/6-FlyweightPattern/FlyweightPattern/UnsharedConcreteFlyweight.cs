using System;
using System.Collections;

namespace FlyweightPattern
{

	/// <summary>
	/// The concrete implementation of an unshared flyweight instance. 
	/// </summary>
	class UnsharedConcreteFlyweight : Flyweight
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FlyweightPattern.UnsharedConcreteFlyweight"/> class.
		/// </summary>
		/// <param name="intrinsicState">The intrinsic state.</param>
		public UnsharedConcreteFlyweight(int intrinsicState)
		{
			_intrinsicState = intrinsicState;
		}

		/// <summary>
		/// Perform an operation on the flyweight object.
		/// </summary>
		/// <param name="extrinsicState">The extrinsic state to use in the operation.</param>
		public override void Operation(ExtrinsicState extrinsicState)
		{
			Console.WriteLine("Unshared Concrete Flyweight: (intrinsic: {0} extrinsic: {1})", _intrinsicState, extrinsicState);
		}
	}
	
}
