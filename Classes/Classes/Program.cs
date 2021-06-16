using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área X = " + areaX.ToString("F4"));
            Console.WriteLine("Área Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("Triângulo maior é o X");
            }
            else
            {
                Console.WriteLine("Triângulo maior é o Y");
            }
        }
    }
}
