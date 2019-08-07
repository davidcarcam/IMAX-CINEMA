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
    public partial class Frmalimentos : Form
    {
        public Frmalimentos()
        {
            InitializeComponent();
        }
        public void val_localalimentos(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
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
        public void val_telefono(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNobreLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            val_localalimentos(e);
        }

        private void txtTelefonoLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            val_telefono(e);
        }
    }
}
