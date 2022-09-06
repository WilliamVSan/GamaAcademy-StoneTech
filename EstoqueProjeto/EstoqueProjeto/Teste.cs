using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProjeto
{
    public class Teste
    {
        public void Testando()
        {
            using (var db = new EstoqueEntities())
            {
                Categoria categoria = new Categoria()
                {
                    NomeCategoria = "Escritorio",
                    Descricao = "Materiais para escritorio",
                    Tipo = "Tinta"
                };
                db.Categorias.Add(categoria);
                db.SaveChanges();
            }
        }
    }
}