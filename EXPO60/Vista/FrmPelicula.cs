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
using MySql.Data.MySqlClient;

namespace EXPO60.Vista
{
    public partial class FrmPelicula : Form
    {
        public FrmPelicula()
        {
            InitializeComponent();
        }
        Constructor_pelicula agregar = new Constructor_pelicula();
        Constructor_pelicula actualizar = new Constructor_pelicula();
        private const Keys CopyKeys = Keys.Control | Keys.C;
        private const Keys PasteKeys = Keys.Control | Keys.V;
        private string imagen = "";
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
        public void mostrarPeliculas()
        {
            dgvpeliculas.DataSource = Funciones_peliculas.mostrarPeliculas();
        }
        public void modificarRegistro()
        {
            actualizar.Titulo = txttitulo.Text;
            actualizar.Año = txtaño.Text;
            actualizar.Director = txtdirector.Text;
            actualizar.Idioma = Convert.ToInt16(cmbIdioma.SelectedValue);
            actualizar.tipo = Convert.ToInt16(cmbGenero.SelectedValue);
            actualizar.dimensiones = Convert.ToInt16(cmbDimensiones.SelectedValue);
            actualizar.estado = Convert.ToInt16(cmbestado.SelectedValue);
            Funciones_peliculas.actualizarPelicula(actualizar);
        }
        public void eliminarRegistro()
        {
            if (MessageBox.Show("Esta seguro de realizar esta operacion?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_peliculas.eliminarPelicula(Convert.ToInt32(idPelicula.Text));
            }
        }
        public void vaciarampos()
        {
            txttitulo.Clear();
            txtaño.Clear();
            txtdirector.Clear();
            pictureBox1.Image = null;
        }
        public void agregarPelicula()
        {
            agregar.Titulo = txttitulo.Text;
            agregar.Año = txtaño.Text;
            agregar.Director = txtdirector.Text;
            agregar.Idioma = Convert.ToInt16(cmbIdioma.SelectedValue);
            agregar.tipo = Convert.ToInt16(cmbGenero.SelectedValue);
            agregar.dimensiones = Convert.ToInt16(cmbDimensiones.SelectedValue);
            agregar.estado = Convert.ToInt16(cmbestado.SelectedValue);
            agregar.foto = imagen.Replace("\\","\\\\");
            int datos = Funciones_peliculas.insertarPelicula(agregar);
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        private void txtaudio_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtdirector_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txttitulo_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txttitulo.Text == "" || txtaño.Text == "")
            {
                MessageBox.Show("Por favor rellena todos los campos que se te piden", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregarPelicula();
                mostrarPeliculas();
                vaciarampos();
            }
        }
        private void FrmPelicula_Load(object sender, EventArgs e)
        {
            mostrarPeliculas();
            mostrarET();
            this.dgvpeliculas.Columns[0].Visible = false;
            this.dgvpeliculas.Columns[4].Visible = false;
            this.dgvpeliculas.Columns[5].Visible = false;
            this.dgvpeliculas.Columns[6].Visible = false;
            this.dgvpeliculas.Columns[7].Visible = false;
            this.dgvpeliculas.Columns["foto"].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarPeliculas();
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            modificarRegistro();
            vaciarampos();
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
            btnagregar.Enabled = true;
            mostrarPeliculas();
        }
        public void mostrarET()
        {

            cmbestado.DataSource = Funciones_peliculas.ObtenerEstadoPelicula();
            cmbestado.DisplayMember = "estado_pel";
            cmbestado.ValueMember = "id_estado_pelicula";


            cmbDimensiones.DataSource = Funciones_peliculas.ObtenerDimensiones();
            cmbDimensiones.DisplayMember = "formato";
            cmbDimensiones.ValueMember = "id_formatos";

            cmbGenero.DataSource = Funciones_peliculas.ObtenerGenero();
            cmbGenero.DisplayMember = "genero";
            cmbGenero.ValueMember = "id_genero";

            cmbIdioma.DataSource = Funciones_peliculas.ObtenerIdioma();
            cmbIdioma.DisplayMember = "idioma";
            cmbIdioma.ValueMember = "id_idioma";
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminarRegistro();
            vaciarampos();
            mostrarPeliculas();
            btnactualizar.Enabled = false;
            btnagregar.Enabled = true;
            btneliminar.Enabled = false;
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvpeliculas.CurrentCell = null;
                foreach (DataGridViewRow r in dgvpeliculas.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvpeliculas.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                mostrarPeliculas();
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            vaciarampos();
        }
        private void dgvpeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvpeliculas.CurrentRow.Index;
            idPelicula.Text = this.dgvpeliculas[0, posicion].Value.ToString();
            txttitulo.Text = this.dgvpeliculas[2, posicion].Value.ToString();
            txtaño.Text = this.dgvpeliculas[1, posicion].Value.ToString();
            txtdirector.Text = this.dgvpeliculas[3, posicion].Value.ToString();
            imagen = this.dgvpeliculas["foto", posicion].Value.ToString();
            pictureBox1.Image = Image.FromFile(imagen);
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
            btnagregar.Enabled = false;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            imagen = "";
            if (fileNuevo.ShowDialog() == DialogResult.OK)
            {
                imagen = fileNuevo.FileName;
                pictureBox1.Image = Image.FromFile(imagen);
            }
        }
    }
}
