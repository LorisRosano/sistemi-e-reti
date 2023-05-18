﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UDP_Tris
{
    public delegate void datiRicevutiEventHandler(ClsMessage msg);
    public class ClsUDPServer
    {
        private const int MAX_BYTE = 1024;

        private Socket socketID;
        private EndPoint endPointServer;
        private EndPoint endPointClient;

        private Thread threadAscolto;
        private volatile bool threadRun = true; // Per gestire avvio/stop del thread

        public event datiRicevutiEventHandler datiRicevutiEvent;

        public ClsUDPServer(IPAddress ip, int port)
        {
            socketID = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            endPointServer = new IPEndPoint(ip, port);
            //Bind
            socketID.Bind(endPointServer);
        }
        public void avvia()
        {
            if(threadAscolto == null)
            {
                threadAscolto = new Thread(new ThreadStart(ricevi));
                threadAscolto.Start();
                while (!threadAscolto.IsAlive) ;
            }
        }
        private void ricevi()
        {
            int nBytesRicevuti;
            string msg;
            byte[] bufferRx;
            ClsMessage clsMsg;

            bufferRx = new byte[MAX_BYTE];
            endPointClient = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5555);

            while (threadRun)
            {
                try
                {
                    nBytesRicevuti = socketID.ReceiveFrom(bufferRx, MAX_BYTE, SocketFlags.None, ref endPointClient); //2 parametri: l'array di byte di destinazione + dove salvare le info del trasmittente
                    msg = Encoding.ASCII.GetString(bufferRx);
                    clsMsg = new ClsMessage(msg, ';');

                    clsMsg.Ip = (endPointClient as IPEndPoint).Address.ToString();
                    clsMsg.Port = (endPointClient as IPEndPoint).Port.ToString();

                    datiRicevutiEvent(clsMsg);
                }
                catch(SocketException ex)
                {
                }
            }
        }
        public void chiudi()
        {
            threadRun = false;
            socketID.Close();
        }
    }
}