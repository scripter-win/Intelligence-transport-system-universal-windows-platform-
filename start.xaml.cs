using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Networking.Sockets;
using Windows.Networking.Connectivity;
using System.Net.Sockets;
using System.Net;
using System.Resources;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace Analysis_System
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>

        public sealed partial class MainPage : Page
        {

        public MainPage()
        {
            this.InitializeComponent();
            /*
            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("111.114.56.68"), 10078);
            soc.Bind(ip);
            soc.Listen(100);
        */
        }
        
            private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
            {
                if (enterprise.Visibility == Visibility.Collapsed)
                {
                    enterprise.Visibility = Visibility.Visible;
                    enterprise_inputs.Visibility = Visibility.Visible;
                }
                else
                {
                    enterprise.Visibility = Visibility.Collapsed;
                    enterprise_inputs.Visibility = Visibility.Collapsed;
                }
            }

            private void load_Click(object sender, RoutedEventArgs e)
            {
                frame.Navigate(typeof(DirectoryPage1));
            }


            protected override void OnNavigatedTo(NavigationEventArgs e)
            {

            }

            string password = "";
            string input = "";
            int length = 0;

            private void enterprise_input_KeyUp(object sender, KeyRoutedEventArgs e)
            {
                enterprise_input.Text += "*";
            /*
                if (length == enterprise_input.Text.Length)
                    input = enterprise_input.Text;
                else if (length < enterprise_input.Text.Length)
                {
                    while (length < enterprise_input.Text.Length)
                    {
                        input += enterprise_input.Text[length];
                        length++;
                        password += "*";
                    }
                    enterprise_input.Text = password;
                }
                else
                {
                    length = enterprise_input.Text.Length;
                    while (length < enterprise_input.Text.Length)
                    {
                        length--;
                    }
                    password = "";
                    for (int i = length; i > 0; i--)
                        password += "*";
                    enterprise_input.Text = password;
                }
                */
            }
        }

}

