using EXPO60.Controlador;
using EXPO60.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPO60.Vista
{
    public partial class FrmTicket : Form
    {
        public FrmTicket()
        {
            InitializeComponent();
        }
        ConstructorTickets agr = new ConstructorTickets();
        public void mostrarCombo()
        {

            cmbUsuario.DataSource = FuncionesTickets.obtenerUsuario();
            cmbUsuario.DisplayMember = "USUARIO";
            cmbUsuario.ValueMember = "ID_USUARIO";

        }
        private void FrmTicket_Load(object sender, EventArgs e)
        {
            mostrarCombo();
        }
        public void agregarticketss()
        {
            if (txtFecha.Text.Trim()=="")
            {
                MessageBox.Show("Complete todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                agr.fecha = txtFecha.Text;
                agr.usuario = Convert.ToInt16(cmbUsuario.SelectedValue);
                int datos = FuncionesTickets.ingresarticket(agr);
            }
        }

    }
}
