﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interfaz_2.clases1
{


    internal class MultiplicarMatriz
    {
        //    static void Main()
        //    {
        //        Console.WriteLine("[Matriz 1]");
        //        Console.Write("Filas: ");
        //        int f1 = int.Parse(Console.ReadLine());
        //        Console.Write("Columnas: ");
        //        int c1 = int.Parse(Console.ReadLine());
        //        Console.WriteLine(" \n [Matriz 2]");
        //        Console.Write("Filas: ");
        //        int f2 = int.Parse(Console.ReadLine());
        //        Console.Write("Columnas: ");
        //        int c2 = int.Parse(Console.ReadLine());
        //        int[,] Matriz1 = new int[f1 + 1, c1 + 1];
        //        int[,] Matriz2 = new int[f2 + 1, c2 + 1];
        //        int[,] Multiplicacion = new int[f1 + 1, c2 + 1];
        //        if (c1 == f2)
        //        {
        //            Console.WriteLine(" \n Datos [Matriz 1]: ");
        //            for (int i = 1; i <= f1; i++)
        //            {
        //                for (int j = 1; j <= c1; j++)
        //                {
        //                    Console.Write("Ingresa Dato (Fila: {0} - Columna: {1}): ", i, j);
        //                    Matriz1[i, j] = int.Parse(Console.ReadLine());
        //                }
        //            }
        //            Console.WriteLine("Datos [Matriz 2]: ");
        //            for (int i = 1; i <= f2; i++)
        //            {
        //                for (int j = 1; j <= c2; j++)
        //                {
        //                    Console.Write("Ingresa Dato (Fila: {0} - Columna: {1}): ", i, j);
        //                    Matriz2[i, j] = int.Parse(Console.ReadLine());
        //                }
        //            }
        //            for (int i = 1; i <= f1; i++)
        //            {
        //                for (int j = 1; j <= c2; j++)
        //                {
        //                    Multiplicacion[i, j] = 0;
        //                    for (int z = 1; z <= c1; z++)
        //                    {
        //                        Multiplicacion[i, j] = Matriz1[i, z] * Matriz2[z, j] + Multiplicacion[i, j];
        //                    }
        //                }
        //            }
        //            Console.WriteLine("Multiplicacion de 2 Matrices");
        //            for (int i = 1; i <= f1; i++)
        //            {
        //                for (int j = 1; j <= c2; j++)
        //                {
        //                    Console.Write("{0} ", Multiplicacion[i, j]);
        //                }
        //                Console.WriteLine();
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Error: No se puede multiplicar las matrices" + " Columnas: {0}! = Filas: {1}", c1, f2);
        //        }
        //        Console.Read();
        //    }
    }
}
