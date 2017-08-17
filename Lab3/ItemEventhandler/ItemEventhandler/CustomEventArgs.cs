using System;

namespace ItemEventhandler
{
    public class CustomEventArgs : EventArgs
    {
        private int newPrice;
        public CustomEventArgs(int newPrice)
        {
            this.newPrice = newPrice;
        }
        public int getnewPrice()
        {
            return newPrice;
        }
    }
}