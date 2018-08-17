using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 0;
            string numero1String = "";
            double numero2 = 0;
            string numero2String = "";

            Console.WriteLine("Este programa realiza la suma y division de dos numeros dados por el usuario");

            Console.WriteLine("Introduce el primer numero, que corresponde a el primer sumando y el dividendo");
            numero1String = Console.ReadLine();
            numero1 = Convert.ToInt16(numero1String);

            Console.WriteLine("Introduce el segundo numero, que corresponde a el segundo sumando y el divisor");
            numero2String = Console.ReadLine();
            numero2 = Convert.ToInt16(numero2String);

            Console.ReadLine();

            SumaDivision Sum = new SumaDivision();

            Sum.setnumero1(numero1);
            Sum.setnumero2(numero2);

            Console.WriteLine("La suma es = {0}", Sum.getSumando());
            Console.WriteLine("La division es = {0}", Sum.getDividendo());
            Console.ReadKey();

        }
    }
}
