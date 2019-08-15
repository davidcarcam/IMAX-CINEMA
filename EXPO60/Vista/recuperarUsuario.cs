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

namespace EXPO60.Vista
{
    public partial class recuperarUsuario : Form
    {
        public recuperarUsuario()
        {
            InitializeComponent();
        }
        public void vaciarampos()
        {
            
            txtusuarioRecuperar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validarRecuperar.resetClave(txtusuarioRecuperar.Text);
            if (Email_Valido(txtusuarioRecuperar.Text) == false)// llamado del metodo Email_Valido
            {
                error1.SetError(txtusuarioRecuperar, " Ingrese un Email Válido");
                txtusuarioRecuperar.Focus();
                
                vaciarampos();
                return;
            }
            else
            {
                error1.Clear();
                
                vaciarampos();

            }

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
    }
}
