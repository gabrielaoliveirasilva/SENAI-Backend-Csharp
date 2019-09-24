using System;

namespace Aula5_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[3];
            double[] valor = new double[3];
            string sair = "";
            double acun = 0;

            while(sair !="0") {

                Console.WriteLine("Bem vindo");
                Console.WriteLine(
                    @"
                    menu:
                    1- Cadastrar produtos
                    2- listar produtos
                    3- Soma dos produtos
                    0- Sair 
                    "
                );

                sair = Console.ReadLine();

                switch(sair){
                    case "1":

                    for(int i =0; i <=2; i++){
                        Console.WriteLine("Digite o nome do Produto");
                        nome[i] = Console.ReadLine();

                        Console.WriteLine("Digite o valor");
                        valor[i] = double.Parse (Console.ReadLine() );

                        Console.WriteLine("Produto cadastrado");
                    }

                    break;

                    case "2":

                     for(int i =0; i <=2; i++){

                        Console.WriteLine(nome[i]+" "+ valor[i]);

                     }

                     break;
                   

                    case "3":

                    for(int i =0; i <=2; i++){
                        acun = acun + valor[i];
                        
                    }
                    Console.WriteLine(acun);

                    break;
                    
                    default: 
                    Console.WriteLine("Sair da aplicação");
                    break;}
                
                }
            }

        }
    }

