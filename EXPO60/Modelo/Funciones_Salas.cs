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
    class Funciones_Salas
    {
        public static int ingresar_salas(Constructor_Salas add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(String.Format("INSERT INTO salas (num_sala, capacidad, id_estado_sala) VALUES ('{0}','{1}','{2}')", add.NumeroSala, add.CapacidadSala, add.EstadoSala), Conexion.ObtenerConexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Nueva sala ingresada correctamente", "Exito al ingresar sala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha logrado ingresar satisfactoriamente la sala", "Fallo al ingresar la sala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception a)
            {
                MessageBox.Show("ha ocurrido un fallo al ejecutar el comando, por favor contacte con el administrador", "Error Critico" + a, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Mostrar_Salas()
        {
            DataTable salas;
            try
            {
                string query1 = "SELECT ts.id_sala, ts.num_sala,ts.capacidad, te.estado_sala FROM salas ts , estado_sala te WHERE te.id_estado_sala = ts.id_estado_sala";
                MySqlCommand cmdread1 = new MySqlCommand(string.Format(query1), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmdread1);
                salas = new DataTable();
                adapter1.Fill(salas);
                return salas;
            }
            catch (Exception b)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano" +b, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return salas = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static bool ActualizarSala(Constructor_Salas upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE salas SET num_sala = '{0}', capacidad = '{1}', id_estado_sala = '{2}' WHERE id_sala = '{3}'", upd.NumeroSala, upd.CapacidadSala, upd.EstadoSala, upd.IDSala), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("La sala ha sido actualizada correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool Eliminar_Salas(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdeliminar1 = new MySqlCommand(string.Format("DELETE FROM salas WHERE id_sala = '{0}'", id), Conexion.ObtenerConexion());
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
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", d + "Error Critico" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Estado_Sala()
        {
            string query = "SELECT * FROM estado_sala";
            DataTable sal = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(sal);
                return sal;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error crítico " + e);
                return sal;
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
    }
}
