using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoJL.Modelos
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public int IdCategoria { get; set; }
        public int IdPeso { get; set; }
        public decimal ValorProduto { get; set; }
        
    }
}
