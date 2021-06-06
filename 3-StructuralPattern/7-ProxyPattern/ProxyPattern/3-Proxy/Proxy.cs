namespace ProxyPattern_3_Proxy
{
    using System;
    using ProxyPattern_1_Subject;
    using ProxyPattern_2_RealSubject;

    /// <summary>
    /// The proxy class.
    /// </summary>
    internal class Proxy : Subject
    {
        // the reference to the real subject
        private RealSubject _realSubject;

        /// <summary>
        /// Make a request.
        /// </summary>
        public void Request()
        {
            Console.WriteLine("Proxy.Request starting...");

            // this is a virtual proxy - we use lazy instantiation
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}