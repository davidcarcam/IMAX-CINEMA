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
        public void Limpiar()
        {
            txtapellido.Clear();
            txtCifrado.Clear();
            txtclave.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();
            txtdocumento.Clear();
            txtid.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtusuario.Clear();

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
        ConstructorUsuarios act = new ConstructorUsuarios();
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
                agr.clave = txtCifrado.Text;
                agr.correo = txtcorreo.Text;
                agr.dui = txtdocumento.Text;

                agr.telefono = txttelefono.Text;
                agr.usuario = txtusuario.Text;
                agr.tipo = Convert.ToInt16(cmbTipoU.SelectedValue);
                agr.estado = Convert.ToInt16(cmbEstadoU.SelectedValue);
                int datos = FuncionUsuario.ingresarusuario(agr);
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
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            Mostrarusuarios();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            AgregarUsu();
            Mostrarusuarios();
        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            txtclave.UseSystemPasswordChar = true;
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtclave.Text.ToString());
            txtCifrado.Text = Hash(pass);
        }

        private void txtnombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtapellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar.ToString().Equals(".") || e.KeyChar.ToString().Equals(",") || e.KeyChar.ToString().Equals("#"))
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

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar.ToString().Equals(".") || e.KeyChar.ToString().Equals(",") || e.KeyChar.ToString().Equals("#"))
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
        public void Mostrarusuarios()
        {
            dgvusuarios.DataSource = FuncionUsuario.mostrarusuario();
            this.dgvusuarios.Columns[0].Visible = false;
            this.dgvusuarios.Columns[9].Visible = false;
            this.dgvusuarios.Columns[5].Visible = false;
            this.dgvusuarios.Columns[9].Visible = false;
            this.dgvusuarios.Columns[10].Visible = false;
            this.dgvusuarios.Columns[11].Visible = false;
        }

        private void dgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvusuarios.CurrentRow.Index;
            txtid.Text = dgvusuarios[0, posicion].Value.ToString();
            txtnombre.Text = dgvusuarios[1, posicion].Value.ToString();
            txtapellido.Text = dgvusuarios[2, posicion].Value.ToString();
            txtdireccion.Text = dgvusuarios[3, posicion].Value.ToString();
            txtcorreo.Text = dgvusuarios[4, posicion].Value.ToString();
            txtdocumento.Text = dgvusuarios[6, posicion].Value.ToString();
            txttelefono.Text = dgvusuarios[7, posicion].Value.ToString();
            txtusuario.Text = dgvusuarios[8, posicion].Value.ToString();
            txtclave.Text = dgvusuarios[9, posicion].Value.ToString();
            cmbEstadoU.Text = dgvusuarios[10, posicion].Value.ToString();
            cmbTipoU.Text = dgvusuarios[11, posicion].Value.ToString();
            btneliminar.Enabled = true;
            btnactualizar.Enabled = true;
            btnagregar.Enabled = false;
        }

        private void btnmostrar_Click_1(object sender, EventArgs e)
        {
            Mostrarusuarios();
            btnagregar.Enabled = true;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            Limpiar();
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public void actualizarusuario()
        {
            act.idusu = Convert.ToInt32(txtid.Text);
            act.nombre = txtnombre.Text;
            act.direccion = txtdireccion.Text;
            act.apellido = txtapellido.Text;
            act.clave = txtCifrado.Text;
            act.correo = txtcorreo.Text;
            act.dui = txtdocumento.Text;

            act.telefono = txttelefono.Text;
            act.usuario = txtusuario.Text;
            act.tipo = Convert.ToInt16(cmbTipoU.SelectedValue);
            act.estado = Convert.ToInt16(cmbEstadoU.SelectedValue);
            FuncionUsuario.actualizarusuario(act);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            actualizarusuario();
            Mostrarusuarios();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            Limpiar();
            btnagregar.Enabled = true;
        }
        public void EliminarUsu()
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FuncionUsuario.EliminarUsuarios(Convert.ToInt32(txtid.Text));

            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Limpiar();
            EliminarUsu();
            Mostrarusuarios();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void cmbEstadoU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }

}
  

