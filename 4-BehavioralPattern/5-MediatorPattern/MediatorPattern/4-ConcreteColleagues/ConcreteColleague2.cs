namespace MediatorPattern_4_ConcreteColleague
{
    using System;
    using MediatorPattern_1_Mediator;
    using MediatorPattern_3_Colleague;

    /// <summary>
    /// A concrete colleague class.
    /// </summary>
    public class ConcreteColleague2 : Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediatorPattern.ConcreteColleague2"/> class.
        /// </summary>
        /// <param name="mediator">The mediator to use.</param>
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        {
        }

        /// <summary>
        /// Send the specified message.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public void Send(string message)
        {
            Console.WriteLine("Colleague2 sending: {0}", message);
            mediator.Send(message, this);
        }

        /// <summary>
        /// Notify the arrival of the specified message.
        /// </summary>
        /// <param name="message">The message that arrived.</param>
        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 notified: {0}", message);
        }
    }
}