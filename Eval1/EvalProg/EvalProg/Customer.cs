using System;

namespace EvalProg
{
    public delegate void CustomEventhandler(object source, CustomEventArgs e);
    class Customer
    {
        public event CustomEventhandler invalidAgeHandler;
        static string age;
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                if (Convert.ToInt32(value) < 0 || Convert.ToInt32(value) > 200)
                {
                    onInValidAge();
                }
                else age = value;
            }
        }

        private void onInValidAge()
        {
            CustomEventhandler handler = invalidAgeHandler;
            if (handler != null)
            {
                handler(this, new CustomEventArgs(Convert.ToInt32(age)));
            }

        }
    }
}