using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortandRev
{
    partial class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkPalindrome("a12d"));
            Console.WriteLine(checkPalindrome("1234"));
            Console.WriteLine(checkPalindrome("4334"));
            Console.WriteLine(checkPalindrome("434"));
            /*
            int[] arr;
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            arr = new int[size];
            Console.WriteLine("Enter the array");
            for(int i=0; i<size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("After sorting and reversing");
            printArray(arr);
            Console.ReadLine();
            */
            Console.ReadLine();
        }
        private static bool checkPalindrome(String s)
        {
            foreach (char c in s.ToCharArray()) if (!c.IsNum())
                {
                    Console.WriteLine("Not a number");
                    return false;
                }
            string s2 = s.Reverse();
            if (s2.Equals(s)) return true;
            return false;
        }
        private static void printArray(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}
