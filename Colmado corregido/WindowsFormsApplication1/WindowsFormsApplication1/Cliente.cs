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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            { 
            
                StreamWriter escribir = new StreamWriter(@"C:\Users\amari.ADMINIS-5IFRA7A\Desktop\New folder (3)\WindowsFormsApplication1\Guardar informacion.txt", true);

                try

                {
                    escribir.WriteLine("Nombre: " + textBox1.Text);
                    escribir.WriteLine("Numero: " + textBox2.Text);
                    escribir.WriteLine("Direccion: " + textBox3.Text);
                    escribir.WriteLine("Email: " + textBox4.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\amari.ADMINIS-5IFRA7A\Desktop\New folder (6)\WindowsFormsApplication1\Guardar informacion\Cliente.txt", true);

            try

            {
                escribir.WriteLine("Nombre: " + textBox1.Text);
                escribir.WriteLine("Numero: " + textBox2.Text);
                escribir.WriteLine("Direccion: " + textBox3.Text);
                escribir.WriteLine("Email: " + textBox4.Text);
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
