using System;
using System.Net;

namespace LemonChatServer
{
    public class User
    {
        private string username;
        private IPEndPoint clientIpEndpoint;

        public User(string name, IPEndPoint clientIpEndpoint)
        {
            this.username = name;
            this.clientIpEndpoint = clientIpEndpoint;
        }

        public string GetName()
        {
            return username;
        }

        public IPEndPoint GetIPEndPoint()
        {
            return clientIpEndpoint;
        }
    }
}