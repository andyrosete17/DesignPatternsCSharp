namespace ChatroomExample_2_ConcreteMediator
{
    using ChatroomExample_1_Mediator;
    using ChatroomExample_3_Colleagues;

    /// <summary>
    /// The chatroom class (the concrete mediator).
    /// </summary>
    public class Chatroom : AbstractChatroom
    {
        /// <summary>
        /// Register the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor to register.</param>
        public override void Register(AbstractVisitor visitor)
        {
            _activeVisitors.Add(visitor);
        }

        /// <summary>
        /// Unregister the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor to unregister.</param>
        public override void Unregister(AbstractVisitor visitor)
        {
            _activeVisitors.Remove(visitor);
        }

        /// <summary>
        /// Send the specified message.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="sender">The sender of the message.</param>
        public override void Send(string message, AbstractVisitor sender)
        {
            foreach (var visitor in _activeVisitors)
                if (visitor != sender)
                    visitor.Receive(message);
        }
    }
}