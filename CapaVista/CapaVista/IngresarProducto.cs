using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
namespace CapaVista
{
    public partial class IngresarProducto : Form
    {
        Controlador cn = new Controlador();
        public IngresarProducto()
        {
            InitializeComponent();
            llenarComboLinea();
            llenarComboMarca();
        }

        public void llenarComboLinea()
        {
            List<string> id = cn.Llenar("lineas", "codigo_linea");

            foreach (var item in id)
            {
                cmbIdlinea.Items.Add(item);
            }

            List<string> nombre = cn.Llenar("lineas", "nombre_linea");

            foreach (var item in nombre)
            {
                cmbLinea.Items.Add(item);
            }
        }
        public void llenarComboMarca()
        {
            List<string> id = cn.Llenar("marcas", "codigo_marca");

            foreach (var item in id)
            {
                cmbIdmarca.Items.Add(item);
            }

            List<string> nombre = cn.Llenar("marcas", "nombre_marca");

            foreach (var item in nombre)
            {
                cmbMarca.Items.Add(item);
            }
        }

        private void IngresarProducto_Load(object sender, EventArgs e)
        {

        }

        private void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdlinea.SelectedIndex = cmbLinea.SelectedIndex;
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdmarca.SelectedIndex = cmbMarca.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = cn.codigoMax("productos","codigo_producto");
            if (codigo==0)
            {
                codigo++;
            }
            int linea = int.Parse(cmbIdlinea.SelectedItem.ToString());
            int marca = int.Parse(cmbIdmarca.SelectedItem.ToString());
            int existencia = int.Parse(textBox2.Text);
            if (cn.Insertar(codigo,textBox1.Text,linea,marca,existencia,textBox3.Text))
            {
                MessageBox.Show("Datos Correctos");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                cmbIdlinea.Items.Clear();
                cmbLinea.Items.Clear();
                cmbIdmarca.Items.Clear();
                cmbMarca.Items.Clear();
                llenarComboLinea();
                llenarComboMarca();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }
    }
}
