using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEscola.Models
{
    public class Avista
    {
        public double Valor { get; set; }
        public int Agencia { get; set; }
        public int NCheque { get; set; }
        public string PreData { get; set; }
        public Matricula Matricula { get; set; }
    }
}
