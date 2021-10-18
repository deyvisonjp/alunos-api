using AlunoApi.Model;
using Microsoft.EntityFrameworkCore;

namespace AlunoApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Maria da Penha",
                    Email = "mariadapenha@email.com",
                    Idade = 23
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Manoel Bueno",
                    Email = "manoelbueno@email.com",
                    Idade = 25
                }
            );
        }

    }
}
