using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Cuadrado:Figura
    {
        
        public Cuadrado()
        {
            Console.WriteLine("Ingrese el valor del lado");
            x = Convert.ToDouble(Console.ReadLine());

        }
        public void CalcularArea()
        {
            Area = x * x;
            Console.WriteLine("El area del cuadrado es: " + Area);

        }

        
    }
}
