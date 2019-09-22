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
        Form currentForm;
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Buscar la coleccion del formulario
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panelContenedor.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }

        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            foreach (var control in panelContenedor.Controls)
            {
                if (control is ConfirmarContraseña)
                {

                }
                else if (control is FrmLogin)
                {

                }
                else if (control is FrmMetodos_Recuperar)
                {

                }
                else
                {

                }
            }
        }
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
            txtUsuario.Clear();
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
        private void BtntoolCerrar_Correo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }
        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtcodigo.Text.Contains('.'))
                {
                    if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        try
                        {
                            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.')
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                e.Handled = true;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else if (e.KeyChar == '.' && txtcodigo.Text.Trim() == "")
                {
                    e.Handled = true;
                }
                else
                {
                    try
                    {
                        if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.')
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error Critico.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRecu_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Complete el campo de usuario", "Llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //try
                //{
                Recovery user = new Recovery();
                ContructorLogin2.usuario = txtUsuario.Text;
                var result = user.recovery(ContructorLogin2.usuario);
                txtcodigo.Enabled = true;
                btnvalidar.Enabled = true;
                //}
                //catch (Exception)
                //{

                //    MessageBox.Show("Error al enviar el correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error al enviar el correo electronico");
            //}
        }
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() == "")
            {
                MessageBox.Show("campos vacios", "Llene los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ContructorLogin2 cons = new ContructorLogin2();
                cons.cod = Convert.ToInt32(txtcodigo.Text);
                bool datos = ValidarLogin.validarcod(cons);
                if (datos == true)
                {
                    ConfirmarContraseña kk = new ConfirmarContraseña();
                    kk.Show();
                    this.Hide();
                }
            }
        }       
    }
}
