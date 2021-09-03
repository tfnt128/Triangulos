using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite as medidas do triângulo X:");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Triângulo tri = new Triângulo(a, b, c);


            Console.WriteLine("Digite as medidas do triângulo Y:");
            double w = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double q = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Triângulo triy = new Triângulo(w, q, e);


            Console.WriteLine("A área do triângulo X é: " + tri.area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do triângulo Y é: " + triy.area().ToString("F2", CultureInfo.InvariantCulture));


            if (tri.area() > triy.area())
            {
                Console.WriteLine("A maior área é: " + tri.area().ToString("F4", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("A maior área é " + triy.area().ToString("F4", CultureInfo.InvariantCulture));
            }


            
        }
    }
}
