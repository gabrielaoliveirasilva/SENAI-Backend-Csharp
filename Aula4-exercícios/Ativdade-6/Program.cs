﻿using System;

namespace Aula4_6
{
    class Program
    {
        static void Main(string[] args)
        {

              int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[10];

            for(int i = 0; i <= 9; i++){
                Console.Write("Digite um número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <= 9; i++){
                Console.Write("Digite um número: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <= 9; i++){                
                vetor3[i] = vetor1[i] + vetor2[i];
            }

            for(int i = 0; i <= 9; i++){
                Console.WriteLine("V3 :" + vetor3[i] );
            

        }
    }
}
}