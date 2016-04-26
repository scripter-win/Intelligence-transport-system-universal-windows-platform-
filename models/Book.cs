using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace xBindDataExample.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "鲜活鱼类", Author = "常温区（12ºC~32ºC）", CoverImage = "Assets/11.jpg" });
            books.Add(new Book { BookId = 2, Title = "鲜活贝类", Author = "常温区（12ºC~32ºC）", CoverImage = "Assets/12.jpg" });
            books.Add(new Book { BookId = 3, Title = "根茎类", Author = "常温区（12ºC~32ºC）", CoverImage = "Assets/13.jpg" });
            books.Add(new Book { BookId = 4, Title = "热带水果类", Author = "常温区（12ºC~32ºC）", CoverImage = "Assets/14.jpg" });
            books.Add(new Book { BookId = 5, Title = "冰鲜鱼类", Author = "冷藏区（0ºC~12ºC）", CoverImage = "Assets/15.jpg" });
            books.Add(new Book { BookId = 6, Title = "叶菜类", Author = "冷藏区（0ºC~12ºC）", CoverImage = "Assets/16.jpg" });
            books.Add(new Book { BookId = 7, Title = "水果类", Author = "冷藏区（0ºC~12ºC）", CoverImage = "Assets/uisdsdditangd<>17.jpg" });
            books.Add(new Book { BookId = 8, Title = "鲜肉类", Author = "冷藏区（0ºC~12ºC）", CoverImage = "Assets/18.jpg" });
            books.Add(new Book { BookId = 9, Title = "冰鲜贝类", Author = "冷藏区（0ºC~12ºC）", CoverImage = "Assets/19.jpg" });
            books.Add(new Book { BookId = 10, Title = "豆类", Author = "冷藏区（0ºC~12ºC）", CoverImage = "Assets/20.jpg" });
            books.Add(new Book { BookId = 11, Title = "瓜类", Author = "冷藏区（0ºC~12ºC）", CoverImage = "Assets/21.jpg" });
            books.Add(new Book { BookId = 12, Title = "冷冻贝类", Author = "冷冻区（0ºC以下）", CoverImage = "Assets/22.jpg" });
            books.Add(new Book { BookId = 13, Title = "冷冻鱼类", Author = "冷冻区（0ºC以下）", CoverImage = "Assets/23.jpg" });
            books.Add(new Book { BookId = 14, Title = "冷冻肉类", Author = "冷冻区（0ºC以下）", CoverImage = "Assets/24.jpg" });
            return books;
        }
    }

    public class info
    {
        public int id;
        public string situation;
        public string nameID;
        public string image;
    }
}
