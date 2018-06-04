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
            //twopikqcalculation();
            question6();
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
        public static void twopikqcalculation()
        {
            double k = 8.99 * Math.Pow(10, 9);
            double twopi = 2 * 3.14;
            double q = 7.5 * Math.Pow(10, -6);
            double Lpower2 = Math.Pow(15 * Math.Pow(10, -2),2);
            double result = (twopi * k * q) / Lpower2;
            Console.WriteLine(result);
            Console.Read();
        }
        public static void question6()
        {
            double vpower2 = Math.Pow(17.3, 2);
            double s2 = 3.5*2;
            double a = (vpower2 - 0) / s2;
            Console.WriteLine(a);
            double m = 1*Math.Pow(10, -3);
            double g = 9.8;
            double e = 1 * Math.Pow(10, 4);
            double result = (m * a - m * g) / e;
            Console.WriteLine(result);
            Console.Read();
        }


    }
 

   
    


}
