using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Remote_Co_Editor
{
    /// <summary>
    /// Interaction logic for CheckStatusWindow.xaml
    /// </summary>
    public partial class CheckStatusWindow : Window
    {
        public CheckStatusWindow()
        {
            InitializeComponent();
        }

        public void UserInfoReloader()
        {
            WP.Children.Clear();
            ServerInfo.Text = "";
            ServerInfo.Inlines.Add(new Run("IP: " + GlobalVars.ServerAddreass.Item1));
            ServerInfo.Inlines.Add(new LineBreak());
            ServerInfo.Inlines.Add(new Run("Port: " + GlobalVars.ServerAddreass.Item2));
            foreach (var addreass in GlobalVars.UserList)
            {
                TextBlock ClientInfo = new TextBlock();
                ClientInfo.Inlines.Add(new Run("IP: " + addreass.Item1));
                ClientInfo.Inlines.Add(new LineBreak());
                ClientInfo.Inlines.Add(new Run("Port: " + addreass.Item2));
                ClientInfo.Width = 190;
                ClientInfo.Height = 34;
                WP.Children.Add(ClientInfo);
            }
        }
        public void Reload(object sender, RoutedEventArgs e)
        {
            //GlobalVars.testCheckStatus();
            
            UserInfoReloader();
        }
    }
}
