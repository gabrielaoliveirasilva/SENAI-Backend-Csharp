using System;

namespace Aula4_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dados dois vetores, A e B com 15 palavras, construa um terceiro vetor com os dados
            //dos vetores anteriores

            string[] vetor1 = new string[15];
            string[] vetor2 = new string[15];
            string[] vetor3 = new string[15];

            for(int i = 0; i <=15; i++){

                Console.Write("Digite um palavra: ");
                vetor1[i] = Console.ReadLine();

            }

            for(int i = 0; i <=15; i++){

                Console.Write("Digite uma palavra: ");
                vetor2[i] =vetor2[i];

            }

            for(int i = 0; i <=15; i++){

                Console.Write("Digite uma plavra: ");
                vetor3[i+16] =vetor2[i];

            }

            for(int i = 0; i <=30; i++){
                Console.Write("v3: "+vetor3[i]);
            }




        }
    }
}
