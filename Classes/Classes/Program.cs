using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);*/

            //------------------------------------------
            // EXERCICIO 1

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + r.Area().ToString("F2"));
            Console.WriteLine("perimetro = " + r.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2"));
        }
    }
}
