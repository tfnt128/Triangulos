using System;

namespace ConsoleApp1
{
    class Triângulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

      
        public Triângulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }


        public double area()
        {
            double p = (A + B + C) / 2;
          return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
