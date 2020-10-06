using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        public bool InsertarProducto(int codigo, string nombre, int linea, int marca, int existencia, string estado)
        {
            string sql = "INSERT INTO PRODUCTOS VALUES ("+codigo+",'"+nombre+"',"+linea+","+marca+","+existencia+","+estado+")";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader odbcDataReader = command.ExecuteReader();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public int procInsertar(string tabla, string campo)
        {
            int codigo = 0;
            string sql = "SELECT MAX(" + campo + ") FROM " + tabla + "";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    codigo = reader.GetInt32(0);
                }
                codigo++;

            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }


            return codigo;
        }
        public List<string> llenarCombo(string tabla, string campo){
            List<string> id = new List<string>();
            string sql = "SELECT "+campo+" FROM "+tabla+"";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id.Add(reader.GetValue(0).ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            return id;
        }
        public List<string> llenarComboProducto(string tabla, string campo)
        {
            List<string> id = new List<string>();
            string sql = "SELECT " + campo + " FROM " + tabla + " WHERE ESTATUS_PRODUCTO=1";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id.Add(reader.GetValue(0).ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            return id;
        }
        public bool EliminarProducto(string id)
        {
            string sql = "UPDATE PRODUCTOS SET ESTATUS_PRODUCTO = 0 WHERE CODIGO_PRODUCTO=" + id + "";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader odbcDataReader = command.ExecuteReader();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
