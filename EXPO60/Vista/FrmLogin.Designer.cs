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
            this.label8 = new System.Windows.Forms.Label();
            this.btbAcceder = new System.Windows.Forms.Button();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.picvisible = new System.Windows.Forms.PictureBox();
            this.picocultar = new System.Windows.Forms.PictureBox();
            this.btncontinuar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(326, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ingresar su Usuario";
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
            this.txtContra.MaxLength = 30;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(286, 20);
            this.txtContra.TabIndex = 10;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(329, 108);
            this.txtUsuario.MaxLength = 30;
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
            // btncontinuar
            // 
            this.btncontinuar.Activecolor = System.Drawing.Color.DarkRed;
            this.btncontinuar.BackColor = System.Drawing.Color.DarkRed;
            this.btncontinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncontinuar.BorderRadius = 0;
            this.btncontinuar.ButtonText = "                             Continuar";
            this.btncontinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncontinuar.DisabledColor = System.Drawing.Color.Gray;
            this.btncontinuar.Iconcolor = System.Drawing.Color.Transparent;
            this.btncontinuar.Iconimage = null;
            this.btncontinuar.Iconimage_right = null;
            this.btncontinuar.Iconimage_right_Selected = null;
            this.btncontinuar.Iconimage_Selected = null;
            this.btncontinuar.IconMarginLeft = 0;
            this.btncontinuar.IconMarginRight = 0;
            this.btncontinuar.IconRightVisible = true;
            this.btncontinuar.IconRightZoom = 0D;
            this.btncontinuar.IconVisible = true;
            this.btncontinuar.IconZoom = 90D;
            this.btncontinuar.IsTab = false;
            this.btncontinuar.Location = new System.Drawing.Point(228, 209);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Normalcolor = System.Drawing.Color.DarkRed;
            this.btncontinuar.OnHovercolor = System.Drawing.Color.DarkRed;
            this.btncontinuar.OnHoverTextColor = System.Drawing.Color.White;
            this.btncontinuar.selected = false;
            this.btncontinuar.Size = new System.Drawing.Size(241, 48);
            this.btncontinuar.TabIndex = 29;
            this.btncontinuar.Text = "                             Continuar";
            this.btncontinuar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncontinuar.Textcolor = System.Drawing.Color.White;
            this.btncontinuar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinuar.Visible = false;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Haz click en el boton continuar para crear tu usuario";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(618, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "A continuacion te mostraremos el formulario de primer uso para que crees uno";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(629, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Bienvenido a nuestro sistema  nos hemos dado cuenta  que no tienes un usuario";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Bienvenido a Imax Cinema";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 298);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtCifrado);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
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
        private Label label8;
        private Button btbAcceder;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private PictureBox picvisible;
        private PictureBox picocultar;
        private Bunifu.Framework.UI.BunifuFlatButton btncontinuar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}