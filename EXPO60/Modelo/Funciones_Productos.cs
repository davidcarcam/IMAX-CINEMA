using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXPO60.Controlador;
using MySql.Data.MySqlClient;
using System.Data;

namespace EXPO60.Modelo
{
    class Funciones_Productos
    {
        public static int IngresarProducto(Constructor_Productos add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO productos (nombre_prod, precio, id_proveedor,id_tipo_prod, id_local) VALUES ('{0}', '{1}', '{2}', '{3}','{4}' )", add.nombre, add.precio, add.proveedor, add.tipoproducto, add.local ), Conexion.ObtenerConexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Producto ingresado exitosamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El producto no pudo ser ingresada, intente nuevamente y verifique que los datos sean correctos", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion " + e, "Fallo de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable MostrarProducto()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_producto AS ID, nombre_prod,precio,nombre,tipo_producto,nombre_local FROM productos INNER JOIN proveedores ON productos.id_proveedor = proveedores.id_proveedor INNER JOIN tipo_producto ON productos.id_tipo_prod = tipo_producto.id_tipo_prod INNER JOIN local_alimentos ON productos.id_local = local_alimentos.id_local";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, ha ocurrido un error en la obtencion de datos, consulte con su administrador. ", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static bool ActualizarProducto(Constructor_Productos upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE productos SET nombre_prod = '{0}', precio = '{1}', id_local = '{2}', id_proveedor = '{3}', id_tipo_prod = '{4}' WHERE id_producto = '{5}'",upd.nombre, upd.precio, upd.local, upd.proveedor, upd.tipoproducto, upd.idproducto), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Datos actualizados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Oops!, ha ocurrido un problema, revise su conexion a internet o los servicios del servidor, consulte con el administrador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool EliminarProducto(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM productos WHERE id_producto = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro ha sido eliminado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser eliminado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Oops!, ha ocurrido un error en la obtencion de datos, consulte con su administrador. " + e, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable ObtenerProv()
        {
            string query = "SELECT * FROM proveedores";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error crítico " + e);
                return data;
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static DataTable ObtenerLocal()
        {
            string query = "SELECT * FROM local_alimentos";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error crítico " + e);
                return data;
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static DataTable ObtenerEstado()
        {
            string query = "SELECT * FROM tipo_producto";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error crítico " + e);
                return data;
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
    }
}

    

