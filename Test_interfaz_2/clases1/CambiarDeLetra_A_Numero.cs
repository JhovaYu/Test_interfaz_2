using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interfaz_2.clases1
{
    internal class CambiarDeLetras_A_Numeros
    {
        internal static List<int> ObtenerNumerosDesdeVariable(string textoUsuario)
        {

            List<int> valoresNumericos = new List<int>();

            foreach (char letra in textoUsuario)
            {
                int valor = Alfabeto.ObtenerNumero(letra);
                if (valor != -1)
                {
                    valoresNumericos.Add(valor);
                }
                else
                {
                    Console.WriteLine($"La letra '{letra}' no está en el alfabeto.");
                }
            }

            // Ahora la lista 'valoresNumericos' contiene los valores numéricos correspondientes a las letras del usuario


            return valoresNumericos;
        }
    }
}
