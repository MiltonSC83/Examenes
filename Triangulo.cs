using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Triangulo:Figura
    {
        public Triangulo()
        {
            Console.WriteLine("Ingrese el valor de la base");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la altura");
            y = Convert.ToDouble(Console.ReadLine());
        }
        public void CalcularArea()
        {
            Area = (x * y) / 2;
            Console.WriteLine("El area del triángulo es: " + Area);

        }
    }
}
