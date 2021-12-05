using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace Remote_Co_Editor
{
    public class GlobalVars
    {
        public static bool isConnect = false;
        public static bool isServer = false;
        public static bool isClient = false;
        public static Tuple<string, string> ServerAddreass = new(item1: null, item2: null);
        public static List<Tuple<string, string>> UserList = new List<Tuple<string, string>>();

        // create socket
        public static Socket CurSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public static void Send()
        {
            if(isConnect && isServer)
            {
                // send to server
            }
            else if(isConnect && isClient)
            {
                // send to clients
            }
        }

        public static void Receive()
        {
            if (isConnect && isServer)
            {
                // change RTB
            }
            else if (isConnect && isClient)
            {
                // change RTB and send to clients
            }
        }

        public static void testCheckStatus()
        {
            ServerAddreass = new(item1: "111.111.111.111", item2: "8888");
            UserList = new List<Tuple<string,string>>();    
            UserList.Add(new(item1: "211.111.111.111", item2: "8888"));
            UserList.Add(new(item1: "311.111.111.111", item2: "8888"));
        }
        
    }
}
