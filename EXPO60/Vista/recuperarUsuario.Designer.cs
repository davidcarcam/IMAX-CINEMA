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
            System.Windows.Forms.Label lblinformacion;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label lblinformacion2;
            System.Windows.Forms.Label lblcodigo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recuperarUsuario));
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripRecuperar_Telefono = new System.Windows.Forms.ToolStrip();
            this.lbltoolRecuperar_Telefono = new System.Windows.Forms.ToolStripLabel();
            this.btntoolCerrar_Correo = new System.Windows.Forms.ToolStripButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnvalidar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnRecu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.separartorRecuperar_Contrasena = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            lblinformacion = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblinformacion2 = new System.Windows.Forms.Label();
            lblcodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.toolStripRecuperar_Telefono.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinformacion
            // 
            lblinformacion.AutoSize = true;
            lblinformacion.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblinformacion.Location = new System.Drawing.Point(249, 228);
            lblinformacion.Name = "lblinformacion";
            lblinformacion.Size = new System.Drawing.Size(454, 12);
            lblinformacion.TabIndex = 53;
            lblinformacion.Text = "Inserta el codigo que se te ha sido enviado a tu correo revisa tu bandeja ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(116, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 12);
            label1.TabIndex = 52;
            label1.Text = "Inserte su Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(233, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(540, 12);
            label3.TabIndex = 51;
            label3.Text = "En el proximo espacio escriba el usuario de recuperacion que inserto al crear su " +
    "usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(331, 17);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(344, 18);
            label5.TabIndex = 50;
            label5.Text = "Recuperacion por correo de recuperacion";
            // 
            // lblinformacion2
            // 
            lblinformacion2.AutoSize = true;
            lblinformacion2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblinformacion2.Location = new System.Drawing.Point(144, 262);
            lblinformacion2.Name = "lblinformacion2";
            lblinformacion2.Size = new System.Drawing.Size(718, 12);
            lblinformacion2.TabIndex = 49;
            lblinformacion2.Text = "Si no es asi. Probablemente los datos estan erroneos, los datos no existen o hay " +
    "un problema con el envio de datos. ";
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblcodigo.Location = new System.Drawing.Point(116, 306);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new System.Drawing.Size(49, 12);
            lblcodigo.TabIndex = 48;
            lblcodigo.Text = "Codigo";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
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
            this.toolStripRecuperar_Telefono.TabIndex = 57;
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
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.btnvalidar);
            this.panelContenedor.Controls.Add(this.txtcodigo);
            this.panelContenedor.Controls.Add(lblcodigo);
            this.panelContenedor.Controls.Add(lblinformacion2);
            this.panelContenedor.Controls.Add(label5);
            this.panelContenedor.Controls.Add(label3);
            this.panelContenedor.Controls.Add(label1);
            this.panelContenedor.Controls.Add(lblinformacion);
            this.panelContenedor.Controls.Add(this.btnRecu);
            this.panelContenedor.Controls.Add(this.separartorRecuperar_Contrasena);
            this.panelContenedor.Controls.Add(this.toolStripRecuperar_Telefono);
            this.panelContenedor.Controls.Add(this.txtUsuario);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(960, 430);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnvalidar
            // 
            this.btnvalidar.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnvalidar.BackColor = System.Drawing.Color.DarkRed;
            this.btnvalidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvalidar.BorderRadius = 0;
            this.btnvalidar.ButtonText = "Validar Codigo";
            this.btnvalidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvalidar.DisabledColor = System.Drawing.Color.Maroon;
            this.btnvalidar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnvalidar.Iconimage = global::EXPO60.Properties.Resources.send_file_96px;
            this.btnvalidar.Iconimage_right = null;
            this.btnvalidar.Iconimage_right_Selected = null;
            this.btnvalidar.Iconimage_Selected = null;
            this.btnvalidar.IconMarginLeft = 0;
            this.btnvalidar.IconMarginRight = 0;
            this.btnvalidar.IconRightVisible = true;
            this.btnvalidar.IconRightZoom = 0D;
            this.btnvalidar.IconVisible = true;
            this.btnvalidar.IconZoom = 90D;
            this.btnvalidar.IsTab = false;
            this.btnvalidar.Location = new System.Drawing.Point(368, 328);
            this.btnvalidar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnvalidar.OnHovercolor = System.Drawing.Color.White;
            this.btnvalidar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnvalidar.selected = false;
            this.btnvalidar.Size = new System.Drawing.Size(277, 48);
            this.btnvalidar.TabIndex = 58;
            this.btnvalidar.Text = "Validar Codigo";
            this.btnvalidar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnvalidar.Textcolor = System.Drawing.Color.White;
            this.btnvalidar.TextFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidar.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(251, 302);
            this.txtcodigo.MaxLength = 5;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(504, 20);
            this.txtcodigo.TabIndex = 47;
            // 
            // btnRecu
            // 
            this.btnRecu.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnRecu.BackColor = System.Drawing.Color.DarkRed;
            this.btnRecu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecu.BorderRadius = 0;
            this.btnRecu.ButtonText = "Enviar Correo";
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
            this.btnRecu.Location = new System.Drawing.Point(368, 140);
            this.btnRecu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRecu.Name = "btnRecu";
            this.btnRecu.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnRecu.OnHovercolor = System.Drawing.Color.White;
            this.btnRecu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnRecu.selected = false;
            this.btnRecu.Size = new System.Drawing.Size(277, 48);
            this.btnRecu.TabIndex = 56;
            this.btnRecu.Text = "Enviar Correo";
            this.btnRecu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecu.Textcolor = System.Drawing.Color.White;
            this.btnRecu.TextFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecu.Click += new System.EventHandler(this.btnRecu_Click);
            // 
            // separartorRecuperar_Contrasena
            // 
            this.separartorRecuperar_Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.separartorRecuperar_Contrasena.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.separartorRecuperar_Contrasena.LineThickness = 1;
            this.separartorRecuperar_Contrasena.Location = new System.Drawing.Point(12, 204);
            this.separartorRecuperar_Contrasena.Name = "separartorRecuperar_Contrasena";
            this.separartorRecuperar_Contrasena.Size = new System.Drawing.Size(936, 21);
            this.separartorRecuperar_Contrasena.TabIndex = 54;
            this.separartorRecuperar_Contrasena.Transparency = 255;
            this.separartorRecuperar_Contrasena.Vertical = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(251, 91);
            this.txtUsuario.MaxLength = 60;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(504, 20);
            this.txtUsuario.TabIndex = 55;
            // 
            // recuperarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 430);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "recuperarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "recuperarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.toolStripRecuperar_Telefono.ResumeLayout(false);
            this.toolStripRecuperar_Telefono.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnvalidar;
        private System.Windows.Forms.TextBox txtcodigo;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecu;
        private Bunifu.Framework.UI.BunifuSeparator separartorRecuperar_Contrasena;
        private System.Windows.Forms.ToolStrip toolStripRecuperar_Telefono;
        private System.Windows.Forms.ToolStripLabel lbltoolRecuperar_Telefono;
        private System.Windows.Forms.ToolStripButton btntoolCerrar_Correo;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}