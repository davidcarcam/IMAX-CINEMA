using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EXPO60.Controlador;

namespace EXPO60.Modelo
{
    class ValidarRecuperar_admin
    {
        public static bool ValidarUsu(ConstructorRecuperar_admin recu) //Validar el usuario Admin ingresado
        {
            bool retorno = false;

            try
            {
                string query = "SELECT * FROM usuario WHERE usuario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", ConstructorRecuperar_admin.usuario));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retorno == true)
                {
                    string query2 = "SELECT * FROM usuario WHERE usuario = ?param2 AND clave = ?param3 AND id_estado_usu= ?param4";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, Conexion.ObtenerConexion());
                    cmdselect2.Parameters.Add(new MySqlParameter("param2", ConstructorRecuperar_admin.usuario));
                    cmdselect2.Parameters.Add(new MySqlParameter("param3", recu.clave));
                    int estado = 1;
                    cmdselect2.Parameters.Add(new MySqlParameter("param4", estado));
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());

                    if (retorno == true)
                    {
                        MySqlDataReader _reader = cmdselect2.ExecuteReader();
                        while (_reader.Read())
                        {
                            ConstructorRecuperar_admin.nombre = _reader.GetString(1) + " " + _reader.GetString(2);
                            ConstructorRecuperar_admin.nivel = _reader.GetInt16(11);
                        }

                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta", "Clave Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show("El usuario que a ingresado no esta registrado en la base de datos",
                    "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return retorno;

            }

            catch (Exception ex)

            {
                MessageBox.Show("Oooops ha ocurrido un error consulte con su administrador " + ex, "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool Validar(ConstructorRecuperar_admin recu)
        {
            bool retorno = false;

            try
            {
                string query = "SELECT * FROM usuario WHERE usuario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", ConstructorRecuperar_admin.usuarioRecu));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (retorno == true)
                {
                    string query2 = "SELECT * FROM usuario WHERE usuario = ?param2";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, Conexion.ObtenerConexion());
                    cmdselect2.Parameters.Add(new MySqlParameter("param2", ConstructorRecuperar_admin.usuarioRecu));
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                    MySqlDataReader _reader = cmdselect2.ExecuteReader();

                    while (_reader.Read())
                    {
                        ConstructorRecuperar_admin.nivelRecu = _reader.GetInt16(11);
                    }
                }


                else

                {
                    MessageBox.Show("El usuario que a ingresado no esta registrado en la base de datos",
                    "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return retorno;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error al conceder permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool clave(ConstructorRecuperar_admin contra)
        {

            bool retorno = false;

            try

            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE usuario SET clave = '{0}' WHERE usuario = '{1}'", contra.clave, ConstructorRecuperar_admin.usuario), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteScalar());
                retorno = true;
                return retorno;
            }

            catch
            {

                MessageBox.Show("Error Critico de conexion", "Error al cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                retorno = false;
                return retorno;
            }

        }
    }
}
