//Algoritmo explicado de como construir una matriz por consola y como llenarla  y recorrerla  lo realizaremos por metodos 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Construimos una matriz de dimensiones 3x3
            int[,] matriz = new int[3, 3];
            int filas, columna;

            // Recorremos la matriz y solicitamos los datos
            for (filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for (columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write($"Por favor ingresa el valor de la matriz en la coordenada [{filas},{columna}]: ");
                    if (!int.TryParse(Console.ReadLine(), out matriz[filas, columna]))
                    {
                        Console.WriteLine("⚠️ Entrada inválida. Se asignará 0 por defecto.");
                        matriz[filas, columna] = 0;
                    }
                }
            }

            // Mostramos los valores ingresados
            Console.WriteLine("\nValores ingresados:\n");

            for (filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for (columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[filas, columna] + "\t");
                }
                Console.WriteLine(); // Salto de línea al final de cada fila
            }

            Console.ReadKey();
        }
    }
}