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

/*            mostrarMovimiento(a);
            mostrarMovimiento(b);
*/
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
/*                    mostrarMovimiento(a);
                    mostrarMovimiento(b);
  */                  return;
                }

                aux = b.pop();
                a.push(aux);

 /*               mostrarMovimiento(a);
                mostrarMovimiento(b);
   */         }
            else
            {// sino se movera de 'a' a 'b'
                if (a.isEmpty())
                {
                    aux = b.pop();
                    a.push(aux);
 /*                   mostrarMovimiento(a);
                    mostrarMovimiento(b);
*/                    return;
                }
                aux = a.pop();
                b.push(aux);
/*                mostrarMovimiento(a);
                mostrarMovimiento(b);
  */          }

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {

            int m = 0;

            if((n%2) != 0)
            {

                while (true){
                  
                    if (fin.Size.Equals(n))
                    {
                        return m;
                    }
                    mover_disco(ini, fin);
                    mostrarMovimiento(ini, fin);
                    m++;
                    if (fin.Size.Equals(n))
                    {
                        return m;
                    }
                    mover_disco(ini, aux);
                    mostrarMovimiento(ini, aux);
                    m++;
                    if (fin.Size.Equals(n))
                    {
                        return m;
                    }
                    mover_disco(aux, fin);
                    mostrarMovimiento(aux, fin);
                    m++;
                }
            }
            else
            {
                while (true)
                {
                    if (fin.Size.Equals(n))
                    {
                        return m;
                    }
                    mover_disco(ini, aux);
                    mostrarMovimiento(ini, aux);
                    m++;
                    if (fin.Size.Equals(n))
                    {
                        return m;
                    }
                    mover_disco(ini, fin);
                    mostrarMovimiento(ini, fin);
                    m++;
                    if (fin.Size.Equals(n))
                    {
                        return m;
                    }
                    mover_disco(aux, fin);
                    mostrarMovimiento(aux, fin);
                    m++;
                }
            }
        }

        public void mostrarPila(Pila aux)
        {
            if (aux.isEmpty())
            {
                Console.WriteLine("Torre  " + aux.nombre + " : " + "-----" + "Vacia");
                return;
            }

            for (int i = 0; i <= aux.Size-1; i++)
            { 
                    Console.WriteLine("Torre  " + aux.nombre + " : "+ aux.Elementos[i].Valor);
            }
        }

        public void mostrarMovimiento(Pila a, Pila b)
        {
            Console.WriteLine("---------------------------");
            mostrarPila(a);
            mostrarPila(b);
            Console.WriteLine("---------------------------");

        }

        public int recursivo (int n, Pila ini, Pila fin, Pila aux)
        {

            int m=0;

            if (n == 1)
            {
                Disco inter;
                inter = ini.pop();
                fin.push(inter);
                m++;
                
            }
            else
            {
                m += recursivo(n - 1, ini, aux, fin);
                Disco inter = ini.pop();
                fin.push(inter);
                m++;
                m += recursivo(n - 1, aux, fin, ini);
                
            }
            return m;
        }
    }
}
