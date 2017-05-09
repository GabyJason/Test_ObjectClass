using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //取出類別(Book) 定義物件名稱(HerryPotter) 再new 該 Class使用
            Book HerryPotter = new Book();
            //該書籍定義的頁數
            HerryPotter.Page = 320;
            //該書籍定義的使用方法
            HerryPotter.Buy(199);
        }
    }
    public class Book

    {
        //定義書籍頁數
        public int Page;

        //定義書籍價格方法
        public void Buy(int x)
        {
            Console.WriteLine("購買這本書花費{0}元", x);
        }
    }
}
