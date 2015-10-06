using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FLServerMaintenanceTool
{
    class FLHookConnection
    {
        Socket socket;

        public FLHookConnection()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect()
        {
            //Create connection to FLHook and send password
            IPAddress ipAdd = IPAddress.Parse(Properties.Settings.Default.ServerAddress);
            IPEndPoint remoteEP = new IPEndPoint(ipAdd, Properties.Settings.Default.ServerPort);
            socket.Connect(remoteEP);
            SendCommand("pass" + Properties.Settings.Default.ServerPassword);
        }

        public void SendUniverseMessage(String message)
        {
            SendCommand("msgu " + message);
        }

        public void SendCommand(String command)
        {
            socket.Send(GetBytes(command));
        }

        public void Disconnect()
        {
            socket.Disconnect(false);
        }

        private byte[] GetBytes(String data)
        {
            //convert data string to byte array and add linebreaks
            byte[] byData = Encoding.ASCII.GetBytes(data + "\r\n");
            return byData;
        }
    }
}
