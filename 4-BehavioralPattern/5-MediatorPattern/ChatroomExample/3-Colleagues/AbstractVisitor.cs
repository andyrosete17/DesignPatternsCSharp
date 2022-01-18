namespace ChatroomExample_3_Colleagues
{
    using System;
    using ChatroomExample_1_Mediator;

    /// <summary>
    /// The abstract visitor class (the colleague).
    /// </summary>
    public abstract class AbstractVisitor
    {
        // the current chatroom that the visitor is in (the mediator)
        protected AbstractChatroom _currentChatroom = null;

        // the name of the visitor
        protected string _name = null;

        /// <summary>
        /// Send the specified message.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} --> {1}", _name, message);
            _currentChatroom.Send(message, this);
        }

        /// <summary>
        /// Receive a new message.
        /// </summary>
        /// <param name="message">The received message.</param>
        public abstract void Receive(string message);

        /// <summary>
        /// Enter the chatroom.
        /// </summary>
        /// <param name="chatroom">The chatroom to enter.</param>
        public void Enter(AbstractChatroom chatroom)
        {
            // leave the current chatroom
            if (_currentChatroom != null)
            {
                Leave();
            }

            // join the specified chatroom
            chatroom.Register(this);
            _currentChatroom = chatroom;
        }

        /// <summary>
        /// Leave the current chatroom.
        /// </summary>
        public void Leave()
        {
            if (_currentChatroom != null)
            {
                _currentChatroom.Unregister(this);
                _currentChatroom = null;
            }
        }
    }
}