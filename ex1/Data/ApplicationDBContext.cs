using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex1.Models;
using Microsoft.EntityFrameworkCore;

namespace ex1.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {            
        }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Livro> Livros { get; set; }
    }
}