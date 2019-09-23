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
    class funcionesEmpresa
    {
        public static int insertarLocal(constructorEmpresa add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO empresa(empresa, direccion_empr ) VALUES ('{0}','{1}')", add.nombreEmpresa, add.direccionEmpresa), Conexion.ObtenerConexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Local agregado exitosamente", "proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido agregar el local", "proceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error critico de  conexion, consulte con el administrador " + ex, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static DataTable mostrarEmpresas()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM empresa";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception )
            {

                MessageBox.Show("Ops a ocurrido un problema con la obteccion de datos consulte con el administrador" ,"error critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
        public static bool actualizarEmpresa(constructorEmpresa upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE empresas SET empresa ='{0}' , direccion_empr = '{1}'",upd.nombreEmpresa,upd.direccionEmpresa ),Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if ( retorno == true)
                {
                    MessageBox.Show("Datos actualizados correctamente","actualizacion completada", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Datos no se pudieron actualizados correctamente", "actualizacion denegada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch (Exception )
            {

                MessageBox.Show("Datos no actualizados correctamente , consulte con el administrador", "error critico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return retorno;
            }
        }
        public static int eliminarEmpresa( int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM empresas WHERE id_empresa = '{0}'", id), Conexion.ObtenerConexion());
                retorno = Convert.ToInt32(cmddel.ExecuteNonQuery());
                if (retorno == 1)
                {
                    MessageBox.Show("Datos eliminados correctamente", "eliminacion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no se han podido eliminar correctamente", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {

                MessageBox.Show("Oops error de conexion consulte con el administrador" + e, "error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

    }
}
