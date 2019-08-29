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

        private void cmbusuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
