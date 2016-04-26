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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using xBindDataExample.Models;
// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace Analysis_System
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class DataPage1 : Page
    {
        private List<Book> Books;
        private info[] Infos;
        private string img= "0.jpg";
        


        public DataPage1()
        {
            this.InitializeComponent();
            Books = BookManager.GetBooks();
            Infos= new info[100];
            Infos[0] = new info { situation = "30天内总运输单数：3782  运输表现良好      物品合格率总分布：", nameID = "鲜活鱼类  常温区（12ºC~32ºC）", image = "11.PNG", id = 1 };
            Infos[1] = new info { situation = "30天内总运输单数：1882  运输表现良好      物品合格率总分布：", nameID = "鲜活贝类  常温区（12ºC~32ºC）", image = "12.PNG", id = 2 };
            Infos[2] = new info { situation = "30天内总运输单数：3112  运输表现良好      物品合格率总分布：", nameID = "根茎类    常温区（12ºC~32ºC）", image = "13.PNG", id = 3 };
            Infos[3] = new info { situation = "30天内总运输单数：1322  运输表现良好      物品合格率总分布：", nameID = "热带水果类    常温区（12ºC~32ºC）", image = "14.PNG", id = 4 };
            Infos[4] = new info { situation = "30天内总运输单数：4542  运输表现良好      物品合格率总分布：", nameID = "冰鲜鱼类  冷藏区（0ºC~12ºC）", image = "15.PNG", id = 5 };
            Infos[5] = new info { situation = "30天内总运输单数：2462  运输表现良好      物品合格率总分布：", nameID = "叶菜类    冷藏区（0ºC~12ºC）", image = "16.PNG", id = 6 };
            Infos[6] = new info { situation = "30天内总运输单数：4542  运输表现良好      物品合格率总分布：", nameID = "水果类    冷藏区（0ºC~12ºC）", image = "17.PNG", id = 7 };
            Infos[7] = new info { situation = "30天内总运输单数：7122  运输表现良好      物品合格率总分布：", nameID = "鲜肉类    冷藏区（0ºC~12ºC）", image = "24.PNG", id = 8 };
            Infos[8] = new info { situation = "30天内总运输单数：3342  运输表现良好      物品合格率总分布：", nameID = "冰鲜贝类   冷藏区（0ºC~12ºC）",image = "", id = 9 };
            Infos[9] = new info { situation = "30天内总运输单数：5221  运输表现良好      物品合格率总分布：", nameID = "豆类      冷藏区（0ºC~12ºC）", image = "23.PNG", id = 10 };
            Infos[10] =new info { situation = "30天内总运输单数：5111  运输表现良好      物品合格率总分布：", nameID = "瓜类      冷藏区（0ºC~12ºC）", image = "21.PNG", id = 11 };
            Infos[11] =new info { situation = "30天内总运输单数：1965  运输表现良好      物品合格率总分布：", nameID = "冷冻贝类   冷冻区（0ºC以下）", image = "20.PNG", id = 12 };
            Infos[12] =new info { situation = "30天内总运输单数：5023  运输表现良好      物品合格率总分布：", nameID = "冷冻鱼类   冷冻区（0ºC以下）", image = "19.PNG", id = 13 };
            Infos[13] =new info { situation = "30天内总运输单数：7433  运输表现良好      物品合格率总分布：", nameID = "冷冻肉类   冷冻区（0ºC以下）", image = "18.PNG", id = 14 };
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = (Book)e.ClickedItem;
            int c = book.BookId - 1;
            ResultTextBlock.Text = Infos[c].situation;
            Result2.Text = Infos[c].nameID;
            if (image.Visibility != Visibility.Visible)
            {
                image.Visibility = Visibility.Visible;
                image1.Visibility = Visibility.Collapsed;
            }
            else
            {
                image.Visibility = Visibility.Collapsed;
                image1.Visibility = Visibility.Visible;
            }
        }
    }

    /*
    public static class gets
    {
        public static List<info> infon()
        {
            var infos = new List<info>();
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "鲜活鱼类  常温区（12ºC~32ºC）", image = "", id = 1 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "鲜活贝类  常温区（12ºC~32ºC）", image = "", id = 2 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "根茎类    常温区（12ºC~32ºC）", image = "", id = 3 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "热带水果类    常温区（12ºC~32ºC）", image = "", id = 4 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "冰鲜鱼类  冷藏区（0ºC~12ºC）", image = "", id = 5 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "叶菜类    冷藏区（0ºC~12ºC）", image = "", id = 6 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "水果类    冷藏区（0ºC~12ºC）", image = "", id = 7 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "鲜肉类    冷藏区（0ºC~12ºC）", image = "", id = 8 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "冰鲜贝类   冷藏区（0ºC~12ºC）", image = "", id = 9 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "豆类      冷藏区（0ºC~12ºC）", image = "", id = 10 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "瓜类      冷藏区（0ºC~12ºC）", image = "", id = 11 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "冷冻贝类   冷冻区（0ºC以下）", image = "", id = 12 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "冷冻鱼类   冷冻区（0ºC以下）", image = "", id = 13 });
            infos.Add(new info { situation = "30天内总运输单数：1002  运输表现良好      物品合格率总分布：", nameID = "冷冻肉类   冷冻区（0ºC以下）", image = "", id = 14 });
            return infos;
        }
    }*/
}