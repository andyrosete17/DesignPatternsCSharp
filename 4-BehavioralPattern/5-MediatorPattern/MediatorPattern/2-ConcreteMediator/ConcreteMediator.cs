namespace MediatorPattern_2_ConcreteMediator
{
    using MediatorPattern_1_Mediator;
    using MediatorPattern_3_Colleague;
    using MediatorPattern_4_ConcreteColleague;

    /// <summary>
    /// The concrete mediator class.
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        // references to all concrete colleagues
        private ConcreteColleague1 _colleague1;

        private ConcreteColleague2 _colleague2;

        /// <summary>
        /// Sets the first colleague.
        /// </summary>
        /// <value>The colleague to set.</value>
        public ConcreteColleague1 Colleague1
        {
            set { _colleague1 = value; }
        }

        /// <summary>
        /// Sets the second colleague.
        /// </summary>
        /// <value>The colleague to set.</value>
        public ConcreteColleague2 Colleague2
        {
            set { _colleague2 = value; }
        }

        /// <summary>
        /// Send the specified message.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="sender">The colleague sending the message.</param>
        public override void Send(string message, Colleague sender)
        {
            if (sender == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else
            {
                _colleague1.Notify(message);
            }
        }
    }
}