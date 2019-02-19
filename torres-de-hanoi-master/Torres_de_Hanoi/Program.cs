using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi hanoi = new Hanoi();

            Pila Aux = new Pila();
            Pila Fin = new Pila();
            Pila Inicio = new Pila(3);

            hanoi.mover_disco(Inicio, Fin);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key exit.");
            Console.ReadKey();
        }
    }
}
