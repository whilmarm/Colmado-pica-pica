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
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos guardados con exito.");
            MessageBox.Show("Producto agregado: " + comboBox1.Text, "Detalle del producto");
  
        }
        private void list_Load(object sender, EventArgs e)
        {         
            comboBox1.SelectedIndex = comboBox1.Items.Add("--Seleccionar producto--");
        }

    }
}
