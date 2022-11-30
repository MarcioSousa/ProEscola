using Microsoft.EntityFrameworkCore;
using ProEscola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEscola.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Instrutor> Instrutores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Aluno aluno1 = new("1", "João")
            {
                DataNasc = "01/09/2000",
                Endereco = "Rua AA",
                Numero = 17,
                Bairro = "Centro",
                Cidade = "Itu",
                Estado = "SP",
                Cep = "11222-111",
                Telefone = "5555511111",
                Celular = "11922211111",
                Sexo = "M",
                EstadoCivil = "Casado",
                Rg = "11.111.222-22",
                Email = "teste2@teste.com",
                Escolaridade = "Ensino Médio"
            };
            Aluno aluno2 = new("2", "Marcio")
            {
                DataNasc = "01/01/1990",
                Endereco = "Rua M",
                Numero = 15,
                Bairro = "Centro",
                Cidade = "Itu",
                Estado = "RJ",
                Cep = "31111-111",
                Telefone = "3311111111",
                Celular = "33911111111",
                Sexo = "M",
                EstadoCivil = "Solteiro",
                Rg = "33.111.111-11",
                Email = "teste3@teste.com",
                Escolaridade = "Ensino Superior"
            };

            Curso curso1 = new("AAA", "Analista")
            {
                CargaHoraria = 20,
                DataVigencia = "02/03/2022",
                Nome = "Analista",
                Programa = "Planilhas",
                Sigla = "AAA",
                Valor = 850.30,
                ValorHoraInstrutor = 125.30
            };
            Curso curso2 = new("BBB", "Eletrecista")
            {
                CargaHoraria = 30,
                DataVigencia = "22/10/2022",
                Nome = "Junior",
                Programa = "Residêncial",
                Sigla = "BBC",
                Valor =  743.20,
                ValorHoraInstrutor = 100.60
            };

            Turma turma1 = new("ADS", "Analista e Desenvolvimento de Sistemas")
            {
                Curso = curso1,
                DataInicio = "02/02/2022",
                DataTermino = "02/10/2022",
                Descricao = "Analistas de Sistemas",
                Observacoes = "Terá um mês de férias.",
                Periodo = "Manhã",
                QtdeVagas = 20,
                SiglaTurma = "AA10"
            };
            Turma turma2 = new("ABB", "Eletrecista Residêncial")
            {
                Curso = curso2,
                DataInicio = "02/03/2022",
                DataTermino = "02/06/2022",
                Descricao = "Bolos e Confeitos",
                Observacoes = "Não terá um mês de férias.",
                Periodo = "Tarde",
                QtdeVagas = 5,
                SiglaTurma = "BB01"
            };

            Matricula matricula = new(DateTime.Now.ToString())
            {
                Aluno = aluno2,
                Turma = turma1,
                Nota = 7.8,
                QtdeFaltas = 7
            };

            Aprazo aprazo = new()
            {
                Matricula = matricula,
                DtVencimento = "05/05/2022",
                QtdeMensalidade = 3,
                Valor = 322.60
            };

            modelBuilder.Entity<Instrutor>()
                .Property(P => P.Nome)
                .HasMaxLength(80);

            //modelBuilder.Entity<Matricula>()
            //    .HasKey(b => b.Data);

            modelBuilder.Entity<Matricula>()
                .HasOne(b => b.Aluno)
                .WithOne(i => i.Matricula)
                .HasForeignKey<Aluno>(b => b.Cpf);

            //modelBuilder.Entity<Matricula>()
            //    .HasOne(b => b.Aprazo)
            //    .WithOne(i => i.Matricula)
            //    .HasForeignKey<Matricula>(b => b.Data);

            //modelBuilder.Entity<Matricula>()
            //    .HasOne(b => b.Avista)
            //    .WithOne(i => i.Matricula)
            //    .HasForeignKey<Matricula>(b => b.Data);

            //modelBuilder.Entity<Aprazo> (
            //    eb =>
            //    {
            //        eb.HasNoKey();
            //    }
            //    );

            //modelBuilder.Entity<Instrutor>()
            //    .Property(P => P.Preco)
            //    .HasPrecision(10, 2);

            modelBuilder.Entity<Instrutor>().HasData(
                new Instrutor("1", "Roberto") {
                    DataNasc = "01/01/2000",
                    Endereco = "Rua J",
                    Numero = 10,
                    Bairro = "Centro",
                    Cidade = "Sorocaba",
                    Estado = "RJ",
                    Cep = "11111-111",
                    Telefone = "1111111111",
                    Celular = "11911111111",
                    Sexo = "M",
                    EstadoCivil = "Solteiro",
                    Rg = "11.111.111-11",
                    Email = "teste1@teste.com",
                    Formacao = "Ensino Médio",
                    AreaAtuacao = "Administração" },
                new Instrutor("2", "Ana")
                {
                    DataNasc = "01/01/2001",
                    Endereco = "Rua A",
                    Numero = 101,
                    Bairro = "Centro",
                    Cidade = "Jundiaí",
                    Estado = "SP",
                    Cep = "22222-111",
                    Telefone = "2211111111",
                    Celular = "22911111111",
                    Sexo = "F",
                    EstadoCivil = "Solteiro",
                    Rg = "11.111.111-22",
                    Email = "teste2@teste.com",
                    Formacao = "Ensino Fundamental",
                    AreaAtuacao = "Eletrecista"
                }
                );

            modelBuilder.Entity<Aluno>().HasData(aluno1);
            modelBuilder.Entity<Curso>().HasData(curso1, curso2);
            modelBuilder.Entity<Turma>().HasData(turma1, turma2);
            modelBuilder.Entity<Matricula>().HasData(matricula);
            modelBuilder.Entity<Aprazo>().HasData(aprazo);

            //modelBuilder.Entity<Avista>(
            //    eb =>
            //    {
            //        eb.HasNoKey();
            //    }
            //    );

        }
    }
}
