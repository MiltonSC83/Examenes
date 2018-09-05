using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Circulo:Figura
    {
        public Circulo()
        {
            Console.WriteLine("Ingrese el valor del radio");
            x = Convert.ToDouble(Console.ReadLine());
        }
        public void CalcularArea()
        {
            Area = x * x*3.1416;
            Console.WriteLine("El area del círculo es: " + Area);

        }
    }
}
