using System.Net;

namespace Puncher.Server
{
    internal class Client
    {
        public IPEndPoint EndPoint { get; set; }
        public bool IsConnector { get; set; }
        public bool IsListener { get; set; }
        public DateTime LastRegisterTime { get; set; }
    }
}