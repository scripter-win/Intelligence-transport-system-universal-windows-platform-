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


    public sealed partial class SerachPage1 : Page
    {
        public SerachPage1()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {

        }

        private void serachbox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (true)
            {
                serachbox.Text = "";
            }
        }

        private void serachbox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (serachbox.Text == "")
                return;
            string v = serachbox.Text;
            try
            {
                int k = int.Parse(v);
                    ;
            }
            catch
            {
                ;
            }

        }
        OpticalMarginAlignment mar = new OpticalMarginAlignment();
        private void serachbutton_Click(object sender, RoutedEventArgs e)
        {
            serach.VerticalAlignment = VerticalAlignment.Top;
            serachbutton.Margin = refer.Margin;
            serachbox.VerticalAlignment = VerticalAlignment.Top;
            serachbox.HorizontalAlignment = HorizontalAlignment.Center;
            serachbox.Margin = refer.Margin;
            serachframe.Visibility = Visibility.Visible;
            if (serachbox.Text == "342234")
                serachframe.Navigate(typeof(SerachPageResult), 1.ToString());
            else serachframe.Navigate(typeof(SerachPage1), 2.ToString());
            serachbutton.VerticalAlignment = VerticalAlignment.Top;
            serach.Visibility = Visibility.Collapsed;
        }

        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            serach.Visibility = Visibility.Visible;
            try
            {
                serachframe.GoBack();

            }
            catch
            {
                serachframe.Visibility = Visibility.Collapsed;
            }
        }
    }
}
