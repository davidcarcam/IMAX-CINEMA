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
    public partial class FrmAsientos : Form
    {
        public FrmAsientos()
        {
            InitializeComponent();
        }
        public void valfila(KeyPressEventArgs e)
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
        public void valnum(KeyPressEventArgs e)
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            valfila(e);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            valnum(e);
        }
    }
}
