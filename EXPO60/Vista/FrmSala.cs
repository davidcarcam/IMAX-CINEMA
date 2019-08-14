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
    public partial class FrmSala : Form
    {
        Constructor_Salas Actualizar = new Constructor_Salas();
        Constructor_Salas agregar = new Constructor_Salas();
        private void FrmSala_Load(object sender, EventArgs e)
        {
            Mostrar_Salas();
            this.dgvSalas.Columns[0].Visible = false;
            btnActualizar_Sala.Enabled = false;
            btnEliminar_Sala.Enabled = false;


            cmbEstado_Sala.DataSource = Funciones_Salas.Estado_Sala();
            cmbEstado_Sala.DisplayMember = "estado_sala";
            cmbEstado_Sala.ValueMember = "id_estado_sala";
        }
        public FrmSala()
        {
            InitializeComponent();
        }
        public void Mostrar_Salas ()
        {
            dgvSalas.DataSource = Funciones_Salas.Mostrar_Salas();
        }
        public void Limpiar_Datos()
        {
            txtNumero_Sala.Clear();
            txtCapacidad_Sala.Clear();
        }
        public void Eliminar_Sala()
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro seleccionado?", "Eliminacion de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Salas.Eliminar_Salas(Convert.ToInt16(txtID_Sala.Text));
            }
            else
            {
                MessageBox.Show("Eliminacion de registro abortada","Eliminacion de registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void Agregar_Salas()
        {
            if (txtNumero_Sala.Text.Trim() == "" || cmbEstado_Sala.Text.Trim() == "" || txtCapacidad_Sala.Text.Trim() == "")
            {
                MessageBox.Show("Se han encontrado campos vacios, Completelos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregar.EstadoSala = Convert.ToInt16(cmbEstado_Sala.Text);
                agregar.CapacidadSala = txtCapacidad_Sala.Text;
                agregar.NumeroSala = txtNumero_Sala.Text;
            }
        }
        public void Modificar_Salas()
        {
            Actualizar.IDSala = Convert.ToInt32(txtID_Sala.Text);
            Actualizar.NumeroSala = txtNumero_Sala.Text;
            Actualizar.CapacidadSala = txtCapacidad_Sala.Text;
            Actualizar.EstadoSala = Convert.ToInt16(cmbEstado_Sala);
            Funciones_Salas.Actualizar_Sala(Actualizar);
        }
        private void BtnAgregar_Sala_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Agregar_Salas();
            Mostrar_Salas();
        }
        private void DgvSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvSalas.CurrentRow.Index;
            txtID_Sala.Text = this.dgvSalas[0, posicion].Value.ToString();
            txtNumero_Sala.Text = this.dgvSalas[1, posicion].Value.ToString();
            txtCapacidad_Sala.Text = this.dgvSalas[2, posicion].Value.ToString();
            cmbEstado_Sala.Text = this.dgvSalas[3, posicion].Value.ToString();
            btnActualizar_Sala.Enabled = true;
            btnEliminar_Sala.Enabled = true;
            btnAgregar_Sala.Enabled = false;
        }
        private void BtnMostrar_Salas_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Mostrar_Salas();
        }
        private void BtnActualizar_Salas_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            Modificar_Salas();
            btnActualizar_Sala.Enabled = false;
            btnAgregar_Sala.Enabled = true;
            btnEliminar_Sala.Enabled = false;
        }
        private void BtnEliminar_Salas_Click(object sender, EventArgs e)
        {
            Eliminar_Sala();
            Limpiar_Datos();
            Mostrar_Salas();
            btnActualizar_Sala.Enabled = false;
            btnAgregar_Sala.Enabled = true;
            btnEliminar_Sala.Enabled = false;
        }
        private void grpRegistro_Sala_Enter(object sender, EventArgs e)
        {

        }
        private void TxtNumero_Sala_Validated(object sender, EventArgs e)
        {
            if (txtNumero_Sala.Text.Trim() == "")
            {
                epError2.SetError(txtNumero_Sala, "Introduce el numero de la sala.");
                txtNumero_Sala.Focus();
            }
            else
            {
                epError2.Clear();
            }
        }
        private void TxtCapacidad_Sala_Validated(object sender, EventArgs e)
        {
            if (txtCapacidad_Sala.Text.Trim() == "")
            {
                epError2.SetError(txtCapacidad_Sala, "Introduce la capacidad de la sala.");
                txtCapacidad_Sala.Focus();
            }
            else
            {
                epError2.Clear();
            }
        }
        private void TxtNumero_Sala_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtNumero_Sala.Text.Contains('.'))
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
                else if (e.KeyChar == '.' && txtNumero_Sala.Text.Trim() == "")
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                // codigo para solo ingresar numeros usando codigo ASCII
                MessageBox.Show("Insertar solo numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        private void TxtCapacidad_Sala_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtCapacidad_Sala.Text.Contains('.'))
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
                else if (e.KeyChar == '.' && txtCapacidad_Sala.Text.Trim() == "")
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                // codigo para solo ingresar numeros usando codigo ASCII
                MessageBox.Show("Insertar solo numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}
