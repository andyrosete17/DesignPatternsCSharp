namespace ProxyPattern_4_Client
{
    using ProxyPattern_3_Proxy;

    /// <summary>
    /// The client class.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Execute the client.
        /// </summary>
        public void Execute()
        {
            // use proxy to make a request
            Proxy proxy = new Proxy();
            proxy.Request();
        }
    }
}