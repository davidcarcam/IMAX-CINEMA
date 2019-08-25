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
        public static int IngresarDetalle(FuncionesDetalleTicket add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO detalle_ticket(id_detalle_tick, id_funcion, id_asiento) VALUES '{0}','{1}','{3}'", add), Conexion.ObtenerConexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1  )
                {
                    MessageBox.Show("El detalle ha sido ingresado correctamente","Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El detalle no ha podido ser ingresado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }          
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion, si el problema persiste con sulte con su administrador", "Fallo en la conexion");
            }
            return retorno;
        }

        internal static object funcion()
        {
            throw new NotImplementedException();
        }

        internal static object asiento()
        {
            throw new NotImplementedException();
        }

        public static DataTable MostrarTicket()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM detalle_ticket";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query),Conexion.ObtenerConexion());
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

        internal static int IngresarDetalle(ConstructorDetalleTicket agregar)
        {
            throw new NotImplementedException();
        }

        public static bool ActualizarTicket(ConstructorDetalleTicket upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE detalle_ticket SET id_asiento = '{0}', id_funcion = '{1}' WHERE id_detalle_tick = '{2}'", upd.asiento, upd.funcion, upd.iddetalle), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro ha sido actualizado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no ha podido ser actualizado", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion, si el problema persiste consulte con un administrador" +e, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
