using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EXPO60.Controlador;
using System.Windows.Forms;
using EXPO60.Modelo;


namespace EXPO60.Modelo
{
    class ValidarLogin
    {
        public static bool Acceso(ContructorLogin log)
        {
            bool retorno = false;
            //Verificar la existencia de usuario en la base de datos
            string query = "SELECT * FROM usuario WHERE usuario = ?user";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                //envio de parametro a la consulta
                cmdselect.Parameters.Add(new MySqlParameter("user", ContructorLogin.usuario));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                //Si el usuario existe el valor de retorno es TRUE, de lo contrario es FALSE
                if (retorno == true)
                {
                    //Verificar que los datos proporcionados sean los correctos
                    int estado = 1;
                    string query2 = "SELECT * FROM usuario WHERE usuario = ?user AND clave = ?pass AND id_estado_usu = ?state";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, Conexion.ObtenerConexion());
                    cmdselect2.Parameters.Add(new MySqlParameter("user", ContructorLogin.usuario));
                    cmdselect2.Parameters.Add(new MySqlParameter("pass", log.clave));
                    cmdselect2.Parameters.Add(new MySqlParameter("state", estado));
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                    if (retorno == true)
                    {
                        //Actualizar el campo intentos a 0
                        int intentos = 0;
                        MySqlCommand cmdreset = new MySqlCommand(string.Format("UPDATE usuario SET intentos = '{0}' WHERE usuario = '{1}'", intentos, ContructorLogin.usuario), Conexion.ObtenerConexion());
                        int reset = Convert.ToInt16(cmdreset.ExecuteNonQuery());
                        MySqlDataReader _reader = cmdselect.ExecuteReader();
                        while (_reader.Read())
                        {
                            ContructorLogin.nombre = _reader.GetString(1) + " " + _reader.GetString(2);
                            ContructorLogin.nivel = _reader.GetInt16(11);
                            if (reset >= 1)
                            {
                                MessageBox.Show("Bienvenido usuario : " + ContructorLogin.usuario, "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        //Contar el numero de intentos fallidos
                        MySqlDataReader reader = cmdselect.ExecuteReader();
                        while (reader.Read())
                        {
                            int intentos = 0;
                            intentos = reader.GetInt16(5) + 1;
                            if (intentos > 5)
                            {
                                //Bloquear usuario
                                int bloqueo = 3;
                                MySqlCommand cmdlog = new MySqlCommand(string.Format("UPDATE usuario SET id_estado_usu = '{0}' WHERE usuario = '{1}'", bloqueo, ContructorLogin.usuario), Conexion.ObtenerConexion());
                                int verificacion = Convert.ToInt32(cmdlog.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("Usuario bloqueado.  \n\nPara desbloquear al usuario contacte a un administrador", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE usuario SET intentos = '{0}' WHERE usuario = '{1}'", intentos, ContructorLogin.usuario), Conexion.ObtenerConexion());
                                int verificacion = Convert.ToInt32(cmdupdate.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("La contraseña proporcionada es incorrecta o el usuario no esta activo en la base de datos", "Erro de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
                else
                {
                    //Envio de mensaje de usuario inexistente
                    MessageBox.Show("El usuario que ha ingresado no esta ingresado en la base de datos", "Verifique su informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de acceso! Ha ocurrido un error en la conexion al servidor" + ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
            finally
            {
                Conexion.ObtenerConexion().Close();
            }
        }
    }
}

