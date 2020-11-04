
namespace CadastroProdutos
{
    class Produtos
    {
        public int CodProduto { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Embalagem { get; set; }
        public string Sabor { get; set; }
        public int Quantidade { get; set; }

        public Produtos()
        {
        }

        public Produtos(int codProduto, string nome, double preco, string embalagem, string sabor, int quantidade)
        {
            CodProduto = codProduto;
            Nome = nome;
            Preco = preco;
            Embalagem = embalagem;
            Sabor = sabor;
            Quantidade = quantidade;
        }
    }
}