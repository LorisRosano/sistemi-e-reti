using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SocketUDP.Classi
{
    
    public class ClsMessage
    {
        private string ip, port, message;

        public string Ip { get => ip; set => ip = value; }
        public string Port { get => port; set => port = value; }
        public string Message { get => message; set => message = value; }

        public ClsMessage(string _ip = "", string _port = "", string _msg = "")
        {
            this.ip = _ip;
            this.port = _port;
            this.message = _msg;
        }

        public ClsMessage(string csv, char separatore = ';')
        {
            this.ip = csv.Split(separatore)[0];
            this.port = csv.Split(separatore)[1];
            this.message = csv.Split(separatore)[2];
        }

        public string toCSV(char separatore = ';')
        {
            return ip + separatore + port + separatore + message;
        }

        public string[] toArray()
        {
            return new string[] { ip, port, message };
        }
    }
}
