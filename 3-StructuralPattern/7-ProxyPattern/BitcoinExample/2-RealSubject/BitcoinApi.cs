namespace BitcoinExample_2_RealSubject
{
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Json;
    using BitcoinExample_1_Subject;

    /// <summary>
    /// The real subject class. This is the object being proxied.
    /// </summary>
    internal class BitcoinApi : ICoinApi
    {
        /// <summary>
        /// Get the value of one bitcoin in USD.
        /// </summary>
        /// <returns>The value in US.</returns>
        public double GetValueInUSD()
        {
            // call web service to get bitcoin value
            var request = WebRequest.Create(@"https://api.coindesk.com/v1/bpi/currentprice.json");

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;

            BitcoinResponse json = null;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                var serializer = new DataContractJsonSerializer(typeof(BitcoinResponse));
                var obj = serializer.ReadObject(response.GetResponseStream());
                json = obj as BitcoinResponse;
            }

            // return value
            return (double)(json != null ? json.Bpi.USD.rate_float : double.NaN);
        }
    }

    /// <summary>
    /// The json response object of the bitcoin service.
    /// </summary>
    [DataContract]
    public class BitcoinResponse
    {
        [DataMember(Name = "bpi")]
        public Bpi Bpi { get; set; }
    }

    public class Bpi
    {
        public USD USD { get; set; }
    }

    /// <summary>
    /// The json USD response from Bpi
    /// </summary>
    public class USD
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }
}