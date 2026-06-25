using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTaquillaDeCine
{
    internal class clsEstudiantes : clsBoleto
    {
        //se crea el atributo
        public string Matricula { get; set; }

        //creamps el constructor
        public clsEstudiantes(string matricula)
        {
            Matricula = matricula;
        }

        //metodo sobre escrito
        public override double CalcularBoletoFinal()
        {
            return PrecioBoleto - (PrecioBoleto * 0.30); //descuento de 30%
        }
    }
}
