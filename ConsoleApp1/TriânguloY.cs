using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TriânguloY
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public TriânguloY(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }



        public void area()
        {
            double p = (A + B + C) / 2;
            Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
