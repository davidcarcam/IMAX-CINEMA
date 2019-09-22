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
using EXPO60.Reportes;

namespace EXPO60.Vista
{
    public partial class FrmAsientos : Form
    {
        Constructor_Asientos Actualizar = new Constructor_Asientos();
        Constructor_Asientos agregar = new Constructor_Asientos();
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
        public FrmAsientos()
        {
            InitializeComponent();
        }
        public void Mostrar_Asientos()
        {
            dgvAsientos.DataSource = Funciones_Asientos.Mostrar_Asientos();
            this.dgvAsientos.Columns[0].Visible = false;
        }
        public void Eliminar_Asiento()
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro seleccionado?", "Eliminacion de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Asientos.Eliminar_Asiento(Convert.ToInt16(txtID_Asiento.Text));
            }
            else
            {
                MessageBox.Show("Eliminacion de registro abortada", "Eliminacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Agregar_Asiento()
        {
            agregar.estado = Convert.ToInt16(cmbestado.SelectedValue);
           
            agregar.sala = Convert.ToInt16(cmbasiento.SelectedValue);
           
            int datos = Funciones_Asientos.Ingresar_Asientos(agregar);
        }
        public void Modificar_Asiento()
        {
            Actualizar.estado = Convert.ToInt16(cmbestado.SelectedValue);
       
            Actualizar.sala = Convert.ToInt16(cmbasiento.SelectedValue);
        
            Funciones_Asientos.Actualizar_Asiento(Actualizar);
        }
        void LimpiarCampos()
        {
            txtbuscar.Clear();            
        }
        private void FrmAsientos_Load(object sender, EventArgs e)
        {
            Mostrar_Asientos();
            this.dgvAsientos.Columns[0].Visible = false;
            btnActualizar_Asiento.Enabled = false;
            btnEliminar_Asiento.Enabled = false;

            cmbestado.DataSource = Funciones_Asientos.Estado_Asiento();
            cmbestado.DisplayMember = "estado_as";
            cmbestado.ValueMember = "id_estado_asiento";

            cmbsala.DataSource = Funciones_Asientos.Sala();
            cmbsala.DisplayMember = "num_sala";
            cmbsala.ValueMember = "id_sala";

            cmbasiento.DataSource = Funciones_Asientos.Mostrar_Asientos();
            cmbasiento.DisplayMember = "id_num ";
            cmbasiento.ValueMember = "num_asiento";

            cmbfila.DataSource = Funciones_Asientos.fila();
            cmbfila.DisplayMember = "id_fila";
            cmbfila.ValueMember = "fila";
        }
        private void BtnAgregar_Asiento_Click(object sender, EventArgs e)
        {
            Agregar_Asiento();
            Mostrar_Asientos();
        }
        private void BtnMostrar_Asientos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Mostrar_Asientos();
            btnAgregar_Asiento.Enabled = true;
            btnActualizar_Asiento.Enabled = false;
            btnEliminar_Asiento.Enabled = false;
        }
        private void BtnActualizar_Asiento_Click(object sender, EventArgs e)
        {
            Modificar_Asiento();
            Mostrar_Asientos();
            btnActualizar_Asiento.Enabled = false;
            btnAgregar_Asiento.Enabled = true;
            btnEliminar_Asiento.Enabled = false;
        }
        private void BtnEliminar_Asiento_Click(object sender, EventArgs e)
        {
            Eliminar_Asiento();
            Mostrar_Asientos();
            btnActualizar_Asiento.Enabled = false;
            btnAgregar_Asiento.Enabled = true;
            btnEliminar_Asiento.Enabled = false;
        }
        private void DgvAsientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = this.dgvAsientos.CurrentRow.Index;
            txtID_Asiento.Text = this.dgvAsientos[0, posicion].Value.ToString();
            cmbestado.Text = this.dgvAsientos[1, posicion].Value.ToString();    
            cmbasiento.Text = this.dgvAsientos[4, posicion].Value.ToString();
            btnActualizar_Asiento.Enabled = true;
            btnEliminar_Asiento.Enabled = true;
            btnAgregar_Asiento.Enabled = false;
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvAsientos.CurrentCell = null;
                foreach (DataGridViewRow r in dgvAsientos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvAsientos.Rows)
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
                Mostrar_Asientos();
            }
        }
        private void BtnAsientos_Click(object sender, EventArgs e)
        {
           
        }
    }
}
