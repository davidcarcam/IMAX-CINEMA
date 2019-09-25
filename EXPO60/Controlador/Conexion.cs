using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EXPO60.Controlador
{
    class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection connect;
            
            string server = "127.0.0.1";
            string database = "expo";
            string user = "root";
            string pass = "";
         
            try
            {
                connect = new MySqlConnection("server = " + server +
                                                "; database = " + database +
                                                "; Uid = " + user +
                                                "; pwd = " + pass);

                connect.Open();
                return connect;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexion " + e, "Fallo de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect = new MySqlConnection();
                return connect = new MySqlConnection();
            }
        }

        }
}


