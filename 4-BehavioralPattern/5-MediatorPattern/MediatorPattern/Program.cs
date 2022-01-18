using System;
using MediatorPattern_2_ConcreteMediator;
using MediatorPattern_4_ConcreteColleague;

namespace MediatorPattern
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// instantiate a new mediator
			var mediator = new ConcreteMediator();

			// instantiate two colleagues
			var colleague1 = new ConcreteColleague1(mediator);
			var colleague2 = new ConcreteColleague2(mediator);

			// add colleagues to mediator
			mediator.Colleague1 = colleague1;
			mediator.Colleague2 = colleague2;

			// colleague one sends greeting
			colleague1.Send("How are you?");

			// colleague two sends reply
			colleague2.Send("Fine, thanks");
		}
	}





}
