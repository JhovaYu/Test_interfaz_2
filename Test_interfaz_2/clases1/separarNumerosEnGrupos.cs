using System;
using System.Collections.Generic;
using System.Linq;

namespace separarNumerosEnGrupos
{
    class Program
    {
        static void nose(string[] args)
        {
            List<int> mensaje = ObtenerMensajeDesdeOtraParteDelProyecto();

            // Calcula la cantidad de mini arrays necesarios
            int cantidadMiniArrays = (int)Math.Ceiling((double)mensaje.Count / 3);

            // Crea la lista que contendrá a los mini arrays
            List<List<int>> lista_que_contiene_a_todos = new List<List<int>>(cantidadMiniArrays);

            // Llena los mini arrays con los números del mensaje
            for (int i = 0; i < cantidadMiniArrays; i++)
            {
                List<int> miniArray = mensaje.Skip(i * 3).Take(3).ToList();
                lista_que_contiene_a_todos.Add(miniArray);
            }

            // Imprime los mini arrays (puedes adaptar esto según tu necesidad)
            foreach (var miniArray in lista_que_contiene_a_todos)
            {
                Console.WriteLine(string.Join(", ", miniArray));
            }
        }

        // Método ficticio para obtener la lista 'mensaje' desde otra parte del proyecto
        static List<int> ObtenerMensajeDesdeOtraParteDelProyecto()
        {
            // Aquí puedes implementar la lógica para obtener los valores de la lista
            // desde donde sea necesario en tu proyecto
            // Por ahora, devolvemos un ejemplo estático
            return new List<int> { 1, 3, 4, 6, 25, 23, 6, 25 };
        }
    }
}
