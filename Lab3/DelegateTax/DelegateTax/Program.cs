using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTax
{
    public delegate decimal TaxCalculator(decimal d);
    class Program
    {

        static void Main(string[] args)
        {
            TaxCalculator taxCalculator;
            taxCalculator = taxIndia;
            decimal tax = taxCalculator(100);
            Console.WriteLine("Tax for india is" + tax);
            taxCalculator = taxUS;
            tax = taxCalculator(100);
            Console.WriteLine("Tax for india is" + tax);
            Console.ReadLine();
        }

        private static decimal taxUS(decimal d)
        {
            return 0.1m * d;
        }

        private static decimal taxIndia(decimal d)
        {
            return 0.15m * d;
        }
    }
}
