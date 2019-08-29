using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXPO60.Controlador;
using EXPO60.Modelo;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace EXPO60.Vista
{
    public partial class recuperarUsuario : Form
    {
        private const Keys CopyKeys = Keys.Control | Keys.C;
        private const Keys PasteKeys = Keys.Control | Keys.V;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == CopyKeys) || (keyData == PasteKeys))
            {
                Clipboard.Clear();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        public recuperarUsuario()
        {
            InitializeComponent();
        }
        public void vaciarampos()
        {
            
            txtcorreo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        public static bool Email_Valido(String email) // Método para validar el Email ingresado
        {
            String validando;
            validando = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(email, validando))
            {
                if (Regex.Replace(email, validando, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }

        }

        private void txtusuarioRecuperar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmLogin principal = new FrmLogin();
            principal.Show();
            this.Hide();
        }
        public static bool VerificarCorreo(string recuper)
        {
            bool retorno = false;   
            List<constructorRecuperar> recu = new List<constructorRecuperar>();
            Random rd = new Random(DateTime.Now.Millisecond);
            int resetclave = rd.Next(100000, 999999);
            try
            {
                string query = "SELECT * FROM usuario WHERE correo = '" + recu + "'";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
                MySqlDataReader _reader = cmd.ExecuteReader();
                while (_reader.Read())
                {
                    constructorRecuperar leer = new constructorRecuperar();
                    leer.CORREO_USU = _reader.GetString(0);
                    System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                    msg.Subject = "Imax codigo";
                    msg.SubjectEncoding = System.Text.Encoding.UTF8;

                    msg.Body = "tu contraseña es:" +rd ;
                    msg.BodyEncoding = System.Text.Encoding.UTF8;
                    msg.IsBodyHtml = true;
                    msg.From = new System.Net.Mail.MailAddress("ayuda.imax@gmail.com");

                    System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                    cliente.Credentials = new System.Net.NetworkCredential("ayuda.imax@gmail.com", "Ricaldone2019");
                    cliente.Port = 587;
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com";//dominio
                    try
                    {
                        cliente.Send(msg);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error");                       
                    }

                }
                return retorno;       
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void BtnRecuperar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtntoolCerrar_Correo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
