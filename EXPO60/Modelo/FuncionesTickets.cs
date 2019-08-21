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
    class FuncionesTickets
    {
        public static int ingresarticket(ConstructorTickets add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmadd = new MySqlCommand(string.Format("INSERT INTO tickets (FECHA_TICKET, ID_USUARIO) VALUES ('{0}','{1}')", add.fecha, add.usuario), Conexion.ObtenerConexion());
                retorno = Convert.ToInt16(cmadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Ticket ingresado exitosamente", "Procesos Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El ticket no pudo ser ingresada", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error de conexion " + e);
                return retorno;
            }
        }
        public static DataTable mostrarticket()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tickets";
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
        public static bool actualizarticket(ConstructorTickets upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE tickets SET FECHA_TICKET = '{0}', ID_USUARIO = '{1}' WHERE ID_TICKET = '{2}'",
                                                                                        upd.fecha, upd.usuario, upd.idTicket), Conexion.ObtenerConexion());
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
        public static bool eliminarticket(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tickets WHERE ID_TICKET = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El Ticket se ha eliminado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El ticket no se ha podido eliminar", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ha ocurrido un error consulte con el administrador " + e, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable obtenerUsuario()
        {
            string query = "SELECT * FROM usuarios";
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
