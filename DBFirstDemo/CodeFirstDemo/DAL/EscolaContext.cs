using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.DAL
{
    public class EscolaContext : DbContext
    {
        public EscolaContext() : base("EscolaContext")
        {
        }
            public DbSet<Aluno> Alunos { get; set; }
            public DbSet<Matricula> Matriculas { get; set; }
            public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

