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
            GetResponse();//Make sure the response buffer is clear after connection and validation
        }

        public void SendUniverseMessage(String message)
        {
            #if !DEBUG
            this.SendCommand(string.Format("msgu {0}", message));
            #endif
        }

        public string SendCommand(String command)
        {
            this.socket.Send(this.GetBytes(command));
            return GetResponse();
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

        public bool PlayersOnline()
        {
            string response = SendCommand("getplayerids");
            if (response == "OK\r\n")
                return false;
            else
                return true;
        }

        private string GetResponse()
        {
            byte[] buffer = new byte[1024];
            int iRx = this.socket.Receive(buffer);
            char[] chars = new char[iRx];

            System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
            d.GetChars(buffer,0,iRx,chars,0);
            return new string(chars);
        }
    }
}