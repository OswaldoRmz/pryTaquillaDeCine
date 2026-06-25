using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTaquillaDeCine
{
    public class BoletoAdultoMayor : clsBoleto
    {
        public string NumCredencialInapam { get; set; }

        public BoletoAdultoMayor(string numCredencialInapam)
        {
            NumCredencialInapam = numCredencialInapam;
        }
        public override double CalcularBoletoFinal()
        {
            return PrecioBoleto * 0.50;
        }
    }
}