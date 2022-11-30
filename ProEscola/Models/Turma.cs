using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProEscola.Models
{
    public class Turma
    {
        [Key]
        public string SiglaTurma { get; set; }
        public string Descricao { get; set; }
        public string DataInicio { get; set; }
        public string DataTermino { get; set; }
        public string Periodo { get; set; }
        public int QtdeVagas { get; set; }
        public string Observacoes { get; set; }
        public List<Matricula> Matriculas { get; set; }
        public Instrutor Instrutor { get; set; }
        public Curso Curso { get; set; }

        public Turma(string siglaTurma, string descricao)
        {
            this.SiglaTurma = siglaTurma;
            this.Descricao = descricao;
        }

        public void EmitirListaFrequencia()
        {

        }

    }
}
