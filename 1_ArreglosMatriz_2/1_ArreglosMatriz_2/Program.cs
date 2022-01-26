using System;

namespace _1_ArreglosMatriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar vectores
            //[] - > Vector
            // [,] - > Matriz 2D
            // [,,] - > Matriz 3D
            // [,,,] - > Matriz 4D
            int[,] distancias = new int[3,2];


            // Asignar Valores
            distancias[0,0] = 3;
            distancias[0,1] = 3;
            distancias[1, 0] = 3;
            distancias[1, 1] = 3;
            distancias[2, 0] = 3;
            distancias[2, 1] = 3;

            //Acceder a los valores
            Console.WriteLine(distancias[1,1]);
            Console.ReadLine();

            //Recorrer valores
            for (int filas = 0; filas < 3; filas++)
            {
                for (int columnas = 0; columnas < 2; columnas++)
                {
                    Console.Write(distancias[filas,columnas] + "-");
                }
                Console.WriteLine();
            }
        }
    }
}
