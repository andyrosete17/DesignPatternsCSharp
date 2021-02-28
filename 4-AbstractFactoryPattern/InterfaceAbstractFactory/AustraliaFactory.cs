using System;

namespace FoodchainExample
{
	/// <summary>
	/// The concrete factory class for Australia.
	/// </summary>
	class AustraliaFactory : IContinentFactory
	{
		public IHerbivore CreateHerbivore()
		{
			return new Kangaroo();
		}
		public ICarnivore CreateCarnivore()
		{
			return new Dingo();
		}
	}
}
