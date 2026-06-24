using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTaquillaDeCine
{
    public abstract class clsBoleto
    {
        public double PrecioBoleto { get; set; }      
        public clsBoleto()
        {
            PrecioBoleto = 100;
        }

        public abstract double CalcularBoletoFinal();
    }
}
