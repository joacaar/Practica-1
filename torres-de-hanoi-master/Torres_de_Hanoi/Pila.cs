using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        
        public int Top { get; set; }

        public List<Disco> Elementos { get; set; }
        

        /* TODO: Implementar métodos */
        public Pila()
        {
            this.Size = 0;
            this.Top = 0;
            this.Elementos = new List<Disco>();
        }

        public Pila(int size)
        {
            this.Size = size;
            this.Top = 1;
            this.Elementos = new List<Disco>();

            for (int i = 0; i<size; i++)
            {
                Disco aux = new Disco();
                aux.Valor = i + 1;
                Elementos.Add(aux);
            }

            for(int i = 0; i<size; i++)
            {
                Console.WriteLine("Elemento en: " + i + " : "+ Elementos[i].Valor);
            }
            
        }

        // Añadir un disco a la pila, Si el disco es de menor tamaño que el que se encuentra en la pila,
        //se podra poner, si la pila esta vacia se podra poner, si el disco que se encuentra es menor que el que se va aintroducir no hara nada
        public void push(Disco d)
        {
            Console.WriteLine("Inicio del Push");

            if (isEmpty())
            {
                Elementos.Insert(0, d);
                Size = Elementos.Count;
                Top = Elementos[Size-1].Valor;
                
            }
            else if (Elementos[0].Valor > (d.Valor))
            {
                Elementos.Insert(0, d);
                Size = Elementos.Count;
                Top = Elementos[Size - 1].Valor;

            }
            else
            {
                Console.WriteLine("Movimiento no válido");
                return;
            }

            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("Elemento en: " + i + " : " + Elementos[i].Valor);
            }

            Console.WriteLine("Fin del Push");

            Console.WriteLine("---------------------------------------------------");


        }

        public Disco pop()
        {
            Console.WriteLine("En la funcion POP");

            if (!isEmpty())
            {
                Console.WriteLine("Elementos iniciales");

                for (int i = 0; i < Size; i++)
                {
                    Console.WriteLine("Elemento en: " + i + " : " + Elementos[i].Valor);
                }
                Disco aux = new Disco();
                aux.Valor = Elementos[0].Valor;

                Elementos.RemoveAt(0);
                Size = Elementos.Count;
                Top = Elementos[0].Valor;
                Console.WriteLine("Elementos finales");

                for (int i = 0; i < Size; i++)
                {
                    Console.WriteLine("Elemento en: " + i + " : " + Elementos[i].Valor);
                }
                Console.WriteLine("Fin de pop");
                return aux;
            }

            Console.WriteLine("No hay elementos");

            return null;
        }                

        public bool isEmpty()
        {
            if (Elementos.Count.Equals(0))
            {
                return true;
            }
            return false;
        }

    }
}
