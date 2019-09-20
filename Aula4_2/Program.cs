using System;

namespace Aula4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[10];

            for (int cont = 0; cont < 9; cont++)
            {
                Console.Write("1Digite um valor");
                vetor1[cont] = int.Parse(Console.ReadLine());
            }


            for (int cont = 0; cont < 9; cont++)
            {
                Console.Write("2Digite um valor");
                vetor2[cont] = int.Parse(Console.ReadLine());
            }

            for (int cont = 0; cont < 9; cont++)
            {
                vetor3[cont] = vetor1[cont];
                Console.WriteLine(vetor3[cont]);

            }

            for (int cont = 0; cont < 9; cont++){
                vetor3[cont] = vetor2[cont-10];

                Console.WriteLine(vetor3[cont]);
            }

        }
    }
}