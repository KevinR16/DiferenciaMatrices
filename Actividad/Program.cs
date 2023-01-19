using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Actividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] prueba = new int[4][];
            prueba[0] = new int[] { 100, 2, 3, 5};
            prueba[1] = new int[] { 1, 2, 3, 5};
            prueba[2] = new int[] { 6, 7, 9, 10};
            prueba[3] = new int[] { 11, 22, 3, 5};

            Console.WriteLine("Diferencia absoluta de diagonales: " + diagonalDifference(prueba));
            Console.ReadLine();
        }

        static int diagonalDifference(int[][] arr)
        {
            int sumaDiagonal1 = 0, sumaDiagonal2= 0;
            int filas = arr.Length;

            // Suma de la primera diagonal
            for(int indice = 0; indice < filas; indice++)
            {
                // Valida si es una matriz cuadrada
                if (arr[indice] == null || arr[indice].Length != filas)
                {
                    Console.WriteLine("No es una matriz cuadrada");
                    return 0;
                }

                sumaDiagonal1 += arr[indice][indice];
            }

            // Suma de la segunda diagonal
            for(int indicefilas = 0, indicecolumnas = filas - 1; indicefilas < filas && indicecolumnas >= 0; indicefilas++, indicecolumnas--)
            {
                sumaDiagonal2 += arr[indicefilas][indicecolumnas];
            }

            int resta = sumaDiagonal1 - sumaDiagonal2;
            return resta < 0 ? resta * -1 : resta;
            //return Math.Abs(sumaDiagonal1 - sumaDiagonal2);
        }
    }
}
