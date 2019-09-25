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

namespace EXPO60.Vista
{
    public partial class FrmBoleteria : Form
    {
        public FrmBoleteria()
        {
            InitializeComponent();
        }

        Constructor_DetalleTicket agregar = new Constructor_DetalleTicket();
        public void agregarTicket()
        {

            int precio, cantidad, subtotal;
            precio = int.Parse(txtprecio.Text);
            cantidad = int.Parse(txtcantidad.Text);
            subtotal = precio * cantidad;
            txtsubtotal.Text = subtotal.ToString();

            agregar.cantidad = txtcantidad.Text;
            agregar.subtotal = txtsubtotal.Text;
            agregar.funcion_titulo = txtFuncion_titulo.Text;
            agregar.hora = txthora.Text;
            agregar.dia = txtfecha.Text;
            agregar.clasifiacion = txtclasificacion.Text;
            agregar.sala = txtnumsala.Text;
            agregar.subtotal = txtsubtotal.Text;

            int datos = Funciones_DetalleTicket.insertarticket(agregar);
        }
        public void mostrarFunciones()
        {
            dgvfunciones.DataSource = Funciones_DetalleTicket.mostrarFunciones();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtprecio.Text == "")
            {
                MessageBox.Show("Seleccione una pelicula", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtcantidad.Text == "")
            {
                MessageBox.Show("Agregue la cantidad de boletos a comprar", "Falta la cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbDEsc.Text == "Estudiante")
            {

            }
            else
            {
                agregarTicket();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmBoleteria_Load(object sender, EventArgs e)
        {
           
            mostrarFunciones();
            dgvfunciones.Columns[0].Visible = false;
        }
    }
}
