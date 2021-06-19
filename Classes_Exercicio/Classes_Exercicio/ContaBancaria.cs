
namespace Classes_Exercicio
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                Saldo -= valor + 5.0;
            }
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Titular}, Saldo: $ {Saldo:f2}";
        }
    }
}
