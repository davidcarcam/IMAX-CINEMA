using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXPO60.Controlador;
using MySql.Data.MySqlClient;

namespace EXPO60.Modelo
{
    public class Funciones_Ticket
    {
        public static int IngresarTicket(Constructor_Ticket add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO ticket(fecha_ticket, id_usuario) VALUES ('{0}','{1}')", add.fecha, add.usuario), Conexion.ObtenerConexion());
                retorno = Convert.ToInt16(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("El ticket ha sido ingresado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El ticket no pudo ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion" + e , "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
                throw;
            }
        }
        public static DataTable MostrarTicket()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM ticket";
                MySqlCommand cmdselect = new MySqlCommand((query), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion" + e , "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
        }
        public static int EliminarTicket(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM ticket WHERE id_ticket = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToInt16(cmddel.ExecuteNonQuery());
                if (retorno == 1)
                {
                    MessageBox.Show("El ticket ha sido eliminado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El ticket no ha podido ser eliminado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion" + e , "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable MostrarUsuario()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM `usuario` WHERE id_tipo_usu IN (1,2,5)";
                MySqlCommand cmdselect = new MySqlCommand((query), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion", "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
        }
    }
}
