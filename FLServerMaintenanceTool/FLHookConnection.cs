using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FLServerMaintenanceTool
{
    class FLHookConnection
    {
        readonly Socket socket;

        public FLHookConnection()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect()
        {
            //Create connection to FLHook and send password
            IPAddress ipAdd = IPAddress.Parse(Common.IniFile.IniReadValue("server", "address"));
            IPEndPoint remoteEP = new IPEndPoint(ipAdd, int.Parse(Common.IniFile.IniReadValue("server", "port")));
            socket.Connect(remoteEP);
            SendCommand("pass" + Common.IniFile.IniReadValue("server", "password"));
        }

        public void SendUniverseMessage(String message)
        {
#if !DEBUG
            SendCommand("msgu " + message);
#endif
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
