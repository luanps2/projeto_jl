using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJL.Repositorios
{
    class Conexao
    {
                public static string ConsultarConexao()

        {

            return System.Configuration.ConfigurationManager.ConnectionStrings["banco"].ConnectionString;

        }

    }
}
