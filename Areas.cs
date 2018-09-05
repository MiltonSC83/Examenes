using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int menu;

            Console.WriteLine("Selecciona el área que deseas calcular: 1.Cuadrado  2.Círculo  3.Triángulo");
            menu = Convert.ToInt16(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Cuadrado C1 = new Cuadrado();
                    C1.CalcularArea();
                    break;

                case 2:
                    Circulo Cir1 = new Circulo();
                    Cir1.CalcularArea();
                    break;

                case 3:
                    Triangulo T1 = new Triangulo();
                    T1.CalcularArea();
                    break;

            }

            Console.ReadKey();

        }
    }
}
