using System;

namespace FoodchainExample
{
	/// <summary>
	/// The concrete factory class for Africa.
	/// </summary>
	class AfricaFactory : IContinentFactory
	{
		public IHerbivore CreateHerbivore()
		{
			return new Zebra();
		}
		public ICarnivore CreateCarnivore()
		{
			return new Lion();
		}
	}
}
