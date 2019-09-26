using System;

namespace Aula8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            try{

                // Escrevemos um bloco de código
                Console.WriteLine("Digite um número");
                numero = int.Parse(Console.ReadLine( ));

            }catch(Exception ex){

                // Mostramos a execeção da regra
                // Erro gerado da aplicação
                Console.WriteLine("Ops :( Deu ruim." + ex);

            }
            

        }
    }
}
