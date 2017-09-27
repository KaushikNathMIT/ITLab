using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortandRev
{
    public static class StringEx
    {
        public static String Reverse(this String s)
        {
            return new String(s.ToCharArray().Reverse().ToArray());
        }
        
        public static bool IsNum(this char c)
        {
            return System.Char.IsDigit(c);
        }
        
    }
}
