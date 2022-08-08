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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBNombre.Clear();
            TBPass.Clear();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter RegistrarUsuario = new StreamWriter(@"C:\Users\amari.ADMINIS-5IFRA7A\Desktop\New folder (6)\WindowsFormsApplication1\Guardar informacion\" + TBNombre.Text + "Rs.txt", true);
                RegistrarUsuario.WriteLine(TBPass.Text);
                RegistrarUsuario.Close();

                MessageBox.Show("Se registro correctamente");
            }
            catch (Exception x)
            {
                MessageBox.Show("Hubo un error" + x, "Error");
                Form1 Principal = new Form1();
                Principal.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
