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
    class Funciones_primerUso
    {
        public static int ingresarusuario(Constructor_primerUso add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmadd = new MySqlCommand(string.Format("INSERT INTO usuarios (USUARIO, DUI, TELEFONO, FECHA_NAC, CLAVE, DIRECCION, CORREO, NOMBRE, APELLIDO, ID_TIPO_USUARIO, ID_ESTADO_USUARIO) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                                                                            add.usuario, add.dui,add.telefono,add.fecha,add.clave,add.direccion,add.correo,add.nombre,add.apellido,add.tipo,add.estado), Conexion.ObtenerConexion());
                retorno = Convert.ToInt16(cmadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Empresa ingresada exitosamente", "Procesos Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La empresa no pudo ser ingresada", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string query = "SELECT * FROM estado_usuarios";
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
