using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EXPO60.Controlador;
using System.Windows.Forms;
using EXPO60.Modelo;
using System.Data;

namespace EXPO60.Modelo
{
    class ValidarLogin
    {
        public static bool Acceso(ContructorLogin2 log)
        {
            bool retorno = false;
            //Verificar la existencia de usuario en la base de datos
            string query = "SELECT * FROM usuario WHERE usuario = ?user";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
                //envio de parametro a la consulta
                cmdselect.Parameters.Add(new MySqlParameter("user", ContructorLogin2.usuario));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                //Si el usuario existe el valor de retorno es TRUE, de lo contrario es FALSE
                if (retorno == true)
                {
                    //Verificar que los datos proporcionados sean los correctos
                    int estado = 1;
                    string query2 = "SELECT * FROM usuario WHERE usuario = ?user AND clave = ?pass AND id_estado_usu = ?state";
                    MySqlCommand cmdselect2 = new MySqlCommand(query2, Conexion.ObtenerConexion());
                    cmdselect2.Parameters.Add(new MySqlParameter("user", ContructorLogin2.usuario));
                    cmdselect2.Parameters.Add(new MySqlParameter("pass", ContructorLogin2.clave));
                    cmdselect2.Parameters.Add(new MySqlParameter("state", estado));
                    retorno = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                    if (retorno == true)
                    {
                        //Actualizar el campo intentos a 0
                        int intentos = 0;
                        MySqlCommand cmdreset = new MySqlCommand(string.Format("UPDATE usuario SET intentos = '{0}' WHERE usuario = '{1}'", intentos, ContructorLogin2.usuario), Conexion.ObtenerConexion());
                        int reset = Convert.ToInt16(cmdreset.ExecuteNonQuery());
                        MySqlDataReader _reader = cmdselect.ExecuteReader();
                        while (_reader.Read())
                        {
                            ContructorLogin2.id = _reader.GetInt16(0);
                            ContructorLogin2.nombre = _reader.GetString(1) + " " + _reader.GetString(2);
                            ContructorLogin2.nivel = _reader.GetInt16(11);
                            if (reset >= 1)
                            {
                                if (ContructorLogin2.clave == "efAdsX436aQfSUcxfwNEbBolhN0=")
                                {
                                    MessageBox.Show("Se procedera a recuperar la contreseña", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (ContructorLogin2.clave != "efAdsX436aQfSUcxfwNEbBolhN0=")
                                {
                                    MessageBox.Show("Bienvenido usuario : " + ContructorLogin2.usuario, "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
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
                                MySqlCommand cmdlog = new MySqlCommand(string.Format("UPDATE usuario SET id_estado_usu = '{0}' WHERE usuario = '{1}'", bloqueo, ContructorLogin2.usuario), Conexion.ObtenerConexion());
                                int verificacion = Convert.ToInt32(cmdlog.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("Usuario bloqueado.  \n\nPara desbloquear al usuario contacte a un administrador", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE usuario SET intentos = '{0}' WHERE usuario = '{1}'", intentos, ContructorLogin2.usuario), Conexion.ObtenerConexion());
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
        public static bool ValidarExistencia()
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario", Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmd.ExecuteScalar());
                if (retorno == true)
                {
                    return retorno;
                }
                else
                {
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de acceso! Ha ocurrido un error en la conexion al servidor" + ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
                throw;
            }
            
        }
        public static bool ActualizarContraseña()
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE usuario SET clave = '{0}' WHERE usuario = '{1}'" , ContructorLogin2.clave, ContructorLogin2.usuario), Conexion.ObtenerConexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("La contraseña ha sido actualizada exitosamente");
                    return retorno;
                }
                else
                {
                    MessageBox.Show("La contraseña no pudo ser actualizada");
                    return retorno;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion");
                return retorno;
            }
        }
        //Validacion correo electronico
        public static string recover(string usuario)
        {

            Random rdn = new Random();
            int codigo = rdn.Next(10000, 90000);
            codigo.ToString();

            string query = "SELECT * FROM usuario WHERE binary usuario=?user";
            MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
            cmdselect.Parameters.AddWithValue("user", usuario);
            cmdselect.CommandType = CommandType.Text;


            MySqlDataReader reader = cmdselect.ExecuteReader();


            if (reader.Read() == true)
            {
                int ID = Convert.ToInt16(reader.GetInt16(0));
                ContructorLogin2.id = ID;
                string nombreusuario = reader.GetString(1) + " " + reader.GetString(2);
                string correo = reader.GetString(4);


                var Modelo = new Modelo.Conexion_Correo();
                bool datos = false;

                MySqlCommand cod = new MySqlCommand(string.Format("UPDATE usuario SET Codigo='{0}' WHERE usuario='{1}'", codigo, usuario), Conexion.ObtenerConexion());
                datos = Convert.ToBoolean(cod.ExecuteNonQuery());
                if (datos == true)
                {

                    Modelo.sendmail
                        (
                        subject: "Código para cambio de contraseña",
                        body: "Hola," + nombreusuario + "\nSolicitación de cambios de contraseñas\n" +
                        "tu codigo de seguridad es:\n" + codigo + "\nPor favor, reescriba el código dentro del campo solicitado ",
                        recipientmail: new List<string> { correo }
                        );
                }
                MessageBox.Show("Hola, se ha enviado un mensaje a tu correo electronico");
                return "Hola, se ha enviado un mensaje a tu correo electronico";

            }
            else
            {
                return "No tienes una cuenta con estas credenciales";
            }
        }

        public static bool validarcod(ContructorLogin2 cod)
        {
            bool retorno = false;
            string query = "SELECT * FROM usuario WHERE binary Codigo=?cod";
            try
            {
                MySqlCommand cmdeselct = new MySqlCommand(query, Conexion.ObtenerConexion());
                //envio de parametros a la consulta
                cmdeselct.Parameters.Add(new MySqlParameter("cod", cod.cod));
                retorno = Convert.ToBoolean(cmdeselct.ExecuteScalar());
                if (retorno == true)
                {
                    MessageBox.Show("Se procedera al cambio de contraseña", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El codigo no concuerda con lo enviado en el correo electronico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("error en la base de datos" + e, "error critico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return retorno;

            }
        }
    }
}

