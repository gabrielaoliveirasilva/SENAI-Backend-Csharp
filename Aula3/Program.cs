using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {

               // LAÇO CONTADO - FOR - INCREMENTO (+)
               for (int contador = 1; contador <= 100; contador++) {

                   // Verificamos se o número é diferente de par
                   if (contador % 2 != 0){
                       Console.WriteLine("FOR 0-100 - " + contador);
                   }

               }

               // LAÇO CONTADO - FOR DECREMENTO (-)
               for (int cont2 = 100; cont2 >= 0; cont2--){

                   // Verificamos se o número é diferente de par
                   if (cont2 % 2 != 0){
                       Console.WriteLine("FOR 100-0 " + cont2);
                   }

               }


            // LAÇO CONDICIONAL - WHILE
            double acumuladora = 0;
            double nota        = 0;
            int cont           = 0;
            string sair        = "";

            while (sair != "sim")
            {

                Console.WriteLine("Digite a nota de um aluno: ");
                nota = double.Parse(Console.ReadLine());


                acumuladora += nota;
                cont++;

                Console.Write("Deseja sair da aplicação? sim/não ");
                sair = Console.ReadLine().ToLower();

            }

            Console.WriteLine("Média das notas : " + (acumuladora / cont));


            /* PRBLEMA
                Faça um algoritimo que leia 20 números inteiros e
                acumule apenas os números múltiplos de 3
             */
             
            // LAÇO CONDICIONAL - DO / WHILE

            int numero1;
            int cont4 = 1;
            string acum = "";

            do{
                Console.Write( "Escreva um número  inteiro: " );
                numero1 = int.Parse(Console.ReadLine() );

                if( numero1 % 3 ==0 ){
                    acum += " - " + numero1.ToString();
                }
                cont4++;

            }while( cont4 <= 20);

            Console.WriteLine($"{acum} são os números múltiplos de 3");




        }

    }
}