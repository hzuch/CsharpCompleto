using System;

namespace Classes_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char comDeposito = char.Parse(Console.ReadLine());

            ContaBancaria conta;

            if (comDeposito == 's' || comDeposito == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: : ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numeroConta, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta.ToString());

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            conta.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta.ToString());

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            conta.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta.ToString());
        }
    }
}
