using System.Data;

namespace StockHistoryExample
{
    /// <summary>
    /// The interface target class which defines the adapter interface.
    /// </summary>
    public interface IStockHistoryTarget
    {
        /// <summary>
        /// Gets the price history of the specified stock.
        /// </summary>
        /// <returns>A DataTable containing twelve months of price history for the given stock.</returns>
        /// <param name="ticker">The ticker symbol of the stock to get price history for.</param>
        DataTable GetStockPrices(string ticker);
    }
}