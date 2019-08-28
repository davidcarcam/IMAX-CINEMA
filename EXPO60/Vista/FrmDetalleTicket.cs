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
using EXPO60.Vista;
using MySql.Data.MySqlClient;

namespace EXPO60.Vista
{
    public partial class FrmDetalleTicket : Form
    {
        public FrmDetalleTicket()
        {
            InitializeComponent();
        }
        ConstructorDetalleTicket agregar = new ConstructorDetalleTicket();
        ConstructorDetalleTicket actualizar = new ConstructorDetalleTicket();
        public void mostrarPeliculas()
        {
            dgvtickets.DataSource =FuncionesDetalleTicket.MostrarTicket();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        private void grpDetalleTicket_Enter(object sender, EventArgs e)
        {

        }
        public void Mostrarcmb()
        {
            cmbfuncion.DataSource = FuncionesDetalleTicket.funcion();
            cmbfuncion.DisplayMember = "hora";
            cmbfuncion.ValueMember = "id_funcion";

            cmbAsiento.DataSource = FuncionesDetalleTicket.asiento();
            cmbAsiento.DisplayMember = "id_num";
            cmbAsiento.ValueMember = "id_asiento";
        }
       
        private void FrmDetalleTicket_Load(object sender, EventArgs e)
        {
            Mostrarcmb();
            this.dgvtickets.Columns[0].Visible = false;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }
        public void agregarDetalleTickt()
        {
            agregar.funcion = Convert.ToInt16(cmbfuncion.Text);
            agregar.asiento = Convert.ToInt16(cmbAsiento.Text);
            int datos = FuncionesDetalleTicket.IngresarDetalle(agregar);
        }    
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cmbfuncion.Text == "" || cmbfuncion.Text == "")
            {
                MessageBox.Show("Por favor rellena todos los campos que se te piden", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                agregarDetalleTickt();
                mostrarDetalleTicket();
                vaciarampos();
                            
            }
        }

        private void vaciarampos()
        {
            throw new NotImplementedException();
        }

        private void mostrarDetalleTicket()
        {
            throw new NotImplementedException();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Mostrarcmb();
        }
        public void eliminarRegistro()
        {
            if (MessageBox.Show("Esta seguro de realizar esta operacion?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_peliculas.eliminarPelicula(Convert.ToInt32(idDetalleTicket.Text));
            }

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
    }
}
