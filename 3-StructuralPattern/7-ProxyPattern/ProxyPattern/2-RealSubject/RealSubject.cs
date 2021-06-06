namespace ProxyPattern_2_RealSubject
{
    using System;
    using ProxyPattern_1_Subject;

    /// <summary>
    /// The real subject class. This is the object being proxied.
    /// </summary>
    internal class RealSubject : Subject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyPattern.RealSubject"/> class.
        /// </summary>
        public RealSubject()
        {
            Console.WriteLine("RealSubject.ctor()");
        }

        /// <summary>
        /// Make a request.
        /// </summary>
        public void Request()
        {
            Console.WriteLine("RealSubject.Request()");
        }
    }
}