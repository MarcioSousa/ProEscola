using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProEscola.Models
{
    public class Aluno : Pessoa
    {
        public string Escolaridade { get; set; }
        public Matricula Matricula { get; set; }
        public Aluno(string cpf, string nome) : base(cpf, nome)
        {
            base.Cpf = cpf;
            base.Nome = nome;
        }

    }
}
