namespace StockHistoryInterfaceExample._4_Client
{
    using System;
    using System.Data;
    using StockHistoryInterfaceExample_1_Target;
    using StockHistoryInterfaceExample_2_Adapter;

    /// <summary>
    /// The client class that uses the adapter to access the adaptee.
    /// </summary>
    public class StockApp
    {
        /// <summary>
        /// Shows the price history for the given stock.
        /// </summary>
        /// <param name="ticker">The ticker symbol of the stock to show history for.</param>
        public void ShowStockHistory(string ticker)
        {
            // get a stock history adapter instance
            StockHistoryTarget adapter = new StockHistoryAdapter();

            // get the stock history
            DataTable history = adapter.GetStockPrices(ticker);

            // show the stock history on the console
            foreach (DataRow row in history.Rows)
            {
                DateTime dt = (DateTime)row[0];
                decimal price = (decimal)row[1];
                Console.WriteLine("On {0:MMM d yyyy} {1} was ${2:0.00}", dt, ticker, price);
            }
        }
    }
}