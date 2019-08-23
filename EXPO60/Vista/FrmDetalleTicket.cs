using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void grpDetalleTicket_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDetalleTicket_Load(object sender, EventArgs e)
        {
            cmbfuncion.DataSource = FuncionesDetalleTicket.funcion();
            cmbfuncion.DisplayMember = "hora";
            cmbfuncion.ValueMember = "id_funcion";

            cmbAsiento.DataSource = FuncionesDetalleTicket.asiento();
            cmbAsiento.DisplayMember = "id_num";
            cmbAsiento.ValueMember = "id_asiento";
        }
    }
}
