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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\amari.ADMINIS-5IFRA7A\Desktop\New folder (6)\WindowsFormsApplication1\Guardar informacion\Factura.txt", true);

            try

            {
                escribir.WriteLine("NombreC: " + textBox1.Text);
                escribir.WriteLine("Producto: " + textBox2.Text);
                escribir.WriteLine("Cantidad: " + textBox3.Text);
                escribir.WriteLine("Precio: " + textBox4.Text);
                escribir.WriteLine("\n");
                {
                    MessageBox.Show("Guardado con exito");
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }

            escribir.Close();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            textBox2.SelectedIndex = textBox2.Items.Add("--Seleccionar producto--");
        }
    }
}
