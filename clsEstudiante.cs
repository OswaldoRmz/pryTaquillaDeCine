using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTaquillaDeCine
{
    internal class clsEstudiante:clsBoleto
    {
        public string Matricula {  get; set; }

        public clsEstudiante(string matricula)
        {
            Matricula = matricula;
        }
        public override double CalcularBoletoFinal()
        {
            return PrecioBoleto - (PrecioBoleto * 0.30);
        }
    }
}
