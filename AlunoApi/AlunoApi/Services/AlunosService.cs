using AlunoApi.Context;
using AlunoApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoApi.Services
{
    public class AlunosService : IAlunoService
    {
        private readonly AppDbContext _context;

        // Injeção em si
        public AlunosService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAluno(Aluno aluno)
        {
            _context.Alunos.Add(aluno); // Na memória
            // Persistindo no banco ...
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Aluno>> GetAlunos()
        {
            try
            {
                return await _context.Alunos.ToListAsync();
            }
            catch
            {
                throw; // Passa a exceção pra frente
            }
        }

        public async Task<Aluno> GetAluno(int id)
        {
            //Melhorar com implementação de erros Globais
            var aluno = await _context.Alunos.FindAsync(id);
            return aluno;
        }

        public async Task<IEnumerable<Aluno>> GetAlunosByNome(string nome)
        {
            IEnumerable<Aluno> alunos;
            if (!string.IsNullOrWhiteSpace(nome))
            {
                alunos = await _context.Alunos.Where(n => n.Nome.Contains(nome)).ToListAsync();
            } 
            else
            {
                alunos = await GetAlunos();
            }
            return alunos;
        }

        public async Task UpdateAluno(Aluno aluno)
        {
            _context.Entry(aluno).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAluno(Aluno aluno)
        {
            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();
        }
    }
}
