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

namespace EXPO60.Modelo
{
    class validarRecuperar
    {
        public static List<constructorRecuperar> resetClave(string user)
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            int resetclave = rd.Next(100000, 999999);
            List<constructorRecuperar> recu = new List<constructorRecuperar>();
            try
            {
                string query = "SELECT * FROM usuarios WHERE correo = '" + user + "'";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
                MySqlDataReader _reader = cmd.ExecuteReader();
                while (_reader.Read())
                {
                    constructorRecuperar leer = new constructorRecuperar();
                    leer.USUARIO_RE = _reader.GetString(0);
                    leer.CORREO_USU = _reader.GetString(1);
                    string query2 = "UPDATE usuarios SET clave = '" + resetclave + "' WHERE id_usuario = '" + _reader.GetInt32(0) + "'";
                    MySqlCommand cmd2 = new MySqlCommand(string.Format(query2), Conexion.ObtenerConexion());
                    int retorno = Convert.ToInt32(cmd2.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Usuario recuperado");
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario no recuperado");
                    }
                }

                return recu;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void EnviarCorreoContrasena(int contrasenaNueva, string correo)
        {
            string contraseña = "";
            string mensaje = string.Empty;
            //Creando el correo electronico
            string destinatario = correo;
            string remitente = "Rafael000716@hotmail.com";
            string asunto = "Nueva contraseña para IMAX";
            string cuerpoDelMesaje = "Su nueva contraseña es" + " " + Convert.ToString(contrasenaNueva);
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);


            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("Rafael000716@hotmail.com", contraseña);

            try
            {
                Task.Run(() =>
                {

                    smtp.Send(ms);
                    ms.Dispose();
                    MessageBox.Show("Correo enviado, sirvase revisar su bandeja de entrada");
                }
                );

                MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
            }
        }
        public string Contrasena
        {
            get
            { return "tu contraseña"; }
        }
    }
}
