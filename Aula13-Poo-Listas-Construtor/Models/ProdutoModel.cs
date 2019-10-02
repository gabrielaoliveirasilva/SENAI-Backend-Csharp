namespace Aula13_Poo_Listas_Construtor.Models
{
    public class ProdutoModel
    {
        public int IDProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }


        // Utilizando sobrecarga para poder instanciar passando ou não os atributos/parâmetros/argumentos
        public ProdutoModel(){

        }
        public ProdutoModel(int idproduto, string nomeproduto, string descricao, double preco){

            this.IDProduto = idproduto;
            this.NomeProduto = nomeproduto;
            this.Descricao = descricao;
            this.Preco = preco;
        }
    }
}