using System.Drawing;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkPrimerUso = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btbAcceder = new System.Windows.Forms.Button();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.picvisible = new System.Windows.Forms.PictureBox();
            this.picocultar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picocultar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.linkPrimerUso);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 298);
            this.panel1.TabIndex = 0;
            // 
            // linkPrimerUso
            // 
            this.linkPrimerUso.AutoSize = true;
            this.linkPrimerUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPrimerUso.LinkColor = System.Drawing.Color.White;
            this.linkPrimerUso.Location = new System.Drawing.Point(84, 258);
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
            // txtCifrado
            // 
            this.txtCifrado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCifrado.Location = new System.Drawing.Point(269, 141);
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.ShortcutsEnabled = false;
            this.txtCifrado.Size = new System.Drawing.Size(30, 20);
            this.txtCifrado.TabIndex = 4;
            this.txtCifrado.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(528, 258);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Recuperar Contraseña\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(404, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(326, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingresar su Usuario";
            // 
            // btbAcceder
            // 
            this.btbAcceder.Location = new System.Drawing.Point(408, 209);
            this.btbAcceder.Name = "btbAcceder";
            this.btbAcceder.Size = new System.Drawing.Size(133, 29);
            this.btbAcceder.TabIndex = 11;
            this.btbAcceder.Text = "Acceder";
            this.btbAcceder.UseVisualStyleBackColor = true;
            this.btbAcceder.Click += new System.EventHandler(this.btbAcceder_Click_1);
            // 
            // txtContra
            // 
            this.txtContra.ForeColor = System.Drawing.Color.Black;
            this.txtContra.Location = new System.Drawing.Point(329, 164);
            this.txtContra.MaxLength = 25;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(286, 20);
            this.txtContra.TabIndex = 10;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(329, 108);
            this.txtUsuario.MaxLength = 25;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(286, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // picvisible
            // 
            this.picvisible.Image = ((System.Drawing.Image)(resources.GetObject("picvisible.Image")));
            this.picvisible.Location = new System.Drawing.Point(621, 164);
            this.picvisible.Name = "picvisible";
            this.picvisible.Size = new System.Drawing.Size(38, 20);
            this.picvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picvisible.TabIndex = 12;
            this.picvisible.TabStop = false;
            this.picvisible.Click += new System.EventHandler(this.picvisible_Click);
            // 
            // picocultar
            // 
            this.picocultar.Image = ((System.Drawing.Image)(resources.GetObject("picocultar.Image")));
            this.picocultar.Location = new System.Drawing.Point(621, 164);
            this.picocultar.Name = "picocultar";
            this.picocultar.Size = new System.Drawing.Size(38, 20);
            this.picocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picocultar.TabIndex = 13;
            this.picocultar.TabStop = false;
            this.picocultar.Click += new System.EventHandler(this.picocultar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 298);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtCifrado);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbAcceder);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picvisible);
            this.Controls.Add(this.picocultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picvisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picocultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkPrimerUso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TextBox txtCifrado;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btbAcceder;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private PictureBox picvisible;
        private PictureBox picocultar;
    }
}