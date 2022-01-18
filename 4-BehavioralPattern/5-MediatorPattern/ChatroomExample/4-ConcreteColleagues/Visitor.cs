namespace ChatroomExample_4_ConcreteColleagues
{
    using System;
    using ChatroomExample_3_Colleagues;

    /// <summary>
    /// The visitor class (the concrete colleague).
    /// </summary>
    public class Visitor : AbstractVisitor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediatorPattern.Visitor"/> class.
        /// </summary>
        /// <param name="name">The name of the visitor.</param>
        public Visitor(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// Receive a new message.
        /// </summary>
        /// <param name="message">The received message.</param>
        public override void Receive(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} <-- {1}", _name, message);
        }
    }
}