namespace EXPO60.Vista
{
    partial class recuperarUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label lblInformacion3;
            System.Windows.Forms.Label labelInformacion2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recuperarUsuario));
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtusuarioRecuperar = new System.Windows.Forms.TextBox();
            this.txtNueva_Contrasena = new System.Windows.Forms.TextBox();
            this.txtNuevo_Correo = new System.Windows.Forms.TextBox();
            this.separartorRecuperar_Contrasena = new Bunifu.Framework.UI.BunifuSeparator();
            this.toolStripRecuperar_Telefono = new System.Windows.Forms.ToolStrip();
            this.lbltoolRecuperar_Telefono = new System.Windows.Forms.ToolStripLabel();
            this.btntoolCerrar_Correo = new System.Windows.Forms.ToolStripButton();
            this.btnRecu = new Bunifu.Framework.UI.BunifuFlatButton();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblInformacion3 = new System.Windows.Forms.Label();
            labelInformacion2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.toolStripRecuperar_Telefono.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(129, 358);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 12);
            label2.TabIndex = 0;
            label2.Text = "Nueva Contrasena:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(129, 316);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 12);
            label4.TabIndex = 0;
            label4.Text = "Nuevo Correo:";
            // 
            // lblInformacion3
            // 
            lblInformacion3.AutoSize = true;
            lblInformacion3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblInformacion3.Location = new System.Drawing.Point(144, 279);
            lblInformacion3.Name = "lblInformacion3";
            lblInformacion3.Size = new System.Drawing.Size(718, 12);
            lblInformacion3.TabIndex = 0;
            lblInformacion3.Text = "Si no es asi. Probablemente los datos estan erroneos, los datos no existen o hay " +
    "un problema con el envio de datos. ";
            // 
            // labelInformacion2
            // 
            labelInformacion2.AutoSize = true;
            labelInformacion2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelInformacion2.Location = new System.Drawing.Point(154, 254);
            labelInformacion2.Name = "labelInformacion2";
            labelInformacion2.Size = new System.Drawing.Size(698, 12);
            labelInformacion2.TabIndex = 0;
            labelInformacion2.Text = "Si los datos fueron ingresados correctamente su nuevo correo y contrasena se most" +
    "raria en los cuadros de abajo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(164, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(214, 12);
            label1.TabIndex = 0;
            label1.Text = "Inserte su correo de recuperacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(233, 71);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(540, 12);
            label3.TabIndex = 0;
            label3.Text = "En el proximo espacio escriba el usuario de recuperacion que inserto al crear su " +
    "usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(331, 34);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(344, 18);
            label5.TabIndex = 0;
            label5.Text = "Recuperacion por correo de recuperacion";
            label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // txtusuarioRecuperar
            // 
            this.txtusuarioRecuperar.Location = new System.Drawing.Point(420, 108);
            this.txtusuarioRecuperar.MaxLength = 100;
            this.txtusuarioRecuperar.Name = "txtusuarioRecuperar";
            this.txtusuarioRecuperar.Size = new System.Drawing.Size(504, 20);
            this.txtusuarioRecuperar.TabIndex = 1;
            this.txtusuarioRecuperar.TextChanged += new System.EventHandler(this.txtusuarioRecuperar_TextChanged);
            // 
            // txtNueva_Contrasena
            // 
            this.txtNueva_Contrasena.Location = new System.Drawing.Point(278, 354);
            this.txtNueva_Contrasena.MaxLength = 125;
            this.txtNueva_Contrasena.Name = "txtNueva_Contrasena";
            this.txtNueva_Contrasena.ReadOnly = true;
            this.txtNueva_Contrasena.Size = new System.Drawing.Size(594, 20);
            this.txtNueva_Contrasena.TabIndex = 0;
            // 
            // txtNuevo_Correo
            // 
            this.txtNuevo_Correo.Location = new System.Drawing.Point(278, 312);
            this.txtNuevo_Correo.MaxLength = 125;
            this.txtNuevo_Correo.Name = "txtNuevo_Correo";
            this.txtNuevo_Correo.ReadOnly = true;
            this.txtNuevo_Correo.Size = new System.Drawing.Size(594, 20);
            this.txtNuevo_Correo.TabIndex = 0;
            // 
            // separartorRecuperar_Contrasena
            // 
            this.separartorRecuperar_Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.separartorRecuperar_Contrasena.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.separartorRecuperar_Contrasena.LineThickness = 1;
            this.separartorRecuperar_Contrasena.Location = new System.Drawing.Point(12, 221);
            this.separartorRecuperar_Contrasena.Name = "separartorRecuperar_Contrasena";
            this.separartorRecuperar_Contrasena.Size = new System.Drawing.Size(936, 21);
            this.separartorRecuperar_Contrasena.TabIndex = 0;
            this.separartorRecuperar_Contrasena.Transparency = 255;
            this.separartorRecuperar_Contrasena.Vertical = false;
            // 
            // toolStripRecuperar_Telefono
            // 
            this.toolStripRecuperar_Telefono.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripRecuperar_Telefono.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripRecuperar_Telefono.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbltoolRecuperar_Telefono,
            this.btntoolCerrar_Correo});
            this.toolStripRecuperar_Telefono.Location = new System.Drawing.Point(0, 405);
            this.toolStripRecuperar_Telefono.Name = "toolStripRecuperar_Telefono";
            this.toolStripRecuperar_Telefono.Size = new System.Drawing.Size(960, 25);
            this.toolStripRecuperar_Telefono.TabIndex = 45;
            this.toolStripRecuperar_Telefono.Text = "toolStrip1";
            // 
            // lbltoolRecuperar_Telefono
            // 
            this.lbltoolRecuperar_Telefono.ForeColor = System.Drawing.Color.White;
            this.lbltoolRecuperar_Telefono.Name = "lbltoolRecuperar_Telefono";
            this.lbltoolRecuperar_Telefono.Size = new System.Drawing.Size(131, 22);
            this.lbltoolRecuperar_Telefono.Text = "Preguntas de seguridad";
            // 
            // btntoolCerrar_Correo
            // 
            this.btntoolCerrar_Correo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btntoolCerrar_Correo.BackColor = System.Drawing.Color.White;
            this.btntoolCerrar_Correo.Image = ((System.Drawing.Image)(resources.GetObject("btntoolCerrar_Correo.Image")));
            this.btntoolCerrar_Correo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntoolCerrar_Correo.Name = "btntoolCerrar_Correo";
            this.btntoolCerrar_Correo.Size = new System.Drawing.Size(184, 22);
            this.btntoolCerrar_Correo.Text = "Cerrar correo de recuperacion";
            this.btntoolCerrar_Correo.Click += new System.EventHandler(this.BtntoolCerrar_Correo_Click);
            // 
            // btnRecu
            // 
            this.btnRecu.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnRecu.BackColor = System.Drawing.Color.DarkRed;
            this.btnRecu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecu.BorderRadius = 0;
            this.btnRecu.ButtonText = "Enviar Datos";
            this.btnRecu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecu.DisabledColor = System.Drawing.Color.Maroon;
            this.btnRecu.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecu.Iconimage = global::EXPO60.Properties.Resources.send_file_96px;
            this.btnRecu.Iconimage_right = null;
            this.btnRecu.Iconimage_right_Selected = null;
            this.btnRecu.Iconimage_Selected = null;
            this.btnRecu.IconMarginLeft = 0;
            this.btnRecu.IconMarginRight = 0;
            this.btnRecu.IconRightVisible = true;
            this.btnRecu.IconRightZoom = 0D;
            this.btnRecu.IconVisible = true;
            this.btnRecu.IconZoom = 90D;
            this.btnRecu.IsTab = false;
            this.btnRecu.Location = new System.Drawing.Point(368, 157);
            this.btnRecu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRecu.Name = "btnRecu";
            this.btnRecu.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnRecu.OnHovercolor = System.Drawing.Color.White;
            this.btnRecu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnRecu.selected = false;
            this.btnRecu.Size = new System.Drawing.Size(277, 48);
            this.btnRecu.TabIndex = 2;
            this.btnRecu.Text = "Enviar Datos";
            this.btnRecu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecu.Textcolor = System.Drawing.Color.White;
            this.btnRecu.TextFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecu.Click += new System.EventHandler(this.BtnRecuperar_Click);
            // 
            // recuperarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 430);
            this.Controls.Add(this.txtNueva_Contrasena);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtNuevo_Correo);
            this.Controls.Add(label4);
            this.Controls.Add(lblInformacion3);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(labelInformacion2);
            this.Controls.Add(this.btnRecu);
            this.Controls.Add(this.separartorRecuperar_Contrasena);
            this.Controls.Add(this.toolStripRecuperar_Telefono);
            this.Controls.Add(this.txtusuarioRecuperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "recuperarUsuario";
            this.Text = "recuperarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.toolStripRecuperar_Telefono.ResumeLayout(false);
            this.toolStripRecuperar_Telefono.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.TextBox txtusuarioRecuperar;
        private System.Windows.Forms.TextBox txtNueva_Contrasena;
        private System.Windows.Forms.TextBox txtNuevo_Correo;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecu;
        private Bunifu.Framework.UI.BunifuSeparator separartorRecuperar_Contrasena;
        private System.Windows.Forms.ToolStrip toolStripRecuperar_Telefono;
        private System.Windows.Forms.ToolStripLabel lbltoolRecuperar_Telefono;
        private System.Windows.Forms.ToolStripButton btntoolCerrar_Correo;
    }
}