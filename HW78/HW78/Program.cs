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
            question710();
        }
        /// <summary>
        /// https://www.chegg.com/homework-help/questions-and-answers/long-straight-wire-lies-horizontal-table-carries-current-185-q2945774
        /// </summary>
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
        /// <summary>
        /// https://www.chegg.com/homework-help/questions-and-answers/magnetic-coils-tokamak-fusion-reactor-shape-ofa-toroid-inner-radius-0700-m-outer-radius-of-q205336
        /// </summary>
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

        //for question3, http://www.lehman.edu/faculty/anchordoqui/169-P8-sol.pdf

        /// <summary>
        /// https://www.chegg.com/homework-help/questions-and-answers/single-turn-square-loop-wire-200-cm-edge-carries-clockwise-current-0150--loop-inside-solen-q1781253
        /// </summary>
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
        /// <summary>
        /// https://www.chegg.com/homework-help/questions-and-answers/loop-wire-shape-rectangle-width-w-andlength-l-long-straight-wire-carrying-currenti-lie-tab-q289961
        /// </summary>
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
        /// <summary>
        /// https://www.chegg.com/homework-help/questions-and-answers/coil-15-turns-radius-100-cm-surrounds-long-solenoid-radius-210-cm-100-103-turns-meter-see--q3861391
        /// </summary>
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
        /// <summary>
        /// https://www.chegg.com/homework-help/questions-and-answers/conducting-rod-length-script-moves-two-horizontal-frictionless-rails-figure--constant-forc-q1196810
        /// </summary>
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
        /// <summary>
        /// https://www.chegg.com/homework-help/questions-and-answers/situation-described-figure-p3132-magnetic-fieldchanges-time-according-expression-b-300t3-3-q371825
        /// </summary>
        public static void question710()
        {
            double q = 1.6 * Math.Pow(10, -19);
            double R = 0.025;
            double r = 0.05;
            double F = ((q * Math.Pow(R,2)) / (2.0 * r)) * (27.0 * Math.Pow(2.0, 2) - 4.0 * 2.0);
            Console.WriteLine(F);
            Console.Read();
        }
    }
}
