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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace Analysis_System
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MapPage1 : Page
    {
        public MapPage1()
        {
            this.InitializeComponent();
        }

        private void select_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            col();
            switch (com.SelectedIndex)
            {
                case 1: web2.Visibility = Visibility.Visible; break;
                case 2: web3.Visibility = Visibility.Visible; break;
                case 3: web4.Visibility = Visibility.Visible; break;
                case 4: web5.Visibility = Visibility.Visible; break;
                case 5: web6.Visibility = Visibility.Visible; break;
                case 6: web7.Visibility = Visibility.Visible; break;
                case 7: web8.Visibility = Visibility.Visible; break;
                case 0: web1.Visibility = Visibility.Visible; break;
                default:break;
            }
        }
        private void col()
        {
            web1.Visibility = Visibility.Collapsed;
            web2.Visibility = Visibility.Collapsed;
            web3.Visibility = Visibility.Collapsed;
            web4.Visibility = Visibility.Collapsed;
            web5.Visibility = Visibility.Collapsed;
            web6.Visibility = Visibility.Collapsed;
            web7.Visibility = Visibility.Collapsed;
            web8.Visibility = Visibility.Collapsed;
        }
    }
}
