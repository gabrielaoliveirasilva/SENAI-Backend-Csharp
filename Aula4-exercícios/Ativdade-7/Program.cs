using System;

namespace Ativdade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double maior  = 0;
            double indice = 0;

            double[] vetor = new double[10];

            for(int i = 0; i <= 9; i++){
                Console.Write("Digite um numero: ");
                vetor[i] = double.Parse(Console.ReadLine());

                if(vetor[i] > maior){
                    maior  = vetor[i];
                    indice = i;
                }

            }

            Console.WriteLine($"Maior: {maior} , Indice: {indice}");
        }
    }
}