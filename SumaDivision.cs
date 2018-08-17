using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class SumaDivision:Operacion
    {
        public double getSumando()
        {
            return (numero1 + numero2);
        }
        public double getDividendo()
        {
            return (numero1 / numero2);
        }
    }
}
