using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public bool Insertar(int codigo, string nombre, int linea, int marca, int existencia, string estado)
        {
            if (sn.InsertarProducto(codigo,nombre,linea,marca,existencia,estado))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public List<string> Llenar(string tabla, string campo)
        {
            List<string> id = sn.llenarCombo(tabla,campo);

            return id;
        }

        public List<string> LlenarProducto(string tabla, string campo)
        {
            List<string> id = sn.llenarComboProducto(tabla, campo);

            return id;
        }
        public int codigoMax(string tabla, string campo)
        {
            int codigo = sn.procInsertar(tabla, campo);

            return codigo;
        }
        public bool Eliminar(string id)
        {
            if (sn.EliminarProducto(id))
            {
                return true;
            }
            else
            {
                return false;
            }
       
        }
    }
}
