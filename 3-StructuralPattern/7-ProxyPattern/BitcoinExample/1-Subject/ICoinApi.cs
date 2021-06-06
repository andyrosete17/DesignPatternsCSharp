namespace BitcoinExample_1_Subject
{
    /// <summary>
    /// The abstract subject base class.
    /// </summary>
    public  interface ICoinApi
    {
        /// <summary>
        /// Get the value of one coin in USD.
        /// </summary>
        double GetValueInUSD();
    }
}