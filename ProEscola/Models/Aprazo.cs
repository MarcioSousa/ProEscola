using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProEscola.Models
{
    public class Aprazo
    {
        public int AprazoId { get; set; }
        public double Valor { get; set; }
        public string DtVencimento { get; set; }
        public int QtdeMensalidade { get; set; }
        public double TaxaJuros { get; set; }
        public Matricula Matricula { get; set; }
        public Aprazo(double valor, int qtdeMensalidade, double taxaJuros, string dtVencimento)
        {
            Valor = valor;
            DtVencimento = dtVencimento;
            QtdeMensalidade = qtdeMensalidade;
            TaxaJuros = taxaJuros;
        }
    }
}
