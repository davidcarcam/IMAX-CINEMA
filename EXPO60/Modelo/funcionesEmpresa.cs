using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EXPO60.Controlador;
using System.Windows.Forms;

namespace EXPO60.Modelo
{
    class funcionesEmpresa
    {
        public static int insertarLocal(constructorEmpresa add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO empresas(NOMBRE_EMPR, DIRECCION_EMPR ) VALUES ('{0}','{1}')", add.nombreEmpresa, add.direccionEmpresa), Conexion.ObtenerConexion());
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
            catch (Exception e)
            {

                MessageBox.Show("Error critico de alv conexion, consulte con el administrador " + e, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }

    }
}
