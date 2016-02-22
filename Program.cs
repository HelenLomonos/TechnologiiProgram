using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lab1._2
{
    class Program
    {
        static double f1(double x, double y, double z)
        {
            return 1.0+4.0*x-4.0*z-2.0*y;
        }
        static double f2(double x, double y, double z)
        {
            return (3.0/2.0)*x*x - y + z;
        }

        static double Ym(double x)
        {
            return Math.Exp(2 * x) -  Math.Exp(-3 * x)+x*x+x;
        }

        static double Zm(double x)
        {
            return -Math.Exp(2 * x) - Math.Exp(-3 * x)/4.0 - x * x  / 2;
        }


        static void Main(string[] args)
        {
            double y0 = 0.0;
            double z0 = 5.0 / 4.0;
            double h1 = 0.1;
            double h2 = 0.2;
            StreamWriter writer = new StreamWriter("result.txt");
            for (double x = 0; x < 1.0; x += h1)
            {
                y0 = y0 + h1 * f1(x, y0, z0);
                z0 = z0 + h1 * f2(x, y0, z0);
                writer.Write(y0 + " " + z0 + " " + Ym(x) + " " + Zm(x));
                writer.WriteLine();
            }
            writer.Close();
        }
    }
}
