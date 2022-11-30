using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProEscola.Models
{
    public class Instrutor : Pessoa
    {
        public int InstrutorId { get; set; }
        public string Formacao { get; set; }
        public string AreaAtuacao { get; set; }
        public ICollection<Turma> Turmas { get; set; }
        public Instrutor(string cpf, string nome) : base(cpf, nome)
        {
            base.Cpf = cpf;
            base.Nome = nome;
        }
    }
}
