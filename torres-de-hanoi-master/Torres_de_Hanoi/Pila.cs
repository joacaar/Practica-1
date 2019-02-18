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

        public void push(Disco d)
        {

        }

        public Disco pop()
        {
            return null;
        }                

        public bool isEmpty()
        {
            return true;
        }

    }
}
