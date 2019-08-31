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
        void VerificarCorreo(string recuper)
        {
            List<constructorRecuperar> recu = new List<constructorRecuperar>();
            constructorRecuperar leer = new constructorRecuperar();
            Random rd = new Random(DateTime.Now.Millisecond);
            int resetclave = rd.Next(100000, 999999);
            try
            {
                string query = "SELECT * FROM usuario WHERE correo = '" + recuper + "'";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), Conexion.ObtenerConexion());
               

                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(recuper);
                msg.Subject = "Imax codigo";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;

                msg.Body = "tu contraseña es:" +resetclave ;
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
                    MessageBox.Show("Mensaje Enviado con exito.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");                       
                }

                              
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al momento de enviar el correo.","Error de conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }



        private void BtnRecuperar_Click(object sender, EventArgs e)
        {
            VerificarCorreo(txtcorreo.Text);
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
