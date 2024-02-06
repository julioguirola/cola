using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Cola
{
    class Cola<T>
    {
        public Nodo<T> primero;
        public Nodo<T> ultimo;

        public Cola()
        {
            primero = ultimo = null;
        }
        
        public Cola(T info)
        {
        	primero = ultimo= new Nodo<T>(info);
        }

        public void Encolar(T valor)
        {
            Nodo<T> aux = new Nodo<T>();
            aux.Info = valor;
            if (primero == null) //en caso de que la cola este vacia
            {
                primero = ultimo = aux; //ingresamos dato en la cola
                aux.Sgte = null;        //hacemos que el dato señale a null
            }
            else
            {
                ultimo.Sgte = aux;
                aux.Sgte = null;
                ultimo = aux;
            }
        }

        public int Cantidad()
        {
            int cant = 1;
            Nodo<T> aux = new Nodo<T>();
            aux = primero;
            while (aux.Sgte != null)
            {
                cant++;
                aux = aux.Sgte;
            }
            return cant;
        }

        public void Desencolar() //desencola sin decir el valor
        {
            if (primero == null)
            {
                Console.WriteLine("Cola Vacia");
            }
            else
            {
                primero = primero.Sgte; //cambiamos de posicion el apuntador primero
            }
        }

        public T DesencolarValor() //desencola y muestra el valor desencolado
        {
            T valor = default(T);
            if (primero == null)
            {
                Console.WriteLine("Cola Vacia");
            }
            else
            {
                valor = primero.Info;
                primero = primero.Sgte;
            }
            return valor;
        }

        public void DesencolarValorP(T valor) //desencola y muestra el valor desencolado
        {
            Nodo<T> aux = new Nodo<T>();
            aux = primero;
            if (aux.Info.Equals(valor))
            {
                primero = primero.Sgte;
            }          
        }

        public void Mostrar()
        {
            if (primero == null)
            {
                Console.WriteLine("Cola Vacia");
            }
            else
            {
                Nodo<T> puntero;
                puntero = primero;
                do
                {
                    Console.WriteLine("{0}\t", puntero.Info);
                    puntero = puntero.Sgte;
                } while (puntero != null);
            }
            Console.WriteLine("\n");
        }

        //
        //Ejercicios para la preparación 
        //

        public Cola<T> Concatenar(Cola<T> cola2) {
            int cantE = cola2.Cantidad();
            for (int i = 0; i < cantE; i++){
                Encolar(cola2.DesencolarValor());
            }

            return this;
        } // la cola2 se queda vacia
       

        public void remAllOcur(T elm){
            int cantE = Cantidad();

            for (int i = 0; i < cantE; i++)
            {
                T valor = DesencolarValor();
                if (valor.Equals(elm)){
                    continue;
                }
                Encolar(valor);
            }
            
        }

        public void pasarIguales(Cola<T> cola, T elm){
            int cantE = cola.Cantidad();

            for (int i = 0; i < cantE; i++)
            {
                T valor = cola.DesencolarValor();
                if (valor.Equals(elm)){
                    Encolar(valor);
                }
            }
            
        }

   }

}