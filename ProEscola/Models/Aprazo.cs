using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEscola.Models
{
    //[Keyless]
    public class Aprazo
    {
        public double Valor { get; set; }
        public string DtVencimento { get; set; }
        public int QtdeMensalidade { get; set; }
        public double TaxaJuros { get; set; }
        public Matricula Matricula { get; set; }
    }
}
