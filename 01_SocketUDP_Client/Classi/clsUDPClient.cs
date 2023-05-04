using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _01_SocketUDP.Classi
{
    public class clsUDPClient
    {
        private Socket socketID; //Identificativo client (indirizzo ip e porta su cui uscirà il messaggio)
        private EndPoint endPointServer; //Variabile che identifica il server di destinazione

        public clsUDPClient(IPAddress ipServer, int portServer)
        {
            socketID = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //AddressFamily individua la tipologia di indirizzi sulla quale è messo il socket.
            endPointServer = new IPEndPoint(ipServer, portServer);
        }

        public void invia(ClsMessage clsMsg)
        {
            string messaggio = clsMsg.toCSV(';');

            byte[] bufferTx; //Informazione trasmessa
            bufferTx = Encoding.ASCII.GetBytes(messaggio);

            socketID.SendTo(bufferTx, bufferTx.Length, SocketFlags.None, endPointServer);
        }
    }
}
