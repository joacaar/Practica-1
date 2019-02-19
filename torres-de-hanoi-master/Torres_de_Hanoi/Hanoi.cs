using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {//Mover disco de 'a' a 'b' o de 'b' a 'a'

            Disco aux = new Disco();

            if(a.isEmpty() && b.isEmpty())
            {
                return;
            }

            if(a.Top > b.Top)
            {// Si el disco top de a es mayor que el de b, entonces solo se podra mover de b hacia a
                if (b.isEmpty())
                {
                    aux = a.pop();
                    b.push(aux);
                    return;
                }
                aux = b.pop();
                a.push(aux);
            }
            else
            {// sino se movera de 'a' a 'b'
                if (a.isEmpty())
                {
                    aux = b.pop();
                    a.push(aux);
                    return;
                }
                aux = a.pop();
                b.push(aux);
            }

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
