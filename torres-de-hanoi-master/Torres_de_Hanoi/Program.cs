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
            Pila Aux = new Pila();
            Pila Fin = new Pila();
            Pila Inicio = new Pila(3);

            Console.WriteLine(Aux.Size);

            Disco d = new Disco();
            d.Valor = 4;
            
            Disco d2 = new Disco();
            d2.Valor = 3;

            Disco d3 = new Disco();
            d3.Valor = 5;

            Aux.push(d);
            Aux.push(d2);
            Aux.push(d3);
            Disco d4 = Aux.pop();

            Fin.push(d4);


            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key exit.");
            Console.ReadKey();
        }
    }
}
