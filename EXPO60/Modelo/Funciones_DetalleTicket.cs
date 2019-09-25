using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EXPO60.Controlador;
using System.Windows.Forms;
using System.Data;

namespace EXPO60.Modelo
{
    class Funciones_DetalleTicket
    {
        public static DataTable mostrarFunciones()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_funcion AS ID, duracion, hora,dia,precio, num_sala, titulo, clasificacion FROM funciones INNER JOIN salas ON funciones.id_sala = salas.id_sala INNER JOIN peliculas ON peliculas.id_pelicula = funciones.id_pelicula INNER JOIN clasificacion ON clasificacion.id_clasificacion = funciones.id_clasifiacion";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {

                MessageBox.Show("Ops a ocurrido un problema con la obteccion de datos consulte con el administrador", "error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static int insertarticket(Constructor_DetalleTicket add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO ticket(cantidad, pelicula, hora, dia, clasificacion, sala,subtotal) VALUES ('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{5}')", add.cantidad, add.funcion_titulo, add.hora, add.dia, add.clasifiacion, add.sala, add.subtotal), Conexion.ObtenerConexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Ticket agregado exitosamente", "proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido agregar la orden", "proceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error critico de  conexion, consulte con el administrador " + ex, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
