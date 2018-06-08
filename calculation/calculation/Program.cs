using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
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
            // question6();
            // question7();
            //question82();
            question28();
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
        public static void question7()
        {
            Console.WriteLine(Math.Sin(Math.PI*30/180));
            double g = 9.8;
            double m = 0.001;
            double tan = Math.Tan(Math.PI*14/180);
            double q = 4 * Math.Pow(10, -8);
            double k = 8.99 * Math.Pow(10, 9);
            double lsin4 = 4 * Math.Pow(0.1, 2) * Math.Pow(Math.Sin(Math.PI * 14 / 180), 2);
            double result = ((m * g * tan) / q) + ((k * q )/ lsin4);
            Console.WriteLine(result/1000);
            Console.Read();
        }
        public static void question8()
        {
            double E = 8.20 * Math.Pow(10, 4);
            double area = 0.03;
            double cos = Math.Cos(Math.PI * 180 / 180);
            double result = E * area * cos;
            Console.WriteLine(result);
            Console.Read();
        }
        public static void question82()
        {
            double E = 8.20 * Math.Pow(10, 4);
            double area = 0.06;
            double cos = Math.Cos(Math.PI * 60 / 180);
            double result = E * area * cos;
            Console.WriteLine(result);
            Console.Read();
        }
        //hw2 since here
        public static void question1()
        {
            double Q = 140 * Math.Pow(10, -6);
            double e6 = 6 * (8.85 * Math.Pow(10, -12));

            double result = Q / e6;
            Console.WriteLine(result);
           // Console.Read();
            double result2 = result * 6;
            Console.WriteLine(result2);
            Console.Read();
        }
        public static void question5()
        {
            Point A = new Point(-0.200, -0.300);
            Point B = new Point(0.400, 0.500);
            double distance = B.y-A.y;
            double result = distance * 310;
            Console.WriteLine(result);
            Console.Read();
        }
        public static void question26()
        {
            double q = 2.3 * Math.Pow(10, -6);
            double E = 300;
            double L = 1.5;
            double m = 0.01;
            double result = Math.Sqrt((q * E * L) / m);
            Console.WriteLine(result);
            Console.Read();
        }
        public static void question27()
        {
            double V = 3.40* Math.Pow(10, 3);
            double E = 520;
            double d = V / E;
            Console.WriteLine(d);
            double k = 8.99 * Math.Pow(10, 9);
           //in this part, V should be a negative number, this is a super confuse part. 
            double q = (V * d) / k;
            Console.WriteLine(q);
            Console.Read();
        }
        public static void question28()
        {
            double k = 8.99 * Math.Pow(10, 9);
            double q1 = 50*Math.Pow(10,-9);
            double q2 = -50*Math.Pow(10,-9);
            double q3 = 25*Math.Pow(10,-9);
            double r1 = 0.24;
            double r2 = 0.12;
            double r3 = 0.12;
            double PE = (k * q1 * q2) / r1 +( k * q1 * q3) / r2 + (k * q2 * q3) / r3;
            Console.WriteLine(PE);

            Console.Read();

        }
    }
    class Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
 
 

   
    


}
