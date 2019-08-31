namespace EXPO60.Vista
{
    partial class FrmPrimerUso
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
            this.toolStripPrimer_Usuario = new System.Windows.Forms.ToolStrip();
            this.toollblPrimer_Usuario = new System.Windows.Forms.ToolStripLabel();
            this.toolbtnCerrar_Primer = new System.Windows.Forms.ToolStripButton();
            this.ofpPrimer_Usuario = new System.Windows.Forms.OpenFileDialog();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbEst = new System.Windows.Forms.ComboBox();
            this.btnIngUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtCla = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStripPrimer_Usuario.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripPrimer_Usuario
            // 
            this.toolStripPrimer_Usuario.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripPrimer_Usuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toollblPrimer_Usuario,
            this.toolbtnCerrar_Primer});
            this.toolStripPrimer_Usuario.Location = new System.Drawing.Point(0, 0);
            this.toolStripPrimer_Usuario.Name = "toolStripPrimer_Usuario";
            this.toolStripPrimer_Usuario.Size = new System.Drawing.Size(1025, 25);
            this.toolStripPrimer_Usuario.TabIndex = 38;
            this.toolStripPrimer_Usuario.Text = "toolStrip1";
            this.toolStripPrimer_Usuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripPrimer_Usuario_MouseDown);
            // 
            // toollblPrimer_Usuario
            // 
            this.toollblPrimer_Usuario.ForeColor = System.Drawing.Color.White;
            this.toollblPrimer_Usuario.Name = "toollblPrimer_Usuario";
            this.toollblPrimer_Usuario.Size = new System.Drawing.Size(228, 22);
            this.toollblPrimer_Usuario.Text = "Formulario de creacion del primer usuario";
            // 
            // toolbtnCerrar_Primer
            // 
            this.toolbtnCerrar_Primer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolbtnCerrar_Primer.BackColor = System.Drawing.Color.White;
            this.toolbtnCerrar_Primer.ForeColor = System.Drawing.Color.Black;
            this.toolbtnCerrar_Primer.Image = global::EXPO60.Properties.Resources.cancel;
            this.toolbtnCerrar_Primer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnCerrar_Primer.Name = "toolbtnCerrar_Primer";
            this.toolbtnCerrar_Primer.Size = new System.Drawing.Size(103, 22);
            this.toolbtnCerrar_Primer.Text = "Cerrar Sistema";
            this.toolbtnCerrar_Primer.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // ofpPrimer_Usuario
            // 
            this.ofpPrimer_Usuario.FileName = "Image";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.txtCifrado);
            this.panelContenedor.Controls.Add(this.cmbTip);
            this.panelContenedor.Controls.Add(this.cmbEst);
            this.panelContenedor.Controls.Add(this.btnIngUsuario);
            this.panelContenedor.Controls.Add(this.txtContra);
            this.panelContenedor.Controls.Add(this.txtCla);
            this.panelContenedor.Controls.Add(this.label13);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.label11);
            this.panelContenedor.Controls.Add(this.txtUsu);
            this.panelContenedor.Controls.Add(this.label10);
            this.panelContenedor.Controls.Add(this.label9);
            this.panelContenedor.Controls.Add(this.label14);
            this.panelContenedor.Controls.Add(this.label8);
            this.panelContenedor.Controls.Add(this.txtDir);
            this.panelContenedor.Controls.Add(this.label7);
            this.panelContenedor.Controls.Add(this.txtCor);
            this.panelContenedor.Controls.Add(this.label6);
            this.panelContenedor.Controls.Add(this.txtDui);
            this.panelContenedor.Controls.Add(this.label12);
            this.panelContenedor.Controls.Add(this.label4);
            this.panelContenedor.Controls.Add(this.txtApe);
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.txtTel);
            this.panelContenedor.Controls.Add(this.txtNom);
            this.panelContenedor.Controls.Add(this.label5);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 25);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1025, 522);
            this.panelContenedor.TabIndex = 39;
            // 
            // txtCifrado
            // 
            this.txtCifrado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCifrado.Location = new System.Drawing.Point(464, 103);
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.Size = new System.Drawing.Size(39, 20);
            this.txtCifrado.TabIndex = 65;
            this.txtCifrado.Visible = false;
            // 
            // cmbTip
            // 
            this.cmbTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(686, 45);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(250, 21);
            this.cmbTip.TabIndex = 58;
            // 
            // cmbEst
            // 
            this.cmbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEst.FormattingEnabled = true;
            this.cmbEst.Location = new System.Drawing.Point(686, 89);
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(250, 21);
            this.cmbEst.TabIndex = 59;
            // 
            // btnIngUsuario
            // 
            this.btnIngUsuario.Activecolor = System.Drawing.Color.DarkRed;
            this.btnIngUsuario.BackColor = System.Drawing.Color.DarkRed;
            this.btnIngUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngUsuario.BorderRadius = 0;
            this.btnIngUsuario.ButtonText = "Ingresar Usuario";
            this.btnIngUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngUsuario.Iconimage = global::EXPO60.Properties.Resources.gender_neutral_user_96px1;
            this.btnIngUsuario.Iconimage_right = null;
            this.btnIngUsuario.Iconimage_right_Selected = null;
            this.btnIngUsuario.Iconimage_Selected = null;
            this.btnIngUsuario.IconMarginLeft = 0;
            this.btnIngUsuario.IconMarginRight = 0;
            this.btnIngUsuario.IconRightVisible = true;
            this.btnIngUsuario.IconRightZoom = 0D;
            this.btnIngUsuario.IconVisible = true;
            this.btnIngUsuario.IconZoom = 80D;
            this.btnIngUsuario.IsTab = false;
            this.btnIngUsuario.Location = new System.Drawing.Point(679, 336);
            this.btnIngUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngUsuario.Name = "btnIngUsuario";
            this.btnIngUsuario.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnIngUsuario.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnIngUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIngUsuario.selected = false;
            this.btnIngUsuario.Size = new System.Drawing.Size(257, 58);
            this.btnIngUsuario.TabIndex = 64;
            this.btnIngUsuario.Text = "Ingresar Usuario";
            this.btnIngUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngUsuario.Textcolor = System.Drawing.Color.White;
            this.btnIngUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngUsuario.Click += new System.EventHandler(this.btnIngUsuario_Click_2);
            // 
            // txtContra
            // 
            this.txtContra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContra.Location = new System.Drawing.Point(686, 232);
            this.txtContra.MaxLength = 50;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(250, 20);
            this.txtContra.TabIndex = 62;
            this.txtContra.TextChanged += new System.EventHandler(this.txtConfirmar_TextChanged);
            // 
            // txtCla
            // 
            this.txtCla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCla.Location = new System.Drawing.Point(686, 175);
            this.txtCla.MaxLength = 50;
            this.txtCla.Name = "txtCla";
            this.txtCla.Size = new System.Drawing.Size(250, 20);
            this.txtCla.TabIndex = 61;
            this.txtCla.TextChanged += new System.EventHandler(this.txtCla_TextChanged_2);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOrange;
            this.label13.Location = new System.Drawing.Point(693, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 20);
            this.label13.TabIndex = 50;
            this.label13.Text = "Las contrasenas no coinciden";
            this.label13.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Confirmar Clave:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(619, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Clave:";
            // 
            // txtUsu
            // 
            this.txtUsu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsu.Location = new System.Drawing.Point(686, 133);
            this.txtUsu.MaxLength = 50;
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(250, 20);
            this.txtUsu.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(603, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Usuario:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(550, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tipo de usuario:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(69, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(911, 16);
            this.label14.TabIndex = 45;
            this.label14.Text = "Bienvenido al formulario de creacion del primer usuario, para hacer uso del siste" +
    "ma se necesita que llene la siguiente informacion:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(531, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Estado del usuario:";
            // 
            // txtDir
            // 
            this.txtDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDir.Location = new System.Drawing.Point(176, 313);
            this.txtDir.MaxLength = 200;
            this.txtDir.Multiline = true;
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(390, 114);
            this.txtDir.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Direccion:";
            // 
            // txtCor
            // 
            this.txtCor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCor.Location = new System.Drawing.Point(176, 207);
            this.txtCor.MaxLength = 50;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(250, 20);
            this.txtCor.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Correo:";
            // 
            // txtDui
            // 
            this.txtDui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDui.Location = new System.Drawing.Point(176, 154);
            this.txtDui.Mask = "00000000-0";
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(250, 20);
            this.txtDui.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(119, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 41;
            this.label12.Text = "DUI:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Telefono:";
            // 
            // txtApe
            // 
            this.txtApe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApe.Location = new System.Drawing.Point(176, 101);
            this.txtApe.MaxLength = 40;
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(250, 20);
            this.txtApe.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Apellido:";
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTel.Location = new System.Drawing.Point(176, 260);
            this.txtTel.Mask = "0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(250, 20);
            this.txtTel.TabIndex = 56;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNom.Location = new System.Drawing.Point(176, 48);
            this.txtNom.MaxLength = 40;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(250, 20);
            this.txtNom.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Nombre:";
            // 
            // FrmPrimerUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 547);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.toolStripPrimer_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrimerUso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrimerUso";
            this.Load += new System.EventHandler(this.FrmPrimerUso_Load);
            this.toolStripPrimer_Usuario.ResumeLayout(false);
            this.toolStripPrimer_Usuario.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripPrimer_Usuario;
        private System.Windows.Forms.ToolStripLabel toollblPrimer_Usuario;
        private System.Windows.Forms.ToolStripButton toolbtnCerrar_Primer;
        private System.Windows.Forms.OpenFileDialog ofpPrimer_Usuario;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TextBox txtCifrado;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbEst;
        private Bunifu.Framework.UI.BunifuFlatButton btnIngUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtCla;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDui;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label5;
    }
}