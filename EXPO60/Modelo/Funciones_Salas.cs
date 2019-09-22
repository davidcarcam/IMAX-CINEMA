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
                string query1 = "SELECT id_sala AS ID, num_sala, capacidad, estado_sala FROM salas INNER JOIN estado_sala ON salas.id_estado_sala = estado_sala.id_estado_sala";
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
        public static bool Actualizar_Sala(Constructor_Salas upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate1 = new MySqlCommand(string.Format("UPDATE salas SET num_sala = '{1}', capacidad = '{2}', id_estado_sala = '{3}' WHERE id_sala = '{0}'", upd.IDSala, upd.NumeroSala, upd.CapacidadSala, upd.EstadoSala), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupdate1.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos de la sala han sido actualizados satisfactoriamente", "Actualizacion safistactoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo al actualizar los datos de la sala", "Fallo en actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception c)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", c + "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
