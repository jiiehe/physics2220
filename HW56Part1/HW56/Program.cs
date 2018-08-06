using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW56
{
    class Program
    {
        static void Main(string[] args)
        {
            question58();
        }
        
        public static void question52()
        {

            double IdivedeI0 = 1.0 / (1.0 / 9.0);
            double alpha = 0.00430;
            double alphaT = IdivedeI0 - 1.0;
            double T = alphaT / alpha;
            Console.WriteLine(alphaT);
            double result = T + 20.0;
            Console.WriteLine(result);
            Console.Read();
        }
        
        public static void question55()
        {
            double E = 12.6;
            double r = 0.0560;
            double R = 7.4;
            double I = E / (R + r);
            double V = I * R;
            Console.WriteLine(V);
            double I0 = (E - (35 * r) )/ (R + r);
            double result = I0 * R;
            Console.WriteLine(result);
            Console.Read();

        }
       
        public static void question56()
        {
            double R1 = 2.0;
            double R2 = 3.0;
            double R3 = 1.0;
            double R4 = 4.0;
            double V = 9.0;
            double R23 = R2 * R3 / (R2 + R3);
            double Req = R1 + R23 + R4;
            double I = V / Req;
            double P = Math.Pow(I, 2) * R1;
            Console.WriteLine(P);
            double P1 = Math.Pow(I, 2) * R4;
            Console.WriteLine(P1);
            double V23 = I * R23;
            double I2 = V23 / R2;
            double P2 = Math.Pow(I2, 2) * R2;
            Console.WriteLine(P2);
            double I3 = V23 / R3;
            double P3 = Math.Pow(I3, 2) * R3;
            Console.WriteLine(P3);
            Console.Read();
            
        }
     
        public static void question57()
        {
            double c1 = 562;
            double c2 = 125.9;
            double R2 = (-(-c1) + Math.Sqrt(Math.Pow(-c1, 2) - 4 * 1 * (c1 * c2))) / 2*(1);
            double R21 = (-(-c1) - Math.Sqrt(Math.Pow(-c1, 2) - 4 * 1 * (c1 * c2))) / 2 * (1);
            Console.WriteLine(R2);
            Console.WriteLine(R21);
            Console.Read();
        }
     
        public static void question59()
        {
            double R = 105;
            double C = 50;
            double T = (R + C) * Math.Pow(10, 3) * 10 * Math.Pow(10, -6);
            Console.WriteLine(T);
            double T1 = R * Math.Pow(10, 3) * 10 * Math.Pow(10, -6);
            Console.WriteLine(T1);
            double Q = 10 * Math.Pow(10, -6) * 10;
            double I1 = 10 / C;
            
            Console.Read();
        }
        public static void question58()
        {
            double e2 = 60.0;
            double I2 = 3.076;
            double R2 = 3000;
            double result = -e2 - (I2*Math.Pow(10,-3)) * R2;
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
