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
            // question310();
            question49();
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
        public static void question41()
        {
            double C1 = 4.9;
            double C2 = 11.7;
            double C3 = 2.05;
            double C11 = 1 / (1 / C1 + 1 / C2);
            Console.WriteLine(C11);
            double C111 = 1 / (1 / C1 + 1 / C2);
            Console.WriteLine(C111);
            double Cp = C111 + C11 + C3;
            Console.WriteLine(Cp);
            double Cp1 = C2 + C2;
            double Vp1 = (Cp1 / (Cp + Cp1)) * 52;
            Console.WriteLine(Vp1);
            double Q3 = C3 * Vp1;
            Console.WriteLine(Q3);
            Console.Read();
        }
        public static void question42()
        {
            double q1 = 2.5 * Math.Pow(10, -9);
            double q2 = -2.5 * Math.Pow(10, -9);
            Point A = new Point(-1.2, 1.3);
            Point B = new Point(1.3, -1.3);
            double px = -q1 * ((B.x - A.x)*Math.Pow(10,-3));
            double py = -q1 * ((B.y - A.y)*Math.Pow(10,-3));
            Console.WriteLine(px);
            Console.WriteLine(py);
           // Console.Read();
            //31.85
            double psolute = Math.Sqrt(Math.Pow(6.25, 2) + Math.Pow(6.5, 2)) * Math.Pow(10, -12);
            double esolute = Math.Sqrt(Math.Pow(7.8, 2) + Math.Pow(4.9, 2)) * Math.Pow(10, 3);
            double UMM = Math.Abs(psolute) * Math.Abs(esolute);
            double Umm = psolute * esolute;
            double result = UMM +Umm;
            Console.WriteLine(result);
            Console.Read();
        }
        public static void question44()
        {
            //part1 automatically get it.
            double e0 = 8.85 * Math.Pow(10, -12);
            double A = 1 * Math.Pow(10, -4);
            double k1 = 4.9;
            double k2 = 5.6;
            double k3 = 2.6;
            double d = 2 * Math.Pow(10, -3);
            double C = (e0 * A / d) * (k1 / 2 + (k2 * k3 / (k2 + k3)));
            Console.WriteLine(C);
            Console.Read();

        }
        public static void question46()
        {
            double t = 1.04;
            double current = 12 * Math.Pow(t, 2)+5;
            Console.WriteLine(current);
            double A = 1.9 * Math.Pow(10, -4);
            double result = current / A;
            //this one can help us get A, need to manual divide 1000 to get KA.

            Console.WriteLine(result);
            Console.Read();

        }
        public static void question47()
        {
            double m = 2.7 * Math.Pow(10, -3);
            double d = 8.92 * Math.Pow(10, 3);
            double p = 1.7 * Math.Pow(10, -8);
            double r = 0.7;
            double la = m / d;
            double lda = r / p;
            double l2 = la * lda;
            double length = Math.Sqrt(l2);
            Console.WriteLine(length);
            double A = la / length;
            double radius = Math.Sqrt(A / Math.PI);
            double radius2 = radius * 2;
            Console.WriteLine(radius2);
            Console.Read();
        }
        public static void question48()
        {
            double m = 87.5;
            double d = 2.7;
            double l = Math.Pow(m / d, 1.0 / 3.0);
            Console.WriteLine(l);
            double al = 2.82 * Math.Pow(10, -8);
            double R = al / (l*Math.Pow(10,-2));
            Console.WriteLine(R);
            double P = 1.0 * Math.Pow(10, -5);
            double I = P / R;
            double NA = 6.02 * Math.Pow(10, 23);
            double c = 26.98;
            double trans = 1.0 * Math.Pow(10, -6);
            double n = (NA / c) * (d / trans);
            double q = 1.6 * Math.Pow(10, -19);
            double v = I / (n * q * Math.Pow(l * Math.Pow(10, -2), 2));
            Console.WriteLine(v);
            Console.Read();
        }
        public static void question49()
        {
            double coefficient = 0.0037;

            double p0 = 1.59 * Math.Pow(10, -8);
            double ps0 = 2.44 * Math.Pow(10, -8);
            double next = 3.0 * p0/ps0;
            double next1 = next - 1.0;
            double rho = next1 / coefficient;
            double result = 20.0 + rho;
            Console.WriteLine(result);
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
