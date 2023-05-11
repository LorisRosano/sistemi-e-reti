using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _01_SocketUDP_Server.Classi
{
    public class ClsAddress
    {
        public static List<IPAddress> ipList = new List<IPAddress>();

        public ClsAddress() { }

        public static void cercaIP()
        {
            IPHostEntry hostInfo; //prepara e filtra gli ip letti
            //ipList.Add(IPAddress.Parse("127.0.0.1"));
            ipList.Add(IPAddress.Loopback);
            
            hostInfo = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in hostInfo.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipList.Add(ip);
                }
            }
        }
    }
}
