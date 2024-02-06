using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Cola
{
    class Program
    {
        
    	//
        //Ejercicios para la preparación 
        //

        static int sumatoria(Cola<int> cola){
            int cantE = cola.Cantidad();
            int total = 0;
            for (int i = 0; i < cantE; i++)
            {
                int valor = cola.DesencolarValor(); 
                total += valor;
                cola.Encolar(valor);
            }
            return total;
        }

        static int sumatoriaPares(Cola<int> cola){
            int cantE = cola.Cantidad();
            int total = 0;
            for (int i = 0; i < cantE; i++)
            {
                int valor = cola.DesencolarValor(); 
                if (valor % 2 == 0) {
                    total += valor;
                }
                cola.Encolar(valor);
            }
            return total;
        }

        static bool paQueYoQuieroSaberSiUnNumeroEnUnaColaMultiplicadoPor2esIgualAlParametro(Cola<int> cola, int valor){
            int cantE = cola.Cantidad();
            for (int i = 0; i < cantE; i++)
            {
                int actual = cola.DesencolarValor(); 
                if (actual * 2 == valor) {
                    return true;
                }
            }
            return false;
        }

        static int cantOcur(Cola<int> cola, int num){
            int cantE = cola.Cantidad();
            int cant = 0;
            for (int i = 0; i < cantE; i++)
            {
                int valor = cola.DesencolarValor(); 
                if (valor == num) {
                    Console.WriteLine($"se encontro en {i}");
                    cant ++;
                }
                cola.Encolar(valor);
            }
            return cant;
        }

        
        static void Main(string[] args)
        {
            Cola<int> miCola = new Cola<int>();
            Cola<int> miCola2 = new Cola<int>();
            Cola<int> miCola3 = new Cola<int>();

            miCola.Encolar(4);
            miCola.Encolar(4);
            miCola.Encolar(3);
            miCola.Encolar(2);
            miCola.Encolar(4);
            miCola.Encolar(7);   
            miCola2.Encolar(4);
            miCola2.Encolar(3);
            miCola2.Encolar(2);
            miCola2.Encolar(7);          

            Console.WriteLine(paQueYoQuieroSaberSiUnNumeroEnUnaColaMultiplicadoPor2esIgualAlParametro(miCola, 174));

        }
    }
}
