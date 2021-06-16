using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Triangulo x, y;
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

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área X = " + areaX);
            Console.WriteLine("Área Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("Triângulo maior é o X");
            }
            else
            {
                Console.WriteLine("Triângulo maior é o Y");
            }*/

            //------------------------------------------
            // EXERCICIO 1

            /*Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("pessoa mais velha: " + pessoa2.Nome);
            }*/

            //-------------------------------------------------------------------
            // EXERCICIO 2

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double salarioMedio = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2"));
        }
    }
}
