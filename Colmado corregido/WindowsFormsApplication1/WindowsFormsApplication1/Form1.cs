using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Producto();
            formulario.ShowDialog();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Cliente();
            formulario.ShowDialog();
        }

        private void listProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new list();
            formulario.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Factura();
            formulario.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BTInicioSecion_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioDeSecion VentanainicioSesion = new InicioDeSecion();
            VentanainicioSesion.Show();

        }

        private void BTRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario VentanaUsuario = new RegistroUsuario();
            VentanaUsuario.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
