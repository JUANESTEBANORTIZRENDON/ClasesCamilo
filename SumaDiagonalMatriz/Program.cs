using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDiagonalMatriz
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

            // 📝 Solicitar al usuario que ingrese los valores
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                    if (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                    {
                        Console.WriteLine(" Entrada inválida. Se asignará 0 por defecto.");
                        matriz[i, j] = 0;
                    }
                }
            }

            //  Mostrar la matriz ingresada
            Console.WriteLine(" Matriz ingresada:\n");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine(); // Salto de línea al final de cada fila
            }

            //  Calcular la suma de la diagonal principal y secundaria (si aplican)
            int sumaDiagonalPrincipal = 0;
            int sumaDiagonalSecundaria = 0;

            //  Diagonal principal: posiciones donde i == j
            int minDimension = Math.Min(filas, columnas); // Para evitar desbordes si no es cuadrada
            for (int i = 0; i < minDimension; i++)
            {
                sumaDiagonalPrincipal += matriz[i, i];
            }

            // ⚡ Diagonal secundaria: posiciones donde i + j == columnas - 1
            for (int i = 0; i < minDimension; i++)
            {
                sumaDiagonalSecundaria += matriz[i, columnas - 1 - i];
            }

            //  Mostrar los resultados de las sumas
            Console.WriteLine($"\n🔹 Suma de la diagonal principal: {sumaDiagonalPrincipal}");
            Console.WriteLine($"🔹 Suma de la diagonal secundaria: {sumaDiagonalSecundaria}");

            // Comparar resultados
            if (sumaDiagonalPrincipal > sumaDiagonalSecundaria)
                Console.WriteLine(" La diagonal principal tiene un valor mayor.");
            else if (sumaDiagonalSecundaria > sumaDiagonalPrincipal)
                Console.WriteLine(" La diagonal secundaria tiene un valor mayor.");
            else
                Console.WriteLine(" Ambas diagonales tienen el mismo valor. ¡Qué coincidencia! ");

            Console.ReadKey();
        }
    }
}
