using System;

namespace FlyweightPattern
{
	/// <summary>
	/// The client class.
	/// </summary>
	public class Client
	{
		/// <summary>
		/// Perform a client operation.
		/// </summary>
		public void Operation()
		{
			// instantiate a flyweight factory
			var factory = new FlyweightFactory ();

			// add shared flyweights
			var fw1 = factory.GetFlyweight (1);
			var fw2 = factory.GetFlyweight (1);

			// add unshared flyweights (state zero creates unshared fw's)
			var fw3 = factory.GetFlyweight (0);
			var fw4 = factory.GetFlyweight (0);

			// perform operations on shared flyweights
			fw1.Operation (new ExtrinsicState ("A"));
			fw2.Operation (new ExtrinsicState ("B"));

			// check if we got the same instance
			Console.WriteLine ("Did we get one shared instance: {0}", fw1 == fw2);

			// perform operations on unshared flyweights
			fw3.Operation (new ExtrinsicState ("C"));
			fw4.Operation (new ExtrinsicState ("D"));

			// check if we got different instances
			Console.WriteLine ("Did we get unshared instances: {0}", fw3 != fw4);
		}
	}
}

