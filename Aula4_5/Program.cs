using System;

namespace Aula4_5
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] vetor = new int[10];

            for(int i= 1; i <= 9; i++){
                vetor[i] = i * 2;
            }

            for(int i= 1; i <= 9; i++){
                Console.WriteLine(vetor[i]);
        }
    }
}
}