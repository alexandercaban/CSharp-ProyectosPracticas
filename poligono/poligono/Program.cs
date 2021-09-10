using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace poligono
{
    class Program
    {
        static void Main(string[] args)
        {
            area fig = new area();

            fig.P = 50;
            fig.AP = 35;

            fig.ar();

            Console.WriteLine("El area del poligono es: " + fig.A);
            Console.ReadKey();
        }
    }
}
