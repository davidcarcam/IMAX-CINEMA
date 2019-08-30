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

        public static bool ValidarUsu(ConstructorRecuperarClave recu) //Validar el usuario Admin ingresado
        {
            bool retorno = false;

            try
            {
                string query = "SELECT * FROM usuario WHERE usuario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", ConstructorRecuperarClave.usuario));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retorno == true)
                {
                    string query2 = "SELECT * FROM usuario WHERE usuario = ?param2 AND clave = ?param3 AND id_estado_usu= ?param4";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, Conexion.ObtenerConexion());
                    cmdselect2.Parameters.Add(new MySqlParameter("param2", ConstructorRecuperarClave.usuario));
                    cmdselect2.Parameters.Add(new MySqlParameter("param3", recu.clave));
                    int estado = 1;
                    cmdselect2.Parameters.Add(new MySqlParameter("param4", estado));
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());

                    if (retorno == true)
                    {
                        MySqlDataReader _reader = cmdselect2.ExecuteReader();
                        while (_reader.Read())
                        {
                            ConstructorRecuperarClave.nombre = _reader.GetString(1) + " " + _reader.GetString(2);
                            ConstructorRecuperarClave.nivel = _reader.GetInt16(11);
                        }

                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta", "Clave Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {

                    MessageBox.Show("El usuario que a ingresado no esta registrado en la base de datos",
                    "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                return retorno;

            }

            catch (Exception ex)

            {
                MessageBox.Show("Oooops ha ocurrido un error consulte con su administrador " + ex, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }
        public static bool Validar(ConstructorRecuperarClave recu)
        {
            bool retorno = false;

            try
            {
                string query = "SELECT * FROM usuario WHERE usuario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", ConstructorRecuperarClave.usuarioRecu));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retorno == true)
                {
                    string query2 = "SELECT * FROM usuario WHERE usuario = ?param2";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, Conexion.ObtenerConexion());
                    cmdselect2.Parameters.Add(new MySqlParameter("param2", ConstructorRecuperarClave.usuarioRecu));
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                    MySqlDataReader _reader = cmdselect2.ExecuteReader();

                    while (_reader.Read())
                    {
                        ConstructorRecuperarClave.nivelRecu = _reader.GetInt16(11);
                    }
                }


                else

                {
                    MessageBox.Show("El usuario que a ingresado no esta registrado en la base de datos",
                    "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                return retorno;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error al conceder permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }
        }
        public static bool clave(ConstructorRecuperarClave contra)
        {

            bool retorno = false;

            try

            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE usuario SET clave = '{0}' WHERE usuario = '{1}'", contra.clave, ConstructorRecuperarClave.usuario), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteScalar());
                retorno = true;
                return retorno;
            }

            catch
            {

                MessageBox.Show("Error Critico de conexion", "Error al cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
                return retorno;
            }

        }

    }
}
