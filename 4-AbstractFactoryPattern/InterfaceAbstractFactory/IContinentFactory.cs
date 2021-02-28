using System;

namespace FoodchainExample
{
	/// <summary>
	/// The abstract factory class.
	/// </summary>
	public interface IContinentFactory
	{
		 ICarnivore CreateCarnivore();
		 IHerbivore CreateHerbivore();
	}
}
