using Dapper;
using ProjetoJL.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJL.Repositorios
{
    public class ProdutoRepositorio
    {
        public List<Produto> ListarProduto()
        {
            List<Produto> produto;
            using (SqlConnection conn = new SqlConnection(Conexao.ConsultarConexao()))
            {

                string script = "SELECT id_prod IdProduto, " +
                    "cod_prod CodProduto, " +
                    "nome_prod NomeProduto, " +
                    "id_categoria IdCategoria, " +
                    "vl_prod ValorProduto, " +
                    "id_peso IdPeso" +
                    " FROM Produtos";

                produto = conn.Query<Produto>(script, new { }).ToList();

            }

            return produto;

        }
    }
}
