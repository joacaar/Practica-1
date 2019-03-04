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

            int numDiscos = 4;
            Hanoi hanoi = new Hanoi();

            Pila Aux = new Pila();
            Aux.nombre = "Auxiliar";
            Pila Fin = new Pila();
            Fin.nombre = "Fin";
            Pila Inicio = new Pila(numDiscos);
            Inicio.nombre = "Inicio";

            Console.WriteLine("Inicio de partida --------------------------------");

            hanoi.mostrarPila(Inicio);
            hanoi.mostrarPila(Aux);
            hanoi.mostrarPila(Fin);


            Console.WriteLine("---------------------------------------------------");

            //hanoi.iterativo(3,Inicio, Fin, Aux);


            int mov = hanoi.recursivo(numDiscos, Inicio, Fin, Aux);

            Console.WriteLine("Fin de partida --------------------------------");

            hanoi.mostrarPila(Inicio);
            hanoi.mostrarPila(Aux);
            hanoi.mostrarPila(Fin);
            Console.WriteLine("Total movimientos : " + mov);
            Console.WriteLine("------------------------------------------------");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key exit.");
            Console.ReadKey();
        }
    }
}
/*
Console.WriteLine("Inicio de partida --------------------------------");

            hanoi.mostrarMovimiento(Inicio);
            hanoi.mostrarMovimiento(Aux);
            hanoi.mostrarMovimiento(Fin);


            Console.WriteLine("---------------------------------------------------");

            //hanoi.iterativo(3,Inicio, Fin, Aux);

            Console.WriteLine("Fin de partida --------------------------------");

            int mov = hanoi.iterativo(5, Inicio, Fin, Aux);

hanoi.mostrarMovimiento(Inicio);
            hanoi.mostrarMovimiento(Aux);
            hanoi.mostrarMovimiento(Fin);
            Console.WriteLine("Total movimientos : " + mov);
            Console.WriteLine("------------------------------------------------");
*/