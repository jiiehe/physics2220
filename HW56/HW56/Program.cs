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
            question66();
        }

        public static void question63()
        {
            double g = 9.8;
            double r0 = 0.0400;
            double B = 3.10;
            double I = r0 * g / B;
            Console.WriteLine(I);
            Console.Read();
        }

      
        public static void question64()
        {
            double m = 0.1;
            double g = 9.8;
            double L = 4.00;
            double a = 0.1;
            double I = 3.0;
            double B = 0.0200;
            double N = L / (4.0 * a);
            double A = Math.Atan(B*I*L/2*m * g);
            double final =180/(Math.PI/A);

            double temp=Math.Cos(Math.PI / (180 / 6.86));
            Console.WriteLine(temp);
            Console.WriteLine(final);
            double final1 = (0.25) * I * L * B * a * temp;
            Console.WriteLine(final1);
            Console.Read();
        }
        
        public static void question65()
        {
            double m = 3.2 * Math.Pow(10, -26);
            double deltaV = 828.0;
            double B = 0.820;
           
            double q = 1.6 * Math.Pow(10, -19);
            double v = Math.Sqrt(2 * deltaV* q / m);
            Console.WriteLine(v);
            double r = m * v / (q * B);
            Console.WriteLine(r);
            Console.Read();
        }
        
        public static void question66()
        {
            double r = 0.650;
            double deltaV = 600;
            double B = 0.480;
            double mp = 1.67 * Math.Pow(10, -27);
            double q = 1.6 * Math.Pow(10, -19);
            double w = q * B /(mp);
            Console.WriteLine(w);
            double v = B * q * r / mp;
            Console.WriteLine(v);
            double third = (1.0 / 2.0) * mp * Math.Pow(v, 2);
            double temp = third / q;
            //need wolframalpha to get final answer using the third value.
            Console.WriteLine(third);
            double fourth = (1.0 / 2.0) * ((third) / (q * deltaV));
            Console.WriteLine(fourth);
            double final = fourth * (2.0 * Math.PI / w);
            Console.WriteLine(final);
            Console.Read();
        }
    }
}
