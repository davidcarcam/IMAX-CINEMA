using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXPO60.Controlador;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;
using EXPO60.Vista;
using System.Data;

namespace EXPO60.Modelo
{
    class validarRecuperar
    {
        public static DataTable usuario()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM usuario";
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Error crititco", "Fallo de conexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return data = new DataTable();
            }
        }       
        public static DataTable preguntas()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM preguntas";
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Error critico", "Fallo de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
    }
}
