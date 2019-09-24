using System;

namespace Aula6_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamamos nossa priemeira função
            Console.WriteLine( Bomdia() );

            // Chamamos a função do tipo VOID (sem retorno)
            ImprimeDataHora();

            // Chamamos nossa função que calcule a média
            double[] numeros = { 2 , 5 , 2 , 8, 9, 5 };
            Console.WriteLine( CalculaMedia(numeros) );

            // Chamamos a função de soma
            Console.WriteLine( CalculaSoma(numeros) );

        }

        /// <summary>
        /// Função que escreve bom dia para o úsuario
        /// </summary>
        /// <returns>Retorne Olá! Bom dia!</returns>
        static string Bomdia(){
            return "Olá! Bom dia!";
        }

        /// <summary>
        /// Função que mostra uma saudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao">um texto qualquer (sobrecarga de método)</param>
        /// <returns>Saudação de acordo com o horário</returns>

        static string Bomdia(string saudacao){

            int Hora = DateTime.Now.Hour;

            if(Hora <= 12 && Hora >= 6){
                saudacao = "Bom dia";

            }else if(Hora > 12 && Hora <= 18){
                saudacao = "Bom tarde";

            }else{
                saudacao = "Bom noite";
            }

            return saudacao;
        }

        /// <summary>
        /// Retorna um número - teste de Sobrecarga
        /// </summary>
        /// <param name="numero">Um número inteiro qualquer</param>
        /// <return> número passado como parâmetro
            static int Bomdia(int numero){
                return numero;
            }

        /// <summary>
        /// Retorna Data e Hora atuais
        /// </summary>
        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour.ToString());
        }

        /// <summary>
        /// Função que Calcula a média de um valor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaMedia( double[] valores ){

            double resultado = 0;

            for(int i = 0; i < valores.Length ; i++){
                resultado = resultado + valores[i];
            }

            resultado = resultado / valores.Length;

            return resultado;

        }
        /// <summary>
        /// Calcula a soma de um vetor
        /// </summary>
        /// <param name="valores">Vetor de doubles</param>
        /// <returns>Soma de valores</returns>
        static double CalculaSoma( double[] valores ){

            double resultado = 0;

            for(int i = 0; i < valores.Length ; i++){
                resultado = resultado + valores[i];
            }

            resultado = resultado / valores.Length;

            return resultado;

    }
}
}