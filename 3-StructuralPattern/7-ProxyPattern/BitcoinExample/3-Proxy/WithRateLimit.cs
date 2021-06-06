namespace BitcoinExample_3_Proxy
{
    using System;
    using BitcoinExample_1_Subject;

    /// <summary>
    /// The proxy class.
    /// </summary>
    internal class WithRateLimit : ICoinApi
    {
        // the reference to the real subject
        private ICoinApi _realSubject;

        // the date and time when the web service was last called
        private DateTime lastCalled = DateTime.MinValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="BitcoinExample.WithRateLimit"/> class.
        /// </summary>
        /// <param name="realSubject">Real subject.</param>
        public WithRateLimit(ICoinApi realSubject)
        {
            _realSubject = realSubject;
        }

        /// <summary>
        /// Get the value of one coin in USD.
        /// </summary>
        /// <returns>The value in US.</returns>
        public double GetValueInUSD()
        {
            // throw exception if too soon
            if (DateTime.Now - lastCalled < TimeSpan.FromSeconds(1))
            {
                throw new InvalidOperationException("Rate limit exceeded");
            }
            else
            {
                var value = _realSubject.GetValueInUSD();
                lastCalled = DateTime.Now;
                return value;
            }
        }
    }
}