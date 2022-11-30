using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProEscola.Models
{
    public abstract class Pessoa
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string DataNasc { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }

        public Pessoa(string cpf, string nome)
        {
            this.Cpf = cpf;
            this.Nome = nome;
        }

    }
}
