namespace ChatroomExampleInterface_1_Mediator
{
    using System.Collections.Generic;
    using ChatroomExampleInterface_3_Colleagues;

    /// <summary>
    /// The abstract chatroom class (the mediator).
    /// </summary>
    public abstract class AbstractChatroom
    {
        // the list of all current visitors
        protected List<AbstractVisitor> _activeVisitors = new List<AbstractVisitor>();

        /// <summary>
        /// Send the specified message.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="sender">The sender of the message.</param>
        public abstract void Send(string message, AbstractVisitor sender);

        /// <summary>
        /// Register the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor to register.</param>
        public abstract void Register(AbstractVisitor visitor);

        /// <summary>
        /// Unregister the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor to unregister.</param>
        public abstract void Unregister(AbstractVisitor visitor);
    }
}