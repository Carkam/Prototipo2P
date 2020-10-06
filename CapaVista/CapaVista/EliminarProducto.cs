using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
            llenarCombo();
        }
        Controlador cn = new Controlador();
        public void llenarCombo()
        {
            List<string> id = cn.LlenarProducto("productos", "codigo_producto");

            foreach (var item in id)
            {
                cmbIdProducto.Items.Add(item);
            }

            List<string> nombre = cn.LlenarProducto("productos", "nombre_producto");

            foreach (var item in nombre)
            {
                cmbProducto.Items.Add(item);
            }
        }
        private void EliminarProducto_Load(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdProducto.SelectedIndex = cmbProducto.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cn.Eliminar(cmbIdProducto.SelectedItem.ToString()))
            {
                MessageBox.Show("Datos Eliminados");
                cmbIdProducto.Items.Clear();
                cmbProducto.Items.Clear();
                llenarCombo();
            }
            else
            {
                MessageBox.Show("No se pudieron eliminar los datos");
            }
        }
    }
}
