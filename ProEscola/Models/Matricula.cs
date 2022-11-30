using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProEscola.Models
{
    public class Matricula
    {   
        public int MatriculaId { get; set; }
        public int AlunoId { get; set; }
        public string Data { get; set; }
        public int QtdeFaltas { get; set; }
        public double Nota { get; set; }
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }

        public Matricula(string data)
        {
            this.Data = data;
        }
        public void EmitirCarne()
        {

        }
    }
}
