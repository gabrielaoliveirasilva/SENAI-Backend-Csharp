using System;

namespace Aula4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for(int cont = 0; cont <10; cont++){
                Console.WriteLine("Digite um valor");
                vetor[cont] = int.Parse(Console.ReadLine() );
            }

        }
    }
}