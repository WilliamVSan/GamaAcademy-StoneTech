using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class Curso
    {
        //modificando a classe Curso, com um atributo(modificando a propriedade CursoID).
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        //Criando propriedades CursoID, Titulo, Creditos
        public int CursoID { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }
        public virtual ICollection<Matricula> Matriculas { get; set;}
    }
}
