namespace BitcoinExample
{
    using BitcoinExample_4_Client;

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
            // execute bad client
            var client = new BadClient();
            client.Execute();
        }
    }
}