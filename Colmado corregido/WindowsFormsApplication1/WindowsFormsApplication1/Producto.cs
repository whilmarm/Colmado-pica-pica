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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\amari.ADMINIS-5IFRA7A\Desktop\New folder (6)\WindowsFormsApplication1\Guardar informacion\Producto.txt", true);

            try

            {
                escribir.WriteLine("Nombre del producto: " + textBox1.Text);
                escribir.WriteLine("Cantidad: " + textBox2.Text);
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
    }
}
