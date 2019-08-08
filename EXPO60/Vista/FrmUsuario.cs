using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace EXPO60.Vista
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
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

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnagregar_Click(object sender, EventArgs e)
        //{
        //    fucionesUsuarios(txtcorreo.Text);
        //    if (Email_Valido(txtcorreo.Text) == false)// llamado del metodo Email_Valido
        //    {
        //        error1.SetError(txtcorreo, " Ingrese un Email Válido");
        //        txtcorreo.Focus();
                
        //        return;
        //    }
        //    else
        //    {
        //        error1.Clear();
        //        //limpiar

        //    }

        //}

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
  }

