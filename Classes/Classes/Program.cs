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

            /*Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + r.Area().ToString("F2"));
            Console.WriteLine("perimetro = " + r.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2"));*/

            //------------------------------------------
            // EXERCICIO 2

            /*Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.Salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(f.ToString());

            Console.Write("Digite a porcentagem para aumentar salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine(f.ToString());*/


            //------------------------------------------
            // EXERCICIO 3

            /*Aluno aluno1 = new Aluno();

            Console.Write("Nome: ");
            aluno1.Name = Console.ReadLine();

            Console.Write("Digite as três notas do aluno: ");
            aluno1.Score1 = double.Parse(Console.ReadLine());
            aluno1.Score2 = double.Parse(Console.ReadLine());
            aluno1.Score3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL = {aluno1.FinalScore():F2}");
            if (aluno1.IsApproved())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno1.HowMuchBelowPassMark():F2} PONTOS");
            }*/


            //------------------------------------------
            // EXERCICIO 3

            Console.Write("Qual é a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares vocês vai comprar? ");
            double dolares = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Converter(cotacao, dolares).ToString("F2"));
        }
    }
}
