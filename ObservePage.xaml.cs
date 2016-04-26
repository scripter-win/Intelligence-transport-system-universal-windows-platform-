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
using Windows.UI.Xaml.Media.Imaging;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace Analysis_System
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ObservePage : Page
    {
        public ObservePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {

        }

        private void serach_GotFocus(object sender, RoutedEventArgs e)
        {
            if (serach.Text == "serach")
                serach.Text = "";
        }

        private void serach_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {

        }

        void clear()
        {
            image1.Visibility = Visibility.Collapsed;
            image2.Visibility = Visibility.Collapsed;
            image3.Visibility = Visibility.Collapsed;
            image4.Visibility = Visibility.Collapsed;
            image5.Visibility = Visibility.Collapsed;
            image6.Visibility = Visibility.Collapsed;
            image7.Visibility = Visibility.Collapsed;
            image8.Visibility = Visibility.Collapsed;
        }

        private void listbox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listbox1.SelectedIndex = -1;
            switch (listbox2.SelectedIndex)
            {
                case 0: clear(); image5.Visibility = Visibility.Visible; info.Text = "运输 ：西安->北京";   info2.Text = "运单综合质量安全信息 ->"; break;
                case 1: clear(); image6.Visibility = Visibility.Visible; info.Text = "运输 ：郑州->南京";   info2.Text = "运单综合质量安全信息 ->"; break;
                case 2: clear(); image7.Visibility = Visibility.Visible; info.Text = "运输 ：哈尔滨->北京"; info2.Text = "运单综合质量安全信息 ->"; break;
                case 3: clear(); image8.Visibility = Visibility.Visible; info.Text = "运输 ：西安->石家庄"; info2.Text = "运单综合质量安全信息 ->"; break;
                default: break;
            }
    }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listbox2.SelectedIndex = -1;
            switch (listbox1.SelectedIndex)
            {
                case 0: clear(); image1.Visibility = Visibility.Visible; info.Text = "运输 ：南宁->桂林"; info2.Text = "运单综合质量安全信息 ->"; break;
                case 1: clear(); image2.Visibility = Visibility.Visible; info.Text = "运输 ：长沙->深圳"; info2.Text = "运单综合质量安全信息 ->"; break;
                case 2: clear(); image3.Visibility = Visibility.Visible; info.Text = "运输 ：西安->北京"; info2.Text = "运单综合质量安全信息 ->"; break;
                case 3: clear(); image4.Visibility = Visibility.Visible; info.Text = "运输 ：西安->北京"; info2.Text = "运单综合质量安全信息 ->"; break;
                default: break;
            }
        }   
    }
}
