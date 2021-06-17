
namespace Classes
{
    class ConversorDeMoeda
    {
        static public double iof = 0.06;

        static public double Converter(double cotacao, double valor)
        {
            return (valor * cotacao) * (1 + iof);
        }
    }
}
