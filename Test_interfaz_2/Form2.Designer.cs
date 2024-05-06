namespace Test_interfaz_2
{
    partial class EncriptarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            panelTextBoxes = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            textBoxUsuario = new TextBox();
            Aceptar = new Button();
            button3 = new Button();
            button4 = new Button();
            panelTextBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 227);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los datos de la Matriz";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(11, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(248, 86);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(130, 86);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(11, 124);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(130, 124);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(248, 124);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(634, 84);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 20;
            label3.Text = "Ingrese Cualquier Texto";
            // 
            // button1
            // 
            button1.Location = new Point(177, 292);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Obtener Valores De la Matriz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelTextBoxes
            // 
            panelTextBoxes.Controls.Add(textBox3);
            panelTextBoxes.Controls.Add(textBox1);
            panelTextBoxes.Controls.Add(textBox2);
            panelTextBoxes.Controls.Add(textBox4);
            panelTextBoxes.Controls.Add(textBox6);
            panelTextBoxes.Controls.Add(textBox5);
            panelTextBoxes.Controls.Add(textBox7);
            panelTextBoxes.Controls.Add(textBox9);
            panelTextBoxes.Controls.Add(textBox8);
            panelTextBoxes.Location = new Point(71, 363);
            panelTextBoxes.Name = "panelTextBoxes";
            panelTextBoxes.Size = new Size(359, 171);
            panelTextBoxes.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(554, 363);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(346, 150);
            dataGridView1.TabIndex = 23;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // button2
            // 
            button2.Location = new Point(681, 292);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 24;
            button2.Text = "Agregar fila";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(564, 135);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(318, 23);
            textBoxUsuario.TabIndex = 10;
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(675, 171);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 25;
            Aceptar.Text = "botonAceptarTexto";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(303, 118);
            button3.Name = "button3";
            button3.Size = new Size(157, 23);
            button3.TabIndex = 26;
            button3.Text = "Obtener Determinante";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(444, 270);
            button4.Name = "button4";
            button4.Size = new Size(133, 23);
            button4.TabIndex = 27;
            button4.Text = "Separar numeros";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // EncriptarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 546);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Aceptar);
            Controls.Add(textBoxUsuario);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(panelTextBoxes);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EncriptarForm";
            Text = "Form2";
            Load += EncriptarForm_Load;
            panelTextBoxes.ResumeLayout(false);
            panelTextBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label3;
        private Button button1;
        private Panel panelTextBoxes;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button2;
        private TextBox textBoxUsuario;
        private Button Aceptar;
        private Button button3;
        private Button button4;
    }
}