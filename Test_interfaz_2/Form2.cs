using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_interfaz_2.clases1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_interfaz_2
{
    public partial class EncriptarForm : Form
    {
        double[,] matrizClave = new double[3, 3];

        System.Windows.Forms.TextBox[] textBoxes = new System.Windows.Forms.TextBox[9];

        String textoUsuario;

        double siEsInvertible;

        List<int> mensaje = new List<int>();



        public EncriptarForm()
        {
            InitializeComponent();

            textBoxes[0] = textBox1;
            textBoxes[1] = textBox2;
            textBoxes[2] = textBox3;
            textBoxes[3] = textBox4;
            textBoxes[4] = textBox5;
            textBoxes[5] = textBox6;
            textBoxes[6] = textBox7;
            textBoxes[7] = textBox8;
            textBoxes[8] = textBox9;

            //MostrarMatrizEnDataGridView();
        }

        private void MostrarMatrizEnDataGridView()
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            //MessageBox.Show(valorTextBox1);
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    dataGridView1.Rows[fila].Cells[columna].Value = matrizClave[fila, columna];
                }
            }
        }

        private void EncriptarForm_Load(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            double valorTextBox1, valorTextBox2, valorTextBox3,
           valorTextBox4, valorTextBox5, valorTextBox6,
           valorTextBox7, valorTextBox8, valorTextBox9;

            if (double.TryParse(textBoxes[0].Text, out valorTextBox1) &&
                double.TryParse(textBoxes[1].Text, out valorTextBox2) &&
                double.TryParse(textBoxes[2].Text, out valorTextBox3) &&
                double.TryParse(textBoxes[3].Text, out valorTextBox4) &&
                double.TryParse(textBoxes[4].Text, out valorTextBox5) &&
                double.TryParse(textBoxes[5].Text, out valorTextBox6) &&
                double.TryParse(textBoxes[6].Text, out valorTextBox7) &&
                double.TryParse(textBoxes[7].Text, out valorTextBox8) &&
                double.TryParse(textBoxes[8].Text, out valorTextBox9))
            {
                // Asigna los valores a la matrizClave
                matrizClave[0, 0] = valorTextBox1;
                matrizClave[0, 1] = valorTextBox2;
                matrizClave[0, 2] = valorTextBox3;
                matrizClave[1, 0] = valorTextBox4;
                matrizClave[1, 1] = valorTextBox5;
                matrizClave[1, 2] = valorTextBox6;
                matrizClave[2, 0] = valorTextBox7;
                matrizClave[2, 1] = valorTextBox8;
                matrizClave[2, 2] = valorTextBox9;

                
            }
            else
            {
                MessageBox.Show("Introduce valores numéricos válidos en las TextBoxes.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MostrarMatrizEnDataGridView();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            textoUsuario = textBoxUsuario.Text;

            mensaje = CambiarDeLetras_A_Numeros.ObtenerNumerosDesdeVariable(textoUsuario);

            List<string> listaCadena = new List<string>();

            foreach (int valor in mensaje)
            {
                listaCadena.Add(valor.ToString());
            }

            string resultado = string.Join(", ", listaCadena);
            Console.WriteLine(resultado);
            MessageBox.Show(resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double determinante = obtenerDeterminante.CalcularDeterminante(matrizClave);
            MessageBox.Show($"La determinante es: {determinante}");
            if (determinante != 0)
            {
                MessageBox.Show("La determinante es distinta de 0");
                determinante = siEsInvertible;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Calculo la cantidad de mini arrays necesarios
            int cantidadMiniArrays = (int)Math.Ceiling((double)mensaje.Count / 3);

            // Creo la lista que contendrá a los mini arrays
            List<List<int>> lista_que_contiene_a_todos = new List<List<int>>(cantidadMiniArrays);

            // Lleno los mini arrays con los números del mensaje
            for (int i = 0; i < cantidadMiniArrays; i++)
            {
                List<int> miniArray = mensaje.Skip(i * 3).Take(3).ToList();
                lista_que_contiene_a_todos.Add(miniArray);
            }

            // Se imprimen los mini arrays 
            foreach (var miniArray in lista_que_contiene_a_todos)
            {
                MessageBox.Show(string.Join(", ", miniArray));
            }
        }
    }
}
