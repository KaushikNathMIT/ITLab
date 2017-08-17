using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEventhandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.priceChangedHandler += new CustomEventhandler(onChangedPrice);
            item.Price = 10;
            item.Price = 20;
            item.Price = 20;
            item.Price = 30;
            Console.ReadLine();
        }

        private static void onChangedPrice(object source, CustomEventArgs e)
        {
            Console.WriteLine("The new price is " + e.getnewPrice());
        }
    }
}
