using Ecommerce.Models;
using global::Ecommerce.Models;

namespace Ecommerce.repositorio
{
    public class ProdutoRepositorio
    {
        //Preparando a estrutura da conexão com o banco de dados
        private readonly string _connectionString;

        //Construtor
        public ProdutoRepositorio(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection"); //Default é padrão
        }

        // Criando o metodo adicionar produto
        public void AdicionarProduto(Produto produto)
        {
            using (var db = new Conexao(_connectionString))
            {
                var cmd = db.MySqlCommand();
                cmd.CommandText = "INSERT INTO Produtos (Nome, Descricao, Preco) VALUES (@Nome,@Descricao,@Preco)";
                cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
