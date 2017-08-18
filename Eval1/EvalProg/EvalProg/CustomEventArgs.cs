using System;

namespace EvalProg
{
    public class CustomEventArgs : EventArgs
    {
        private int age;
        public CustomEventArgs(int age)
        {
            this.age = age;
        }
        public int getOldAge()
        {
            return age;
        }
    }
}