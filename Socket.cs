using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using Microsoft.Win32;
using Newtonsoft.Json;
namespace Remote_Co_Editor
{
    static class ExtensionFunctions
    {
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
    public class GlobalVars
    {
        public static bool isConnect = false;
        public static bool isServer = false;
        public static bool isClient = false;
        public static bool toSend = false;
        public static string Packet = "";
        public static Tuple<string, string> ServerAddreass = new(item1: null, item2: null);
        public static List<Tuple<string, string>> UserList = new List<Tuple<string, string>>();
        public static List<Socket> clientsSocketList = new List<Socket>();
        // create socket
        //public static Socket CurSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public static void testCheckStatus()
        {
            ServerAddreass = new(item1: "111", item2: "22");
        }
    }
}
