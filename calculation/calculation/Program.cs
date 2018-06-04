using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1
            kq1q2rcalculation();
        }
        public static void kq1q2rcalculation()
        {
            double k = 8.99 * Math.Pow(10, 9);
            double r = Math.Pow(0.300, 2);
            double q1 = 12 * Math.Pow(10, -9);
            double q2 = 13 * Math.Pow(10, -9);
            double result = (k * q1 * q2) / r;
            double q = (q1 + q2) / 2;
            double result2 = (k * Math.Pow(q, 2)) / r;
            Console.WriteLine(result2);
            Console.Read();
        }
    }

   
    


}
