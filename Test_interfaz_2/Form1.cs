using System.Runtime.InteropServices;

namespace Test_interfaz_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (NavPanel.Width == 250)
            {
                NavPanel.Width = 73;
            }
            else
            {
                NavPanel.Width = 250;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NavPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormPanel(object FormHijo)
        {
            if(this.PanelContenedor.Controls.Count > 0) 
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel= false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);  
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new EncriptarForm());
        }
    }
}