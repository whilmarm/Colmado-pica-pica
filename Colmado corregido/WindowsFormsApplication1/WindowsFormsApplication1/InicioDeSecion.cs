using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class InicioDeSecion : Form
    {
        public InicioDeSecion()
        {
            InitializeComponent();
        }

        private void BTIniciarSecion_Click(object sender, EventArgs e)
        {
            try
            {
                TextReader Inicio = new StreamReader(TBNombre.Text + "Rs.txt");

                if (Inicio.ReadLine() == TBPass.Text)
                {
                    MessageBox.Show("Se inicio Sesion");
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesion");
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("Hubo un error" + z, "Error");
            }
            Form1 Principal = new Form1();
            Principal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
