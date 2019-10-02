using System;
using System.Collections.Generic;
using Aula13_Poo_Listas_Construtor.Models;

namespace Aula13_Poo_Listas_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Istanciamos nossa classe com o método contrutor passando os parâmetos
            ProdutoModel produto = new ProdutoModel(1, "Maça", "Verde", 3.5);

            // Chamamos um atributo do objeto instatanciado
            System.Console.WriteLine(produto.NomeProduto);

            // Istanciamos noosa Classe sem passar parâmetos utilizando sobrecarga
            ProdutoModel produto_sobrecarga = new ProdutoModel();

            // Alimentamos nosso objeto estava vazio
            produto_sobrecarga.IDProduto = 1;
            produto_sobrecarga.NomeProduto = "melão";
            produto_sobrecarga.Descricao = "Amarelo";
            produto_sobrecarga.Preco = 5.50;


            // Chamamos a nossa lista que vai ser do ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel>();

            // Adicionamos objetos istanciados e atributidos em nossa lista
            prod.Add( new ProdutoModel( 1, "Cenoura", "Larança", 2.30) );
            prod.Add( new ProdutoModel( 2, "Mamão", "Larança", 2.30) );
            prod.Add( new ProdutoModel( 3, "Beterra", "Larança", 2.30) );
            prod.Add( new ProdutoModel( 4, "Pastel", "Larança", 2.30) );
            prod.Add( new ProdutoModel( 5, "Caudo de cana", "Larança", 2.30) );
            prod.Add( new ProdutoModel( 6, "Chuchu", "Larança", 2.30) );

            // lemos os dados da nossa lista
            foreach(ProdutoModel p in prod){
                System.Console.WriteLine();
                System.Console.WriteLine(p.IDProduto);
                System.Console.WriteLine(p.NomeProduto);
                System.Console.WriteLine(p.Descricao);
                System.Console.WriteLine(p.Preco);
                System.Console.WriteLine();
            }

            // Chamamos através do índice um atributo específico
            System.Console.WriteLine(prod[4].NomeProduto);
        }
    }
}
