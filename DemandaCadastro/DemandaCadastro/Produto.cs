using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemandaCadastro
{
    public class Produto : Categoria
    {
        public Categoria categoria { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public string Armazenagem { get; set; }
        public float PrecoCompra { get; set; }
        public float PrecoVenda { get; set; }
        public float PercaLucro { get; set; }
        public bool Status { get; set; }

    }
}
