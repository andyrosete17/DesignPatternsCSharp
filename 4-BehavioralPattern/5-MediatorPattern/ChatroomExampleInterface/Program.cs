namespace ChatroomExampleInterface
{
    using ChatroomExampleInterface_2_ConcreteMediator;
    using ChatroomExampleInterface_4_ConcreteColleagues;

    /// <summary>
    /// The main program class.
    /// </summary>
    internal class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // instantiate three visitors
            var tom = new Visitor("Tom");
            var dick = new Visitor("Dick");
            var harry = new Visitor("Harry");

            // have all three visitors join a chatroom
            var chatroom = new Chatroom();
            tom.Enter(chatroom);
            dick.Enter(chatroom);
            harry.Enter(chatroom);

            // tom sends a greeting
            tom.Send("Hello everyone");

            // dick sends a reply
            dick.Send("Welcome to the chatroom Tom");

            // harry sends a reply
            harry.Send("Hi Tom, nice to meet you");
        }
    }
}