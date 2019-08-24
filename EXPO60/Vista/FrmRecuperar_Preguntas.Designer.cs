namespace EXPO60.Vista
{
    partial class FrmRecuperar_Preguntas
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
            System.Windows.Forms.Label lblInformacion1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label lblInstrucciones3;
            System.Windows.Forms.Label lblInstruccion2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label lblUsuarios;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperar_Preguntas));
            this.toolStripRecuperar_Preguntas = new System.Windows.Forms.ToolStrip();
            this.lbltoolRecuperar_Preguntas = new System.Windows.Forms.ToolStripLabel();
            this.btntoolCerrar_Preguntas = new System.Windows.Forms.ToolStripButton();
            this.cmbPregunta3 = new System.Windows.Forms.ComboBox();
            this.cmbPregunta1 = new System.Windows.Forms.ComboBox();
            this.cmbPregunta2 = new System.Windows.Forms.ComboBox();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.separartorRecuperar_Contrasena = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtNuevo_Correo = new System.Windows.Forms.TextBox();
            this.txtNueva_Contrasena = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRecuperar = new Bunifu.Framework.UI.BunifuFlatButton();
            lblInformacion1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblInstrucciones3 = new System.Windows.Forms.Label();
            lblInstruccion2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblUsuarios = new System.Windows.Forms.Label();
            this.toolStripRecuperar_Preguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformacion1
            // 
            lblInformacion1.AutoSize = true;
            lblInformacion1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblInformacion1.Location = new System.Drawing.Point(281, 73);
            lblInformacion1.Name = "lblInformacion1";
            lblInformacion1.Size = new System.Drawing.Size(414, 12);
            lblInformacion1.TabIndex = 0;
            lblInformacion1.Text = "Seleccion las preguntas y repondelas para recuperar la contrasena:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(88, 345);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 12);
            label4.TabIndex = 0;
            label4.Text = "Nuevo Correo:";
            // 
            // lblInstrucciones3
            // 
            lblInstrucciones3.AutoSize = true;
            lblInstrucciones3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblInstrucciones3.Location = new System.Drawing.Point(117, 315);
            lblInstrucciones3.Name = "lblInstrucciones3";
            lblInstrucciones3.Size = new System.Drawing.Size(718, 12);
            lblInstrucciones3.TabIndex = 0;
            lblInstrucciones3.Text = "Si no es asi. Probablemente los datos estan erroneos, los datos no existen o hay " +
    "un problema con el envio de datos. ";
            // 
            // lblInstruccion2
            // 
            lblInstruccion2.AutoSize = true;
            lblInstruccion2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblInstruccion2.Location = new System.Drawing.Point(117, 293);
            lblInstruccion2.Name = "lblInstruccion2";
            lblInstruccion2.Size = new System.Drawing.Size(698, 12);
            lblInstruccion2.TabIndex = 0;
            lblInstruccion2.Text = "Si los datos fueron ingresados correctamente su nuevo correo y contrasena se most" +
    "raria en los cuadros de abajo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(88, 379);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 12);
            label1.TabIndex = 0;
            label1.Text = "Nueva Contrasena:";
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUsuarios.Location = new System.Drawing.Point(167, 30);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new System.Drawing.Size(139, 12);
            lblUsuarios.TabIndex = 0;
            lblUsuarios.Text = "Seleccione su usuario:";
            // 
            // toolStripRecuperar_Preguntas
            // 
            this.toolStripRecuperar_Preguntas.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripRecuperar_Preguntas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripRecuperar_Preguntas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbltoolRecuperar_Preguntas,
            this.btntoolCerrar_Preguntas});
            this.toolStripRecuperar_Preguntas.Location = new System.Drawing.Point(0, 405);
            this.toolStripRecuperar_Preguntas.Name = "toolStripRecuperar_Preguntas";
            this.toolStripRecuperar_Preguntas.Size = new System.Drawing.Size(960, 25);
            this.toolStripRecuperar_Preguntas.TabIndex = 0;
            this.toolStripRecuperar_Preguntas.Text = "toolStrip1";
            // 
            // lbltoolRecuperar_Preguntas
            // 
            this.lbltoolRecuperar_Preguntas.ForeColor = System.Drawing.Color.White;
            this.lbltoolRecuperar_Preguntas.Name = "lbltoolRecuperar_Preguntas";
            this.lbltoolRecuperar_Preguntas.Size = new System.Drawing.Size(131, 22);
            this.lbltoolRecuperar_Preguntas.Text = "Preguntas de seguridad";
            // 
            // btntoolCerrar_Preguntas
            // 
            this.btntoolCerrar_Preguntas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btntoolCerrar_Preguntas.BackColor = System.Drawing.Color.White;
            this.btntoolCerrar_Preguntas.Image = ((System.Drawing.Image)(resources.GetObject("btntoolCerrar_Preguntas.Image")));
            this.btntoolCerrar_Preguntas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntoolCerrar_Preguntas.Name = "btntoolCerrar_Preguntas";
            this.btntoolCerrar_Preguntas.Size = new System.Drawing.Size(186, 22);
            this.btntoolCerrar_Preguntas.Text = "Cerrar preguntas de seguridad";
            this.btntoolCerrar_Preguntas.Click += new System.EventHandler(this.BtntoolCerrar_Preguntas_Click);
            // 
            // cmbPregunta3
            // 
            this.cmbPregunta3.FormattingEnabled = true;
            this.cmbPregunta3.Location = new System.Drawing.Point(12, 179);
            this.cmbPregunta3.Name = "cmbPregunta3";
            this.cmbPregunta3.Size = new System.Drawing.Size(420, 21);
            this.cmbPregunta3.TabIndex = 6;
            // 
            // cmbPregunta1
            // 
            this.cmbPregunta1.FormattingEnabled = true;
            this.cmbPregunta1.Location = new System.Drawing.Point(12, 101);
            this.cmbPregunta1.Name = "cmbPregunta1";
            this.cmbPregunta1.Size = new System.Drawing.Size(420, 21);
            this.cmbPregunta1.TabIndex = 2;
            // 
            // cmbPregunta2
            // 
            this.cmbPregunta2.FormattingEnabled = true;
            this.cmbPregunta2.Location = new System.Drawing.Point(12, 140);
            this.cmbPregunta2.Name = "cmbPregunta2";
            this.cmbPregunta2.Size = new System.Drawing.Size(420, 21);
            this.cmbPregunta2.TabIndex = 4;
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.Location = new System.Drawing.Point(438, 179);
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(510, 20);
            this.txtRespuesta3.TabIndex = 7;
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Location = new System.Drawing.Point(438, 140);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(510, 20);
            this.txtRespuesta2.TabIndex = 5;
            this.txtRespuesta2.TextChanged += new System.EventHandler(this.TextBox15_TextChanged);
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Location = new System.Drawing.Point(438, 101);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(510, 20);
            this.txtRespuesta1.TabIndex = 3;
            this.txtRespuesta1.TextChanged += new System.EventHandler(this.TextBox13_TextChanged);
            // 
            // separartorRecuperar_Contrasena
            // 
            this.separartorRecuperar_Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.separartorRecuperar_Contrasena.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.separartorRecuperar_Contrasena.LineThickness = 1;
            this.separartorRecuperar_Contrasena.Location = new System.Drawing.Point(12, 269);
            this.separartorRecuperar_Contrasena.Name = "separartorRecuperar_Contrasena";
            this.separartorRecuperar_Contrasena.Size = new System.Drawing.Size(936, 21);
            this.separartorRecuperar_Contrasena.TabIndex = 28;
            this.separartorRecuperar_Contrasena.Transparency = 255;
            this.separartorRecuperar_Contrasena.Vertical = false;
            // 
            // txtNuevo_Correo
            // 
            this.txtNuevo_Correo.Location = new System.Drawing.Point(237, 341);
            this.txtNuevo_Correo.MaxLength = 125;
            this.txtNuevo_Correo.Name = "txtNuevo_Correo";
            this.txtNuevo_Correo.ReadOnly = true;
            this.txtNuevo_Correo.Size = new System.Drawing.Size(594, 20);
            this.txtNuevo_Correo.TabIndex = 0;
            // 
            // txtNueva_Contrasena
            // 
            this.txtNueva_Contrasena.Location = new System.Drawing.Point(237, 375);
            this.txtNueva_Contrasena.MaxLength = 125;
            this.txtNueva_Contrasena.Name = "txtNueva_Contrasena";
            this.txtNueva_Contrasena.ReadOnly = true;
            this.txtNueva_Contrasena.Size = new System.Drawing.Size(594, 20);
            this.txtNueva_Contrasena.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(545, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnRecuperar.BackColor = System.Drawing.Color.DarkRed;
            this.btnRecuperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecuperar.BorderRadius = 0;
            this.btnRecuperar.ButtonText = "Enviar Informacion";
            this.btnRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperar.DisabledColor = System.Drawing.Color.Maroon;
            this.btnRecuperar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecuperar.Iconimage = global::EXPO60.Properties.Resources.arrows_long_right_96px;
            this.btnRecuperar.Iconimage_right = null;
            this.btnRecuperar.Iconimage_right_Selected = null;
            this.btnRecuperar.Iconimage_Selected = null;
            this.btnRecuperar.IconMarginLeft = 0;
            this.btnRecuperar.IconMarginRight = 0;
            this.btnRecuperar.IconRightVisible = true;
            this.btnRecuperar.IconRightZoom = 0D;
            this.btnRecuperar.IconVisible = true;
            this.btnRecuperar.IconZoom = 90D;
            this.btnRecuperar.IsTab = false;
            this.btnRecuperar.Location = new System.Drawing.Point(342, 215);
            this.btnRecuperar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnRecuperar.OnHovercolor = System.Drawing.Color.White;
            this.btnRecuperar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnRecuperar.selected = false;
            this.btnRecuperar.Size = new System.Drawing.Size(277, 48);
            this.btnRecuperar.TabIndex = 8;
            this.btnRecuperar.Text = "Enviar Informacion";
            this.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecuperar.Textcolor = System.Drawing.Color.White;
            this.btnRecuperar.TextFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmRecuperar_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 430);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.separartorRecuperar_Contrasena);
            this.Controls.Add(this.txtNueva_Contrasena);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtNuevo_Correo);
            this.Controls.Add(label4);
            this.Controls.Add(lblInstrucciones3);
            this.Controls.Add(lblInstruccion2);
            this.Controls.Add(this.cmbPregunta3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbPregunta1);
            this.Controls.Add(this.cmbPregunta2);
            this.Controls.Add(this.txtRespuesta3);
            this.Controls.Add(this.txtRespuesta2);
            this.Controls.Add(this.txtRespuesta1);
            this.Controls.Add(lblUsuarios);
            this.Controls.Add(lblInformacion1);
            this.Controls.Add(this.toolStripRecuperar_Preguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecuperar_Preguntas";
            this.Text = "FrmRecuperar_Preguntas";
            this.toolStripRecuperar_Preguntas.ResumeLayout(false);
            this.toolStripRecuperar_Preguntas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripRecuperar_Preguntas;
        private System.Windows.Forms.ToolStripLabel lbltoolRecuperar_Preguntas;
        private System.Windows.Forms.ToolStripButton btntoolCerrar_Preguntas;
        private System.Windows.Forms.ComboBox cmbPregunta3;
        private System.Windows.Forms.ComboBox cmbPregunta1;
        private System.Windows.Forms.ComboBox cmbPregunta2;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecuperar;
        private Bunifu.Framework.UI.BunifuSeparator separartorRecuperar_Contrasena;
        private System.Windows.Forms.TextBox txtNuevo_Correo;
        private System.Windows.Forms.TextBox txtNueva_Contrasena;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}