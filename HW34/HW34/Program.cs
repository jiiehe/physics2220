using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW34
{
    class Program
    {
        static void Main(string[] args)
        {
            question310();
        }
        public static void question31()
        {
            double Ex = -8 + 18 * 8 * 0;
            Console.WriteLine(Ex);
            double Ey = 9 * Math.Pow(8, 2) - 2 * Math.Pow(-4, 2);
            Console.WriteLine(Ey);
            double Ez = -4 * 0 * -4;
            Console.WriteLine(Ez);
            double E = Math.Sqrt(Math.Pow(Ex,2)+Math.Pow(Ey,2)+Math.Pow(Ez,2));
            Console.WriteLine(E);
            Console.Read();
        }
        public static void question34()
        {
            double k = 8.99 * Math.Pow(10, 9);
            double R1 = 0.600 / 2;
            double R2 = (double)1 /(double) 2;
            double qplusq = 9 * Math.Pow(10, -6);
            double rplusr = 0.8;
            double Q1Q1 = 1 + R2 / R1;
            Console.WriteLine(R2);
            double Q1 = 9 / Q1Q1;
            double Q2 = 9 - Q1;
            Console.WriteLine(Q1);
            Console.WriteLine(Q2);
            //the answer can get the answer with unit V, divide by 1000 to get kv. 
            double v = (k * qplusq) /rplusr;
            Console.WriteLine(v);
            Console.Read();
        }
        public static void question35()
        {
            double e0 = 8.85 * Math.Pow(10, -12);
            double V = 24;
            double d = 2.2 * Math.Pow(10, -3);
            double E = V / d;
            Console.WriteLine(E);
            double A = 7.6 * Math.Pow(10, -4);
            double C = e0 * A / d;

            Console.WriteLine(C);
            double Q = C * V;
            Console.WriteLine(Q);
            double density = Q/A;
            Console.WriteLine(density);
            Console.Read();
        }
        public static void question36()
        {
            double L = 46;
            double a = 2.58 * Math.Pow(10, -3);
            double b = 7.27 * Math.Pow(10, -3);
            double Q = -8.1 * Math.Pow(10, -6);
            double k = 8.99 * Math.Pow(10, 9);
            double C = L / (2 * k * Math.Log(b / a));
            Console.WriteLine(C);
            double V = -Q / C;
            Console.WriteLine(V);
            Console.Read();
        }
        public static void question310()
        {
            double C1 = 3;
            double C2 = 13;
            double C3 = 5;
            double CA = C1 * C2 / (C1 + C2);
            double CB = CA + C3 + CA;
            double CC = C2 + C2;
            double Ceq = CB * CC / (CB + CC);
            Console.WriteLine(Ceq);
            Console.Read();

        }
    }
}
