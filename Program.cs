using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematische_Operatoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Als Operator wird das Zeichen bezeichnet das zum Rechnen verwendet wird. 
            //Addition +            10+5        a+b         zahl++;=+1
            //Substraktion -        10-5        a-b
            //Multiplikation *      10*5        a*b
            //Division /            10/5        a/b

            //int zahl = 10 + 5;
            int zahl1 = 10;
            int zahl2 = 5;
            int zahl3 = 0;
            int ergebnis = zahl1 + zahl2;
            int ergebnis2 = zahl1 - zahl2;
            int ergebnis3 = zahl1 * zahl2;
            int ergebnis4 = zahl1 / zahl2;
            int ergebnis6 = zahl3 + 1;
           
            //Kurzform zahl += 5;

            int ergebnis5 = 10 * (5 + 2);

            Console.WriteLine(ergebnis);
            Console.WriteLine(ergebnis2);
            Console.WriteLine(ergebnis3);
            Console.WriteLine(ergebnis4);
            Console.WriteLine(ergebnis5);
            Console.WriteLine(ergebnis6);

            Console.ReadKey();
        }
    }
}
