namespace Classes
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public void AumentarSalario(double aumento)
        {
            Salario += (Salario * (aumento / 100));
        }

        public override string ToString()
        {
            return $"Funcionário: {Nome}, $ {(Salario-Imposto):F2}";
        }
    }
}
