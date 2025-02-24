using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizAlrevez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 📢 Solicitar al usuario el tamaño de la matriz
            Console.Write("Ingrese el número de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            // 🧩 Crear la matriz con el tamaño ingresado
            int[,] matriz = new int[filas, columnas];

            // 📝 Llenar la matriz con valores ingresados por el usuario
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                    if (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                    {
                        Console.WriteLine("⚠️ Entrada inválida. Se asignará 0 por defecto.");
                        matriz[i, j] = 0;
                    }
                }
            }

            // 🖨️ Mostrar la matriz en su forma original
            Console.WriteLine("\n🖨️ Matriz ingresada (forma original):\n");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine(); // Salto de línea al final de cada fila
            }

            // 🔄 Mostrar la matriz al revés
            Console.WriteLine("\n🔄 Matriz recorrida al revés (de abajo hacia arriba y derecha a izquierda):\n");
            for (int i = filas - 1; i >= 0; i--) // Comienza desde la última fila
            {
                for (int j = columnas - 1; j >= 0; j--) // Comienza desde la última columna
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine(); // Salto de línea al final de cada fila invertida
            }

            Console.ReadKey();
        }
    }
}
