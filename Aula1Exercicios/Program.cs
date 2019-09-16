using System;

namespace Aula1Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {   
        int valor;    
        int triplo;

        Console.WriteLine("Digite um numero");
        valor = int.Parse(Console.ReadLine() );

        triplo = valor*3;
        Console.WriteLine("valor multiplicado por 3 =   " + triplo);


        }
    }
}
