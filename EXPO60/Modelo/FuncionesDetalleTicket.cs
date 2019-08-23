using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using EXPO60.Controlador;



namespace EXPO60.Modelo
{
    class FuncionesDetalleTicket
    {
        public static int ingresardet(ConstructorDetalleTicket add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmadd = new MySqlCommand(string.Format("INSERT INTO detalle_ticket (id_funcion, id_asiento) VALUES ('{0}','{1}')", add.funcion, add.asiento), Conexion.ObtenerConexion());
                retorno = Convert.ToInt16(cmadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Registro ingresado exitosamente", "Procesos Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Registro no pudo ser ingresado", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error de conexion " + e);
                return retorno;
            }
        }
        public static bool actualizardet(ConstructorDetalleTicket upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE usuadetalle_ticketrio SET id_funcion = '{0}', id_asiento = '{1}' WHERE id_detalle_tick = '{2}'",
                                                                                        upd.funcion, upd.asiento, upd.iddetalle), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Datos Actualizados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han podido completar los datos", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error consulte con el administrador " + e, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static bool eliminardet(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM detalle_ticket WHERE id_detalle_tick = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro se ha eliminado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no se ha podido eliminar", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error consulte con el administrador " + e.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable funcion()
        {
            string query = "SELECT * FROM funciones";
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
        public static DataTable asiento()
        {
            string query = "SELECT * FROM asientos";
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
        public static DataTable mostrarusuario()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM asientos";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error crítico " + e);
                return data = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion();
            }
        }
    }
}
