using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEventhandler
{
    public delegate void CustomEventhandler(object source, CustomEventArgs e);
    class Item
    {
        public event CustomEventhandler priceChangedHandler;
        public string name { get; set; }
        int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price != value)
                {
                    price = value;
                    onPriceChanged(price);
                }
            }
        }

        private void onPriceChanged(int price)
        {
            CustomEventhandler handler = priceChangedHandler;
            if(handler!=null)
            {
                handler(this, new CustomEventArgs(price));
            }
            //Console.WriteLine("The price now is "+price);
        }
    }
}
