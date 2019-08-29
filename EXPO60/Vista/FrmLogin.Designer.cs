﻿using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EXPO60.Vista
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbtnCerra_Aplicacion = new System.Windows.Forms.ToolStripButton();
            this.toollblLogin = new System.Windows.Forms.ToolStripLabel();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.linkPrimerUso = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btbAcceder = new System.Windows.Forms.Button();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.txtCifrado);
            this.panel1.Controls.Add(this.linkPrimerUso);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btbAcceder);
            this.panel1.Controls.Add(this.txtContra);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 298);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnCerra_Aplicacion,
            this.toollblLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStrip1_MouseDown);
            // 
            // toolbtnCerra_Aplicacion
            // 
            this.toolbtnCerra_Aplicacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolbtnCerra_Aplicacion.Image = global::EXPO60.Properties.Resources.cancel;
            this.toolbtnCerra_Aplicacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnCerra_Aplicacion.Name = "toolbtnCerra_Aplicacion";
            this.toolbtnCerra_Aplicacion.Size = new System.Drawing.Size(103, 22);
            this.toolbtnCerra_Aplicacion.Text = "Cerrar Sistema";
            this.toolbtnCerra_Aplicacion.Click += new System.EventHandler(this.ToolbtnCerra_Aplicacion_Click);
            // 
            // toollblLogin
            // 
            this.toollblLogin.Name = "toollblLogin";
            this.toollblLogin.Size = new System.Drawing.Size(75, 22);
            this.toollblLogin.Text = "Iniciar sesion";
            // 
            // txtCifrado
            // 
            this.txtCifrado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCifrado.Location = new System.Drawing.Point(250, 141);
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.Size = new System.Drawing.Size(30, 20);
            this.txtCifrado.TabIndex = 0;
            this.txtCifrado.Visible = false;
            this.txtCifrado.TextChanged += new System.EventHandler(this.txtCifrado_TextChanged);
            // 
            // linkPrimerUso
            // 
            this.linkPrimerUso.AutoSize = true;
            this.linkPrimerUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPrimerUso.LinkColor = System.Drawing.Color.White;
            this.linkPrimerUso.Location = new System.Drawing.Point(76, 258);
            this.linkPrimerUso.Name = "linkPrimerUso";
            this.linkPrimerUso.Size = new System.Drawing.Size(72, 16);
            this.linkPrimerUso.TabIndex = 0;
            this.linkPrimerUso.TabStop = true;
            this.linkPrimerUso.Text = "Primer uso";
            this.linkPrimerUso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrimerUso_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EXPO60.Properties.Resources.LogoDavid;
            this.pictureBox1.Location = new System.Drawing.Point(25, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(509, 258);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Recuperar Contraseña\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(306, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(307, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(307, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar su Usuario";
            // 
            // btbAcceder
            // 
            this.btbAcceder.Location = new System.Drawing.Point(389, 209);
            this.btbAcceder.Name = "btbAcceder";
            this.btbAcceder.Size = new System.Drawing.Size(133, 29);
            this.btbAcceder.TabIndex = 3;
            this.btbAcceder.Text = "Acceder";
            this.btbAcceder.UseVisualStyleBackColor = true;
            this.btbAcceder.Click += new System.EventHandler(this.btbAcceder_Click);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(310, 164);
            this.txtContra.MaxLength = 25;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(286, 20);
            this.txtContra.TabIndex = 2;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(310, 108);
            this.txtUsuario.MaxLength = 25;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(286, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 298);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkPrimerUso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbAcceder;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private TextBox txtCifrado;
        private ToolStrip toolStrip1;
        private ToolStripButton toolbtnCerra_Aplicacion;
        private ToolStripLabel toollblLogin;
    }
}