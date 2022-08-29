using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.DAL
{
    public class EscolaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EscolaContext>
    {
        protected override void Seed(EscolaContext context)
        {
            var alunos = new List<Aluno>
            {
                new Aluno{Nome="Miguel", Sobrenome="Pereira", DataMatricula=DateTime.Parse("2000-08-07")},
                new Aluno{Nome="Gabriel", Sobrenome="Silva", DataMatricula=DateTime.Parse("2001-05-01")},
                new Aluno{Nome="Lucas", Sobrenome="Almeida", DataMatricula=DateTime.Parse("2003-07-06")},
                new Aluno{Nome="Pedro", Sobrenome="Andrade", DataMatricula=DateTime.Parse("2008-01-07")},
                new Aluno{Nome="Maria", Sobrenome="Borges", DataMatricula=DateTime.Parse("2013-04-01")},
                new Aluno{Nome="Alice", Sobrenome="Dias", DataMatricula=DateTime.Parse("2010-01-26")},
                new Aluno{Nome="Julia", Sobrenome="Fernandes", DataMatricula=DateTime.Parse("2000-05-07")},
                new Aluno{Nome="Beatriz", Sobrenome="Lopes", DataMatricula=DateTime.Parse("2001-06-13")}
            };

            alunos.ForEach(s => context.Alunos.Add(s));
            context.SaveChanges();

            var courses = new List<Curso>
            {
                new Curso{CursoID=1050, Titulo="Química",Creditos=3,},
                new Curso{CursoID=1045, Titulo="Cálculo",Creditos=4,},
                new Curso{CursoID=2042, Titulo="Literatura",Creditos=4,},
                new Curso{CursoID=2021, Titulo="Composição",Creditos=3,},
                new Curso{CursoID=4041, Titulo="Macroeconomia",Creditos=3,}
            };
            courses.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();

            var matriculas = new List<Matricula>
            { 
                new Matricula{AlunoID=1, CursoID=1050,Nota=Nota.A},
                new Matricula{AlunoID=1, CursoID=1045,Nota=Nota.B},
                new Matricula{AlunoID=2, CursoID=2042,Nota=Nota.A},
                new Matricula{AlunoID=2, CursoID=4041,Nota=Nota.B},
                new Matricula{AlunoID=3, CursoID=2021,Nota=Nota.F},
                new Matricula{AlunoID=3, CursoID=1050,Nota=Nota.C}
            };
            matriculas.ForEach(s => context.Matriculas.Add(s));
            context.SaveChanges();
        }
    }
}
