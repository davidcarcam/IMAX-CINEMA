using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXPO60.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace EXPO60.Modelo
{
    class Funciones_Factura_Local
    {
        public static int Ingresar_Factura_Local(Constructo_Factura_Local add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(String.Format("INSERT INTO factura_local (monto_fac_local, fecha_fac_local, nombre_cliente, id_usuario) VALUES ('{0}','{1}','{2}','{3}')", add.monto_fac_local, add.fecha_fac_local, add.nombre_cliente, add.id_usuario), Conexion.ObtenerConexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Nueva factura ingresada correctamente", "Exito al ingresar factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha logrado ingresar satisfactoriamente la nueva factura", "Fallo al ingresar factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception a)
            {
                MessageBox.Show("ha ocurrido un fallo al ejecutar el comando, por favor contacte con el administrador", "Error Critico" + a, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Mostrar_Facturas()
        {
            DataTable Facturas;
            try
            {
                string query = "SELECT * FROM factura_local";
                MySqlCommand cmdread = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdread);
                Facturas = new DataTable();
                adapter.Fill(Facturas);
                return Facturas;
            }
            catch (Exception b)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano" + b, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Facturas = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static bool Actualizar_Factura_Local(Constructo_Factura_Local upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate1 = new MySqlCommand(string.Format("UPDATE factura_local SET monto_fac_local ='{0}' , fecha_fac_local = '{1}', nombre_cliente ='{2}', id_usuario ='{3}'", upd.monto_fac_local, upd.fecha_fac_local, upd.nombre_cliente, upd.id_usuario), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupdate1.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos de la factura han sido actualizados satisfactoriamente", "Actualizacion safistactoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo al actualizar los datos de la factura", "Fallo en actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception c)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", c + "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool Eliminar_Factura_Local(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdeliminar1 = new MySqlCommand(string.Format("DELETE FROM  factura_local WHERE id_factura_local = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdeliminar1.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro ha sido eliminado satisfactoriamente", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no se ha podido eliminar de la base de datos", "Fallo durante la eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception d)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", d + "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable usuario()
        {
            string query = "SELECT * FROM usuario";
            DataTable usua = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(usua);
                return usua;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error crítico " + e);
                return usua;
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static DataTable pago()
        {
            string query = "SELECT * FROM tipo_pago";
            DataTable usua = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(usua);
                return usua;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error crítico " + e);
                return usua;
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
    }
}
