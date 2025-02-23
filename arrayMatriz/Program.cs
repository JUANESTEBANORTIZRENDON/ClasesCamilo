using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro arreglo

            int[] arreglo = new int[4];
            //fefinimos la variable 
            arreglo[0] = 1;
            arreglo[1] = 21;
            arreglo[2] = 11;

            //mostramos en pantalla la informacion  del arreglo solo uno de sus indices 
            Console.WriteLine(arreglo[0]);
            //Mostrara el ultimo valor del array
            Console.WriteLine(arreglo[1]);
            int i = 0;
            //segunda forma de declarar y definir arreglo 
            int[] arreglito = { 3, 5, 6 };
            //mostraremos todos lo valores de arreglito con un for 
            for ( i = 0; i < 3; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

           

            
           foreach( int a in arreglo)
            {
                Console.WriteLine(a);
            }



            Console.ReadKey();

          


        }
    }
}
