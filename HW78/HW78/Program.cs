using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW78
{
    class Program
    {
        static void Main(string[] args)
        {
            question89();
        }
       
        public static void question71()
        {
            double v = 1.7 * Math.Pow(10, 4);
            double q = 1.6 * Math.Pow(10, -19);
            double u0 = 4 * Math.PI * Math.Pow(10, -7);
            double m = 1.67 * Math.Pow(10, -27);
            double g = 9.8;
            double I = 1.4 * Math.Pow(10, -6);
            double result = (u0 * I / (2 * Math.PI * m * g)) * q * v;
            result = result * 100;
            Console.WriteLine(result);
            Console.Read();
        }
     
        public static void question72()
        {
            double u0 = 4 * Math.PI * Math.Pow(10, -7);
            double N = 890;
            double I = 18 * Math.Pow(10, 3);
            double inr = 0.7;
            double our = 1.3;
            double B0 = (u0 * N * I) / (2 * Math.PI * inr);
            Console.WriteLine(B0);
            double B1 = (u0 * N * I) / (2 * Math.PI * our);
            Console.WriteLine(B1);
            Console.Read();
        }

        
        public static void question74()
        {
            double I2 = 0.25;
            double I1 = 15.0;
            double L = 2.0 * Math.Pow(10, -2);
            double u0 = 4.0 * Math.PI * Math.Pow(10, -7);
            double B = u0 * 3000.0 * I1;
            double F = B * I2 * L * 1;
            Console.WriteLine(F);
            Console.Read();
        }
        public static void question75()
        {
            double i = 0.850;
            double u0 = 4 * Math.PI * Math.Pow(10, -7);
            double r = 0.12;
            double A = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(A);
            double e0 = 8.85 * Math.Pow(10,-12);
            double part1 = i / (e0 * A);
            Console.WriteLine(part1);
            double r2 = 0.05;
            double B = (u0 * i * r2) / (2 * Math.PI * Math.Pow(r, 2));
            Console.WriteLine(B);
            Console.Read();


        }
       
        public static void question76()
        {
            double u0 = 4.0 * Math.PI * Math.Pow(10, -7);
            double L = 1.4;
            double h = 0.01;
            double w = 0.2;
            double b = 10;
            double e = ((u0 * L) / (2 * Math.PI)) * Math.Log((h + w) / h) * b;
            Console.WriteLine(e);
            Console.Read();
        }
      
        public static void question77()
        {
            double N = 18.0;
            double u0 = 4.0 * Math.PI * Math.Pow(10, -7);
            double n = 1000.0;
            double A = Math.PI * Math.Pow(0.02, 2);
            double constant = 416;
            double step = N * u0 * n * A * constant;
            Console.WriteLine(step);
            Console.Read();
        }
     
        public static void question78()
        {
            double R = 9.0;
            double F = 1.0;
            double v = 1.0;
            double test = (F * v) / R;
            
            double I = Math.Sqrt((F * v) / R);
            Console.WriteLine(I);
            double P = Math.Pow(I, 2.0) * R;
            Console.WriteLine(P);
            Console.WriteLine(Math.Pow(I, 2.0));
            Console.Read();
        }
       
        public static void question710()
        {
            double q = 1.6 * Math.Pow(10, -19);
            double R = 0.025;
            double r = 0.05;
            double F = ((q * Math.Pow(R,2)) / (2.0 * r)) * (27.0 * Math.Pow(2.0, 2) - 4.0 * 2.0);
            Console.WriteLine(F);
            Console.Read();
        }
       
        public static void question86()
        {
            double L = 2 * Math.Pow(10, -3);
            double R = 3.0;
            double C = L / R;
            Console.WriteLine(C);
            double second = 2.0 * (1.0-Math.Pow(Math.E,-0.25*1.5));
            Console.WriteLine(second);



            Console.Read();
        }
        public static void question88()
        {
            double L = 0.640;
            double e = 600.0;
            double R = 30.0;
            double U = L * Math.Pow(e, 2) / (8 * Math.Pow(R, 2));
            Console.WriteLine(U);
            Console.Read();
        }
     
        public static void question89()
        {
            double R = 6.1 * Math.Pow(10, 6);
            double B = 5.1 * Math.Pow(10, -5);
            double u0 = 4.0 * Math.PI * Math.Pow(10, -7);
            double result = (2 * Math.PI * Math.Pow(R, 3) * Math.Pow(B, 2)) / u0;
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
