using System;

namespace Exercícios10
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor, Porsentagem;

            System.Console.WriteLine("Digite o valor da sua conta");
            Valor = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a porsentagem de desconto");
            Porsentagem = double.Parse(Console.ReadLine());

            System.Console.WriteLine(Valoraplicado(Valor, Porsentagem));

        }
        static double Valoraplicado(double Valor, double Porsentagem){
           double Desconto = (Valor*Porsentagem) /100;
            Valor = Valor-Desconto;

            return Valor;
        }
    }
}
