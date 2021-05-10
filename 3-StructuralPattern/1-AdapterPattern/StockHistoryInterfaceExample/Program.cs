namespace StockHistoryInterfaceExample
{
    using StockHistoryInterfaceExample._4_Client;

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
            // get apple stock price history
            StockApp app = new StockApp();
            app.ShowStockHistory("AAPL");
        }
    }
}