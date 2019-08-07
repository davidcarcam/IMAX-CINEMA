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
    public partial class Frmfacturalocal : Form
    {
        public Frmfacturalocal()
        {
            InitializeComponent();
        }
        public void ValidacionesNombre(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = true;
            }

            else if (e.KeyChar.ToString().Equals("'"))
            {
                e.Handled = true;
            }
            else if (e.KeyChar.ToString().Equals(","))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNombre(e);
        }

        private void txtPAgo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNombre(e);
        }
    }
}
