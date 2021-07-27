namespace CommandPattern._1_Command
{
    using CommandPattern._3_Receiver;

    /// <summary>
    /// The abstract Command class
    /// </summary>
    public abstract class Command
    {
        // a reference to the command receiver
        protected Receiver receiver;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandPattern.Command"/> class.
        /// </summary>
        /// <param name="receiver">The receiver class to use.</param>
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        /// <summary>
        /// Execute the command.
        /// </summary>
        public abstract void Execute();
    }
}