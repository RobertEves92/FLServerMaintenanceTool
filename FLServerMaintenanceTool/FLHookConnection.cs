using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FLServerMaintenanceTool
{
    internal class FLHookConnection
    {
        private readonly Socket socket;

        public FLHookConnection()
        {
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect()
        {
            //Create connection to FLHook and send password
            IPAddress ipAdd = IPAddress.Parse(Common.IniFile.IniReadValue("server", "address"));
            var remoteEP = new IPEndPoint(ipAdd, int.Parse(Common.IniFile.IniReadValue("server", "port")));
            this.socket.Connect(remoteEP);
            this.SendCommand(string.Format("pass{0}", Common.IniFile.IniReadValue("server", "password")));
        }

        public void SendUniverseMessage(String message)
        {
            #if !DEBUG
            SendCommand("msgu " + message);
            #endif
        }

        public void SendCommand(String command)
        {
            this.socket.Send(this.GetBytes(command));
        }

        public void Disconnect()
        {
            this.socket.Disconnect(false);
        }

        private byte[] GetBytes(String data)
        {
            //convert data string to byte array and add linebreaks
            byte[] byData = Encoding.ASCII.GetBytes(string.Format("{0}\r\n", data));
            return byData;
        }
    }
}