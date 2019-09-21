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
    class FuncionUsuario
    {
        public static int ingresarusuario(Constructor_primerUso add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmadd = new MySqlCommand(string.Format("INSERT INTO usuario (nombre, apellido, direccion, correo, dui, telefono, usuario, clave, id_estado_usu, id_tipo_usu) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                                                                                            add.nombre, add.apellido, add.direccion, add.correo, add.dui, add.telefono, add.usuario, add.clave, add.estado, add.tipo), Conexion.ObtenerConexion());
                retorno = Convert.ToInt16(cmadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Usuario ingresado exitosamente", "Procesos Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario no pudo ser ingresado", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error de conexion " + e);
                return retorno;
            }
        }
        public static DataTable ObtenerTipoUsuario()
        {
            string query = "SELECT * FROM tipo_usuario WHERE id_tipo_usu != 1";
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
            string query = "SELECT * FROM estado_usuario";
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
                string query = "SELECT * FROM usuario WHERE id_tipo_usu >= 2";
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
        public static bool actualizarusuario(ConstructorUsuarios upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE usuario SET nombre = '{0}', apellido = '{1}', direccion = '{2}', correo = '{3}', dui = '{4}', telefono = '{5}', usuario = '{6}', clave = '{7}', id_estado_usu = '{8}', id_tipo_usu = '{9}' WHERE id_usuario = '{10}'",
                                                                                        upd.nombre, upd.apellido, upd.direccion, upd.correo, upd.dui, upd.telefono, upd.usuario, upd.clave, upd.estado, upd.tipo, upd.idusu), Conexion.ObtenerConexion());
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
        public static int EliminarUsuarios(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM usuario WHERE id_usuario = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToInt16(cmddel.ExecuteNonQuery());
                if (retorno == 1)
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
    }
}
