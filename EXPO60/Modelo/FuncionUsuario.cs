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
            string query = "SELECT * FROM tipo_usuario";
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
    }
}
