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
        public FrmTicket()
        {
            InitializeComponent();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        void LimpiarCampos()
        {
            txtbuscar.Clear();
        }
        void AgregarTicket()
        {
            DateTime fecha = DateTime.Today.AddDays(15);
            if (dateTimePicker1.Value.Date > fecha)
            {
                MessageBox.Show("La fecha ingresada esta fuera del rango permitido", "Fecha superior", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (dateTimePicker1.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("La fecha ingresada es menor a la de hoy", "La fecha es erronea", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                }
            }
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
