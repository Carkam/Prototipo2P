using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista;
namespace Prototipo2P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           IngresarProducto ingresarProducto = new IngresarProducto();
            ingresarProducto.MdiParent = this;
            ingresarProducto.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarProducto eliminarProducto = new EliminarProducto();
            eliminarProducto.MdiParent = this;
            eliminarProducto.Show();
        }
    }
}
