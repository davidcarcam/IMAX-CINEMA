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
    class Funciones_Asientos
    {
        public static int Ingresar_Asientos(Constructor_Asientos add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdcreate3 = new MySqlCommand(String.Format("INSERT INTO asientos (id_fila, id_num, id_estado_asiento, id_sala) VALUES ('{0}','{1}','{2}','{3}')", add.fila, add.num, add.estado, add.sala), Conexion.ObtenerConexion());
                retorno = Convert.ToInt16(cmdcreate3.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("El asiento ha sido registrado exitosamente", "Exito al ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha logrado ingresar satisfactoriamente el registro del asiento", "Fallo al ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception a)
            {
                MessageBox.Show("ha ocurrido un fallo al ejecutar el comando, por favor contacte con el administrador", "Error Critico" + a, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Mostrar_Asientos()
        {
            DataTable Asientos;
            try
            {
                string query3 = "SELECT * FROM asientos";
                MySqlCommand cmdread3 = new MySqlCommand(string.Format(query3), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter3 = new MySqlDataAdapter(cmdread3);
                Asientos = new DataTable();
                adapter3.Fill(Asientos);
                return Asientos;
            }
            catch (Exception b)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", "Error Critico" + b, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Asientos = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static bool Actualizar_Asiento(Constructor_Asientos upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate3 = new MySqlCommand(string.Format("UPDATE asientos SET id_fila = {0}, id_num = {1}, id_estado_asiento = {2}, id_sala = {3} WHERE id_asiento = {4} ",
                                                                                            upd.fila, upd.num, upd.estado, upd.sala, upd.idasiento), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupdate3.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Los datos del asiento han sido actualizados satisfactoriamente", "Actualizacion safistactoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo al actualizar los datos del asiento", "Fallo en actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception c)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano" + c, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool Eliminar_Asiento(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdeliminar3 = new MySqlCommand(string.Format("DELETE FROM asientos WHERE id_asiento = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdeliminar3.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro del asiento ha sido eliminado satisfactoriamente", "Eliminacion completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro del asiento no se ha podido eliminar de la base de datos", "Fallo durante la eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception d)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", "Error Critico" + d, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable Sala()
        {
            DataTable Sala;
            try
            {
                string Asiento1 = "SELECT * FROM salas";
                MySqlCommand cmdsala1 = new MySqlCommand(string.Format(Asiento1), Conexion.ObtenerConexion());
                MySqlDataAdapter sal = new MySqlDataAdapter(cmdsala1);
                Sala = new DataTable();
                sal.Fill(Sala);
                return Sala;
            }
            catch (Exception e)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", "Error Critico" + e, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Sala = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static DataTable Estado_Asiento()
        {
            DataTable Estado_Asiento;
            try
            {
                string Asiento1 = "SELECT * FROM estado_asiento";
                MySqlCommand cmdasiento = new MySqlCommand(string.Format(Asiento1), Conexion.ObtenerConexion());
                MySqlDataAdapter Estado = new MySqlDataAdapter(cmdasiento);
                Estado_Asiento = new DataTable();
                Estado.Fill(Estado_Asiento);
                return Estado_Asiento;
            }
            catch (Exception e)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", "Error Critico" + e, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Estado_Asiento = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static DataTable num()
        {
            DataTable Estado_Asiento;
            try
            {
                string Asiento1 = "SELECT * FROM numeracion";
                MySqlCommand cmdasiento = new MySqlCommand(string.Format(Asiento1), Conexion.ObtenerConexion());
                MySqlDataAdapter Estado = new MySqlDataAdapter(cmdasiento);
                Estado_Asiento = new DataTable();
                Estado.Fill(Estado_Asiento);
                return Estado_Asiento;
            }
            catch (Exception e)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", "Error Critico" + e, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Estado_Asiento = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static DataTable fila()
        {
            DataTable Estado_Asiento;
            try
            {
                string Asiento1 = "SELECT * FROM fila";
                MySqlCommand cmdasiento = new MySqlCommand(string.Format(Asiento1), Conexion.ObtenerConexion());
                MySqlDataAdapter Estado = new MySqlDataAdapter(cmdasiento);
                Estado_Asiento = new DataTable();
                Estado.Fill(Estado_Asiento);
                return Estado_Asiento;
            }
            catch (Exception e)
            {
                MessageBox.Show("Se ha detectado un fallo en la conexion, Consulte con un administrador cercano", "Error Critico" + e, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Estado_Asiento = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
    }
}
