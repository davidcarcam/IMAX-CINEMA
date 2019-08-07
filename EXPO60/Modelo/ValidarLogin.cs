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

        //private static string ex;

        public static object C { get; private set; }

        public static bool Acceso(ContructorLogin log)
        {
            bool retorno = false;
            //Verificar la existencia del usuario en la base de dato
            string query = "SELECT *FROM usuarios WHERE USUARIO = ?user ";
            //try
            //{
            MySqlCommand cmdselect = new MySqlCommand(query, Conexion.ObtenerConexion());
            // envio de parametroa la consulta
            cmdselect.Parameters.Add(new MySqlParameter("user", ContructorLogin.usuario));
            retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
            //si el usuario existe el valor de retorno es si 
            if (retorno == true)
            {
                //verificar los datos
                int estado = 1;
                string query2 = "SELECT * FROM usuarios WHERE USUARIO = ?user AND CLAVE = ?pass AND ID_ESTADO_USUARIO = ?state";
                MySqlCommand cmdseletc2 = new MySqlCommand(query2, Conexion.ObtenerConexion());
                cmdseletc2.Parameters.Add(new MySqlParameter("user", ContructorLogin.usuario));
                cmdseletc2.Parameters.Add(new MySqlParameter("pass", log.clave));
                cmdseletc2.Parameters.Add(new MySqlParameter("state", estado));
                retorno = Convert.ToBoolean(cmdseletc2.ExecuteScalar());

                if (retorno == true)
                {
                    //actualizar el campo
                    int intentos = 0;
                    MySqlCommand cmdreset = new MySqlCommand(string.Format("UPDATE usuarios SET INTENTOS = '{0}' WHERE USUARIO = '{1}'", intentos, ContructorLogin.usuario), Conexion.ObtenerConexion());
                    int reset = Convert.ToInt16(cmdreset.ExecuteNonQuery());
                    MySqlDataReader _reader = cmdselect.ExecuteReader();
                    while (_reader.Read())
                    {
                        ContructorLogin.nombre = _reader.GetString(9) + "" + _reader.GetString(10);
                        ContructorLogin.nivel = _reader.GetInt16(11);
                        if (reset >= 1)
                        {
                            MessageBox.Show("Bienvenido.", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                else
                {
                    //contar el numero de intentos
                    MySqlDataReader reader = cmdselect.ExecuteReader();
                    while (reader.Read())
                    {
                        int intentos = 0;
                        intentos = reader.GetInt16(8) + 1;
                       
                        if (intentos > 5)
                        {
                            int bloqueo = 3;
                            MySqlCommand cmdlock = new MySqlCommand(string.Format("UPDATE usuarios SET ID_ESTADO_USUARIO = '{0}' WHERE USUARIO = '{1}'", bloqueo, ContructorLogin.usuario), Conexion.ObtenerConexion());
                            int verificacion = Convert.ToInt32(cmdlock.ExecuteNonQuery());
                            if (verificacion >= 1)
                            {
                                MessageBox.Show("Usuario Bloqueado.\n\nPara desbloquear al usuario contacte a un administrador.", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE usuarios SET INTENTOS = '{0}' WHERE USUARIO = '{1}'", intentos, ContructorLogin.usuario), Conexion.ObtenerConexion());
                            int verificacion = Convert.ToInt32(cmdupdate.ExecuteNonQuery());
                            if (verificacion >= 1)
                            {
                                MessageBox.Show("La contraseña proporcionada es incorrecta o el usuario no esta activo en la base de datos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                //actualizar el campos a 0

            }
            else
            {
                // envio de mensario no existe
                MessageBox.Show("El usuario que ha ingresado no esta registrado en la base de datos.", "Verifique su informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return retorno;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error de acceso,Ha ocurrido un error en la conexion al servidor" +ex,"Error de conexion", MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    return retorno;
            //}

        }

        private static void ObtenerConexion()
        {
            throw new NotImplementedException();
        }
    }
}

