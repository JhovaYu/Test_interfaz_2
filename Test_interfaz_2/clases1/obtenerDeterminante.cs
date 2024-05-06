using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interfaz_2.clases1
{
    internal class obtenerDeterminante
    {
        // Método para calcular la determinante de una matriz 3x3
        internal static double CalcularDeterminante(double[,] matriz)
        {
            if (matriz.GetLength(0) != 3 || matriz.GetLength(1) != 3)
            {
                throw new ArgumentException("La matriz debe ser de tamaño 3x3.");
            }

            // Aplicamos la Regla de Sarrus
            double sumaDiagonalesDescendentes = matriz[0, 0] * matriz[1, 1] * matriz[2, 2]
                                              + matriz[0, 1] * matriz[1, 2] * matriz[2, 0]
                                              + matriz[0, 2] * matriz[1, 0] * matriz[2, 1];

            double sumaDiagonalesAscendentes = matriz[0, 2] * matriz[1, 1] * matriz[2, 0]
                                             + matriz[0, 0] * matriz[1, 2] * matriz[2, 1]
                                             + matriz[0, 1] * matriz[1, 0] * matriz[2, 2];

            double determinante = sumaDiagonalesDescendentes - sumaDiagonalesAscendentes;
            return determinante;
        }
    }
}
