using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortandRev
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }

        private static void printArray(int[] arr)
        {
            foreach(int a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}
