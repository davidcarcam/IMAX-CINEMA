﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using EXPO60.Controlador;
using EXPO60.Modelo;
using System.Runtime.InteropServices;

namespace EXPO60.Vista
{
    public partial class FrmLogin : Form
    {
        #region Dlls para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        const int GRIP_SIZE = 15;
        int w = 0;
        int h = 0;
        #endregion
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
        public FrmLogin()
        {
            InitializeComponent();
        }
        public string Hash(byte[] val)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(val);
                return Convert.ToBase64String(hash);
            }
        }
        void Validar()
        {
            if (txtUsuario.Text.Trim() == "" || txtContra.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ContructorLogin2 log = new ContructorLogin2();
                ContructorLogin2.usuario = txtUsuario.Text;
                ContructorLogin2.clave = txtCifrado.Text;

                //Recuperando el valor de retorno
                bool datos = ValidarLogin.Acceso(log);
                //
                if (datos == true)
                {
                    if (ContructorLogin2.clave == "efAdsX436aQfSUcxfwNEbBolhN0=")
                    {
                        ConfirmarContraseña kk = new ConfirmarContraseña();
                        this.Hide();
                        kk.Show();
                    }
                    else
                    {
                        FrmNuevo principal = new FrmNuevo();
                        principal.Show();
                        this.Hide();
                    }
                }
                else
                {

                }
            }
        }
        private void linkPrimerUso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPrimerUso principal = new FrmPrimerUso();
            principal.Show();
            this.Hide();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (ValidarLogin.ValidarExistencia() == true)
            {
                txtUsuario.Visible = true;
                txtContra.Visible = true;
                btbAcceder.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                linkLabel1.Visible = true;
                bunifuFlatButton1.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                panel1.Visible = true;
                pictureBox1.Visible = true;
            }
            else if (ValidarLogin.ValidarExistencia() == false)
            {
                txtUsuario.Visible = false;
                txtContra.Visible = false;
                btbAcceder.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                linkLabel1.Visible = false;
                bunifuFlatButton1.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
            }
        }
        private void toolbtnCerra_Aplicacion_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btbAcceder_Click_1(object sender, EventArgs e)
        {
            Validar();
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMetodos_Recuperar recu = new FrmMetodos_Recuperar();
            recu.Show();
            this.Hide();
        }
        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(txtContra.Text.ToString());
            txtCifrado.Text = Hash(pass);
        }
        private void picvisible_Click(object sender, EventArgs e)
        {
            picocultar.Visible = true;
            txtContra.UseSystemPasswordChar = false;
            picvisible.Visible = false;
        }
        private void picocultar_Click(object sender, EventArgs e)
        {
            picocultar.Visible = false;
            txtContra.UseSystemPasswordChar = true;
            picvisible.Visible = true;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmPrimerUso kk = new FrmPrimerUso();
            kk.Show();
            this.Hide();
        }
    }
}
