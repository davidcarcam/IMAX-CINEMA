namespace EXPO60.Vista
{
    partial class FrmRecuperar_Telefono
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
            System.Windows.Forms.Label lblInstruccion1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label lblInformacion3;
            System.Windows.Forms.Label labelInformacion2;
            System.Windows.Forms.Label lblNumero;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecuperar_Telefono));
            this.separartorRecuperar_Contrasena = new Bunifu.Framework.UI.BunifuSeparator();
            this.toolStripRecuperar_Telefono = new System.Windows.Forms.ToolStrip();
            this.lbltoolRecuperar_Telefono = new System.Windows.Forms.ToolStripLabel();
            this.txtNueva_Contrasena = new System.Windows.Forms.TextBox();
            this.txtNuevo_Correo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnRecuperar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btntoolCerrar_Telefono = new System.Windows.Forms.ToolStripButton();
            lblInstruccion1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblInformacion3 = new System.Windows.Forms.Label();
            labelInformacion2 = new System.Windows.Forms.Label();
            lblNumero = new System.Windows.Forms.Label();
            this.toolStripRecuperar_Telefono.SuspendLayout();
            this.SuspendLayout();
            // 
            // separartorRecuperar_Contrasena
            // 
            this.separartorRecuperar_Contrasena.BackColor = System.Drawing.Color.Transparent;
            this.separartorRecuperar_Contrasena.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.separartorRecuperar_Contrasena.LineThickness = 1;
            this.separartorRecuperar_Contrasena.Location = new System.Drawing.Point(12, 218);
            this.separartorRecuperar_Contrasena.Name = "separartorRecuperar_Contrasena";
            this.separartorRecuperar_Contrasena.Size = new System.Drawing.Size(936, 21);
            this.separartorRecuperar_Contrasena.TabIndex = 37;
            this.separartorRecuperar_Contrasena.Transparency = 255;
            this.separartorRecuperar_Contrasena.Vertical = false;
            // 
            // lblInstruccion1
            // 
            lblInstruccion1.AutoSize = true;
            lblInstruccion1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblInstruccion1.Location = new System.Drawing.Point(58, 76);
            lblInstruccion1.Name = "lblInstruccion1";
            lblInstruccion1.Size = new System.Drawing.Size(816, 12);
            lblInstruccion1.TabIndex = 34;
            lblInstruccion1.Text = "Si los datos fueron ingresados correctamente se enviaria un mensaje con un codigo" +
    " de seguridad que debera escribir a continuacion:";
            // 
            // toolStripRecuperar_Telefono
            // 
            this.toolStripRecuperar_Telefono.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripRecuperar_Telefono.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripRecuperar_Telefono.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbltoolRecuperar_Telefono,
            this.btntoolCerrar_Telefono});
            this.toolStripRecuperar_Telefono.Location = new System.Drawing.Point(0, 405);
            this.toolStripRecuperar_Telefono.Name = "toolStripRecuperar_Telefono";
            this.toolStripRecuperar_Telefono.Size = new System.Drawing.Size(960, 25);
            this.toolStripRecuperar_Telefono.TabIndex = 29;
            this.toolStripRecuperar_Telefono.Text = "toolStrip1";
            // 
            // lbltoolRecuperar_Telefono
            // 
            this.lbltoolRecuperar_Telefono.ForeColor = System.Drawing.Color.White;
            this.lbltoolRecuperar_Telefono.Name = "lbltoolRecuperar_Telefono";
            this.lbltoolRecuperar_Telefono.Size = new System.Drawing.Size(131, 22);
            this.lbltoolRecuperar_Telefono.Text = "Preguntas de seguridad";
            // 
            // txtNueva_Contrasena
            // 
            this.txtNueva_Contrasena.Location = new System.Drawing.Point(239, 356);
            this.txtNueva_Contrasena.MaxLength = 125;
            this.txtNueva_Contrasena.Name = "txtNueva_Contrasena";
            this.txtNueva_Contrasena.ReadOnly = true;
            this.txtNueva_Contrasena.Size = new System.Drawing.Size(594, 20);
            this.txtNueva_Contrasena.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(90, 360);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 12);
            label1.TabIndex = 38;
            label1.Text = "Nueva Contrasena:";
            // 
            // txtNuevo_Correo
            // 
            this.txtNuevo_Correo.Location = new System.Drawing.Point(239, 314);
            this.txtNuevo_Correo.MaxLength = 125;
            this.txtNuevo_Correo.Name = "txtNuevo_Correo";
            this.txtNuevo_Correo.ReadOnly = true;
            this.txtNuevo_Correo.Size = new System.Drawing.Size(594, 20);
            this.txtNuevo_Correo.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(90, 318);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 12);
            label4.TabIndex = 39;
            label4.Text = "Nuevo Correo:";
            // 
            // lblInformacion3
            // 
            lblInformacion3.AutoSize = true;
            lblInformacion3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblInformacion3.Location = new System.Drawing.Point(115, 281);
            lblInformacion3.Name = "lblInformacion3";
            lblInformacion3.Size = new System.Drawing.Size(718, 12);
            lblInformacion3.TabIndex = 40;
            lblInformacion3.Text = "Si no es asi. Probablemente los datos estan erroneos, los datos no existen o hay " +
    "un problema con el envio de datos. ";
            // 
            // labelInformacion2
            // 
            labelInformacion2.AutoSize = true;
            labelInformacion2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelInformacion2.Location = new System.Drawing.Point(119, 256);
            labelInformacion2.Name = "labelInformacion2";
            labelInformacion2.Size = new System.Drawing.Size(698, 12);
            labelInformacion2.TabIndex = 41;
            labelInformacion2.Text = "Si los datos fueron ingresados correctamente su nuevo correo y contrasena se most" +
    "raria en los cuadros de abajo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(159, 116);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(615, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNumero.Location = new System.Drawing.Point(58, 36);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new System.Drawing.Size(320, 12);
            lblNumero.TabIndex = 34;
            lblNumero.Text = "Escriba el telefono de recuperacion a continuacion:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(416, 32);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(458, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Activecolor = System.Drawing.Color.DarkOrange;
            this.btnRecuperar.BackColor = System.Drawing.Color.DarkRed;
            this.btnRecuperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecuperar.BorderRadius = 0;
            this.btnRecuperar.ButtonText = "Enviar Mensaje";
            this.btnRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperar.DisabledColor = System.Drawing.Color.Maroon;
            this.btnRecuperar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecuperar.Iconimage = global::EXPO60.Properties.Resources.send_96px;
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
            this.btnRecuperar.Location = new System.Drawing.Point(328, 164);
            this.btnRecuperar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnRecuperar.OnHovercolor = System.Drawing.Color.White;
            this.btnRecuperar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnRecuperar.selected = false;
            this.btnRecuperar.Size = new System.Drawing.Size(277, 48);
            this.btnRecuperar.TabIndex = 3;
            this.btnRecuperar.Text = "Enviar Mensaje";
            this.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecuperar.Textcolor = System.Drawing.Color.White;
            this.btnRecuperar.TextFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btntoolCerrar_Telefono
            // 
            this.btntoolCerrar_Telefono.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btntoolCerrar_Telefono.BackColor = System.Drawing.Color.White;
            this.btntoolCerrar_Telefono.Image = ((System.Drawing.Image)(resources.GetObject("btntoolCerrar_Telefono.Image")));
            this.btntoolCerrar_Telefono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntoolCerrar_Telefono.Name = "btntoolCerrar_Telefono";
            this.btntoolCerrar_Telefono.Size = new System.Drawing.Size(194, 22);
            this.btntoolCerrar_Telefono.Text = "Cerrar telefono de recuperacion";
            this.btntoolCerrar_Telefono.Click += new System.EventHandler(this.BtntoolCerrar_Telefono_Click);
            // 
            // FrmRecuperar_Telefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 430);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNueva_Contrasena);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtNuevo_Correo);
            this.Controls.Add(label4);
            this.Controls.Add(lblInformacion3);
            this.Controls.Add(labelInformacion2);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.separartorRecuperar_Contrasena);
            this.Controls.Add(lblNumero);
            this.Controls.Add(lblInstruccion1);
            this.Controls.Add(this.toolStripRecuperar_Telefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecuperar_Telefono";
            this.Text = "FrmRecuperar_Telefono";
            this.toolStripRecuperar_Telefono.ResumeLayout(false);
            this.toolStripRecuperar_Telefono.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnRecuperar;
        private Bunifu.Framework.UI.BunifuSeparator separartorRecuperar_Contrasena;
        private System.Windows.Forms.ToolStrip toolStripRecuperar_Telefono;
        private System.Windows.Forms.ToolStripLabel lbltoolRecuperar_Telefono;
        private System.Windows.Forms.ToolStripButton btntoolCerrar_Telefono;
        private System.Windows.Forms.TextBox txtNueva_Contrasena;
        private System.Windows.Forms.TextBox txtNuevo_Correo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}