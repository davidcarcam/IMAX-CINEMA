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
    public partial class FrmRecuperar_Preguntas : Form
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
        public FrmRecuperar_Preguntas()
        {
            InitializeComponent();
        }

        private void BtntoolCerrar_Preguntas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
