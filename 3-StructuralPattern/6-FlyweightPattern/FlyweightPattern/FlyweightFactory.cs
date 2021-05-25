using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
	/// <summary>
	/// The flyweight factory class.
	/// </summary>
	class FlyweightFactory
	{
		// a dictionary of cached flyweight instances
		// note that the intrinsic state is an int - change this to whatever you need
		private Dictionary<int, Flyweight> flyweights = new Dictionary<int, Flyweight> ();

		/// <summary>
		/// Get a new flyweight instance corresponding to the given intrinsic state.
		/// </summary>
		/// <returns>The requested flyweight instance.</returns>
		/// <param name="state">The intrinsic state corresponding to the requested flyweight instance.</param>
		public Flyweight GetFlyweight(int intrinsicState)
		{
			Flyweight flyweight = null;

			// check for unshared flyweight
			// note that a zero state creates an unshared instance - change this to whatever you need
			if (intrinsicState == 0)
			{
				flyweight = new UnsharedConcreteFlyweight (intrinsicState);
			} else
			{
				// check for cached shared flyweights
				if (flyweights.ContainsKey (intrinsicState))
				{
					flyweight = flyweights [intrinsicState] as Flyweight;
				} else
				{
					// create new flyweight and add it to the cache
					flyweight = new ConcreteFlyweight (intrinsicState);
					flyweights.Add (intrinsicState, flyweight);
				}
			}
			return flyweight;
		}
	}
	
}
