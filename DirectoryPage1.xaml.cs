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
    public sealed partial class DirectoryPage1 : Page
    {
        public DirectoryPage1()
        {
            this.InitializeComponent();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PaneOutButton.IsSelected && splitview.IsPaneOpen)
            {
                PaneOutButton.IsSelected = false;
                splitview.IsPaneOpen = false;
                if (DirectorPage.Margin == refer1.Margin)
                    DirectorPage.Margin = refer2.Margin;
                return;
            }
            else if (serach.IsSelected)
            {
                DirectorPage.Navigate(typeof(SerachPage1));
                splitview.IsPaneOpen = true; DirectorPage.Margin = refer1.Margin;
                logo.Visibility = Visibility.Visible;
            }
            else if (data.IsSelected)
            {
                DirectorPage.Navigate(typeof(DataPage1));
                splitview.IsPaneOpen = true; DirectorPage.Margin = refer1.Margin;
            }
            else if (map.IsSelected)
            {
                DirectorPage.Navigate(typeof(MapPage1));
                splitview.IsPaneOpen = true; DirectorPage.Margin = refer1.Margin;
                logo.Visibility = Visibility.Visible;

            }
            else if (albert.IsSelected)
            {
                DirectorPage.Navigate(typeof(AlbertPage1));
                splitview.IsPaneOpen = true; DirectorPage.Margin = refer1.Margin;
                logo.Visibility = Visibility.Visible;

            }
            else if (observe.IsSelected)
            {
                DirectorPage.Navigate(typeof(ObservePage));
                splitview.IsPaneOpen = true; DirectorPage.Margin = refer1.Margin;
                logo.Visibility = Visibility.Visible;
            }
            else if (copyright.IsSelected)
            {
                DirectorPage.Navigate(typeof(CopyrightPage));
                splitview.IsPaneOpen = true; DirectorPage.Margin = refer1.Margin;
                logo.Visibility = Visibility.Collapsed;
            }
        }
        private void splitview_PaneClosed(SplitView sender, object args)
        {
            DirectorPage.Margin = refer1.Margin;
        }

        private void ListBox_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
