using Dapper;
using ProjetoJL.Repositorios;
using ProjetoJL_Lib.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJL_Lib.Repositorios
{
    public class PesoRepositorio
    {
        public List<Peso> ListarPeso()
        {
            List<Peso> peso;
            using (SqlConnection conn = new SqlConnection(Conexao.ConsultarConexao()))
            {
                string script = "SELECT id_peso IdPeso, nm_peso NomePeso FROM Peso";

                peso = conn.Query<Peso>(script, new { }).ToList();

            }
            return peso;
        }

    }
}
