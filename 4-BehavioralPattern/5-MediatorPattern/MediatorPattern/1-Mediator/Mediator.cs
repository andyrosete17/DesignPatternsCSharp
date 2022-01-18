namespace MediatorPattern_1_Mediator
{
    using MediatorPattern_3_Colleague;

    /// <summary>
    /// The abstract mediator class.
    /// </summary>
    public abstract class Mediator
    {
        /// <summary>
        /// Send the specified message.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="sender">The colleague sending the message.</param>
        public abstract void Send(string message, Colleague sender);
    }
}