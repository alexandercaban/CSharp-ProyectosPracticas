using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operacion
{
    class Program
    {
        static void Main(string[] args)
        {
            suma operar = new suma();
            
            operar.V1 = 40;
            operar.V2 = 80;

            operar.oper();

            Console.WriteLine("la suma es: "+ operar.RESUL);
            Console.ReadKey();
        }
    }
}
