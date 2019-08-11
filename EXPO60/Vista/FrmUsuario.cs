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
using EXPO60.Modelo;
using System.Windows.Forms;
using EXPO60.Controlador;
using System.Security.Cryptography;


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
        Constructor_primerUso agr = new Constructor_primerUso();
        public void mostrarET()
        {

            cmbTipoU.DataSource = FuncionUsuario.ObtenerTipoUsuario();
            cmbTipoU.DisplayMember = "tipo_usu";
            cmbTipoU.ValueMember = "id_tipo_usu";

            cmbEstadoU.DataSource = FuncionUsuario.ObtenerEstado();
            cmbEstadoU.DisplayMember = "estado_usu";
            cmbEstadoU.ValueMember = "id_estado_usu";

        }
        public void AgregarUsu()
        {
            if (txtapellido.Text.Trim() == "" || txtclave.Text.Trim() == "" || txtcorreo.Text.Trim() == ""
                || txtdireccion.Text.Trim() == "" || txtdocumento.Text.Trim() == ""
                || txtnombre.Text.Trim() == "" || txttelefono.Text.Trim() == "" || txtusuario.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agr.nombre = txtnombre.Text;
                agr.direccion = txtdireccion.Text;
                agr.apellido = txtapellido.Text;
                agr.clave = txtclave.Text;
                agr.correo = txtcorreo.Text;
                agr.dui = txtdocumento.Text;

                agr.telefono = txttelefono.Text;
                agr.usuario = txtusuario.Text;
                agr.tipo = Convert.ToInt16(cmbTipoU.SelectedValue);
                agr.estado = Convert.ToInt16(cmbEstadoU.SelectedValue);
                int datos = Funciones_primerUso.ingresarusuario(agr);
            }
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?","Pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                this.Close();
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            AgregarUsu();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            mostrarET();
        }
    }
  }

