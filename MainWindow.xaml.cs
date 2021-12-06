using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GemBox.Document;
using Microsoft.Win32;

namespace Remote_Co_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>\

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // If using Professional version, put your serial key below.
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }
        private void rtb_TextChanged(object sender, EventArgs e)
        {
            if (GlobalVars.isConnect)
            {
                // to-do, pass some parameters
                GlobalVars.Packet = tb.Text;
                GlobalVars.toSend = true;
            }
        }
        private void CreateHost(object sender, System.EventArgs e)
        {
            CreateHostWindow subWindow = new CreateHostWindow();
            subWindow.Show();
        }
        private void ConnectHost(object sender, System.EventArgs e)
        {
            ConnectHostWindow subWindow = new ConnectHostWindow();
            subWindow.Show();
        }
        private void CheckStatus(object sender, System.EventArgs e)
        {
            CheckStatusWindow subWindow = new CheckStatusWindow();
            subWindow.Show();
            //GlobalVars.testCheckStatus();
            subWindow.UserInfoReloader();
        }

        private void Disconnection(object sender, System.EventArgs e)
        {
            // if I am server, Ishould send message to clients
            if (GlobalVars.isServer)
            {
                //todo
            }
            GlobalVars.isConnect = false;
            GlobalVars.isClient = false;
            GlobalVars.isServer = false;
            GlobalVars.UserList = new List<Tuple<string, string>>();
            GlobalVars.ServerAddreass = new(item1: null, item2: null);
            GlobalVars.clientsSocketList = new List<System.Net.Sockets.Socket>();
        }

    }
}
