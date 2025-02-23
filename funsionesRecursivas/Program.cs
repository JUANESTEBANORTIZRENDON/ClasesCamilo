using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funsionesRecursivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sucesion, resultado;
            sucesion = GetCalcular();
            resultado = GetFibo(sucesion);
            Console.WriteLine("su factorial es "+resultado);



        }

        static int GetFibo(int termino)
        {
            int termino1 = 0;
            int termino2 = 1;
            int contador = 0;

            for (int i = 2; i < termino;i++)
            {
                contador = termino1 + termino2;
                termino1 = termino2;
                termino2 = contador;
                

                
            }
            return contador;
        }
        /*recurcion de metodos 
        static int GetFiboCur(int termino)
        {
            if (termino == 1) return 0;
            if (termino==2) return 1;
            return GetFiboCur(termino - 1) + GetFiboCur(termino - 2);
            
       
            
        }*/


        static int GetCalcular()
        {
            Console.WriteLine("Porfavor escribe el digito");
            int digito = int.TryParse(Console.ReadLine(), out digito) ? digito : 0;

            return digito;
        }

    }
}
