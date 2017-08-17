using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    class Program
    {
        static void Main(string[] args)
        {
            EBBill.metreRent = 6;
            EBBill eb1 = new EBBill("Kaushik", "a1", 100);
            Console.WriteLine("For Kaushik the bill is "+eb1.calculateElectricityBill());
            EBBill eb2 = new EBBill("Ojasva", "a2", 80);
            Console.WriteLine("For Ojasva the bill is " + eb2.calculateElectricityBill());
            Console.ReadLine();
        }
    }
}
