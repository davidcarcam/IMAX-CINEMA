using System;

namespace EXPO60.Vista
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.btnagregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.cmbEstadoU = new System.Windows.Forms.ComboBox();
            this.cmbTipoU = new System.Windows.Forms.ComboBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnactualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmostrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.txtCifrado);
            this.groupBox2.Controls.Add(this.btnagregar);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.cmbEstadoU);
            this.groupBox2.Controls.Add(this.cmbTipoU);
            this.groupBox2.Controls.Add(this.txtclave);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtusuario);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtdireccion);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.dgvusuarios);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnactualizar);
            this.groupBox2.Controls.Add(this.btnmostrar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtcorreo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtdocumento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtapellido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txttelefono);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1025, 547);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 51;
            // 
            // txtCifrado
            // 
            this.txtCifrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCifrado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCifrado.Location = new System.Drawing.Point(338, 107);
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.Size = new System.Drawing.Size(31, 20);
            this.txtCifrado.TabIndex = 49;
            this.txtCifrado.Visible = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Activecolor = System.Drawing.Color.Maroon;
            this.btnagregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnagregar.BackColor = System.Drawing.Color.Maroon;
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.BorderRadius = 0;
            this.btnagregar.ButtonText = "      Agregar";
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnagregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnagregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnagregar.Iconimage")));
            this.btnagregar.Iconimage_right = null;
            this.btnagregar.Iconimage_right_Selected = null;
            this.btnagregar.Iconimage_Selected = null;
            this.btnagregar.IconMarginLeft = 0;
            this.btnagregar.IconMarginRight = 0;
            this.btnagregar.IconRightVisible = true;
            this.btnagregar.IconRightZoom = 0D;
            this.btnagregar.IconVisible = true;
            this.btnagregar.IconZoom = 90D;
            this.btnagregar.IsTab = false;
            this.btnagregar.Location = new System.Drawing.Point(15, 188);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnagregar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnagregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnagregar.selected = false;
            this.btnagregar.Size = new System.Drawing.Size(241, 48);
            this.btnagregar.TabIndex = 48;
            this.btnagregar.Text = "      Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Textcolor = System.Drawing.Color.White;
            this.btnagregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(120, 22);
            this.BtnCerrar.Text = "Cerrar Formulario";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click_1);
            // 
            // cmbEstadoU
            // 
            this.cmbEstadoU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEstadoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoU.FormattingEnabled = true;
            this.cmbEstadoU.Location = new System.Drawing.Point(839, 15);
            this.cmbEstadoU.Name = "cmbEstadoU";
            this.cmbEstadoU.Size = new System.Drawing.Size(153, 21);
            this.cmbEstadoU.TabIndex = 8;
            // 
            // cmbTipoU
            // 
            this.cmbTipoU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoU.FormattingEnabled = true;
            this.cmbTipoU.Location = new System.Drawing.Point(839, 53);
            this.cmbTipoU.Name = "cmbTipoU";
            this.cmbTipoU.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoU.TabIndex = 9;
            this.cmbTipoU.SelectedIndexChanged += new System.EventHandler(this.cmbTipoU_SelectedIndexChanged);
            // 
            // txtclave
            // 
            this.txtclave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclave.Location = new System.Drawing.Point(839, 126);
            this.txtclave.MaxLength = 20;
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(153, 20);
            this.txtclave.TabIndex = 11;
            this.txtclave.TextChanged += new System.EventHandler(this.txtclave_TextChanged);
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(665, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusuario.Location = new System.Drawing.Point(839, 92);
            this.txtusuario.MaxLength = 25;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(153, 20);
            this.txtusuario.TabIndex = 10;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(665, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Usuario";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(665, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tipo de usuario";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(665, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Estado del usuario";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdireccion.Location = new System.Drawing.Point(456, 92);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(153, 71);
            this.txtdireccion.TabIndex = 7;
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtid.Location = new System.Drawing.Point(338, 65);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(31, 20);
            this.txtid.TabIndex = 36;
            this.txtid.Visible = false;
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Location = new System.Drawing.Point(5, 257);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.Size = new System.Drawing.Size(1011, 265);
            this.dgvusuarios.TabIndex = 35;
            this.dgvusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Activecolor = System.Drawing.Color.Maroon;
            this.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneliminar.BackColor = System.Drawing.Color.Maroon;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.BorderRadius = 0;
            this.btneliminar.ButtonText = "      Eliminar";
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btneliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btneliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btneliminar.Iconimage")));
            this.btneliminar.Iconimage_right = null;
            this.btneliminar.Iconimage_right_Selected = null;
            this.btneliminar.Iconimage_Selected = null;
            this.btneliminar.IconMarginLeft = 0;
            this.btneliminar.IconMarginRight = 0;
            this.btneliminar.IconRightVisible = true;
            this.btneliminar.IconRightZoom = 0D;
            this.btneliminar.IconVisible = true;
            this.btneliminar.IconZoom = 90D;
            this.btneliminar.IsTab = false;
            this.btneliminar.Location = new System.Drawing.Point(772, 188);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.Maroon;
            this.btneliminar.OnHovercolor = System.Drawing.Color.Brown;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = false;
            this.btneliminar.Size = new System.Drawing.Size(241, 48);
            this.btneliminar.TabIndex = 34;
            this.btneliminar.Text = "      Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Textcolor = System.Drawing.Color.White;
            this.btneliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Activecolor = System.Drawing.Color.Maroon;
            this.btnactualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnactualizar.BackColor = System.Drawing.Color.Maroon;
            this.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnactualizar.BorderRadius = 0;
            this.btnactualizar.ButtonText = "      Actualizar";
            this.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnactualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnactualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnactualizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Iconimage")));
            this.btnactualizar.Iconimage_right = null;
            this.btnactualizar.Iconimage_right_Selected = null;
            this.btnactualizar.Iconimage_Selected = null;
            this.btnactualizar.IconMarginLeft = 0;
            this.btnactualizar.IconMarginRight = 0;
            this.btnactualizar.IconRightVisible = true;
            this.btnactualizar.IconRightZoom = 0D;
            this.btnactualizar.IconVisible = true;
            this.btnactualizar.IconZoom = 90D;
            this.btnactualizar.IsTab = false;
            this.btnactualizar.Location = new System.Drawing.Point(509, 188);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnactualizar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnactualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnactualizar.selected = false;
            this.btnactualizar.Size = new System.Drawing.Size(241, 48);
            this.btnactualizar.TabIndex = 33;
            this.btnactualizar.Text = "      Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Textcolor = System.Drawing.Color.White;
            this.btnactualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Activecolor = System.Drawing.Color.Maroon;
            this.btnmostrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmostrar.BackColor = System.Drawing.Color.Maroon;
            this.btnmostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmostrar.BorderRadius = 0;
            this.btnmostrar.ButtonText = "      Mostrar";
            this.btnmostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmostrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnmostrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnmostrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnmostrar.Iconimage")));
            this.btnmostrar.Iconimage_right = null;
            this.btnmostrar.Iconimage_right_Selected = null;
            this.btnmostrar.Iconimage_Selected = null;
            this.btnmostrar.IconMarginLeft = 0;
            this.btnmostrar.IconMarginRight = 0;
            this.btnmostrar.IconRightVisible = true;
            this.btnmostrar.IconRightZoom = 0D;
            this.btnmostrar.IconVisible = true;
            this.btnmostrar.IconZoom = 90D;
            this.btnmostrar.IsTab = false;
            this.btnmostrar.Location = new System.Drawing.Point(262, 188);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnmostrar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnmostrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmostrar.selected = false;
            this.btnmostrar.Size = new System.Drawing.Size(241, 48);
            this.btnmostrar.TabIndex = 32;
            this.btnmostrar.Text = "      Mostrar";
            this.btnmostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmostrar.Textcolor = System.Drawing.Color.White;
            this.btnmostrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Direccion";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcorreo.Location = new System.Drawing.Point(0, 0);
            this.txtcorreo.MaxLength = 50;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.txtcorreo.TabIndex = 50;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged_1);
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Correo";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdocumento.Location = new System.Drawing.Point(419, 14);
            this.txtdocumento.Mask = "00000000-0";
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(153, 20);
            this.txtdocumento.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "DUI";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefono";
            // 
            // txtapellido
            // 
            this.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapellido.Location = new System.Drawing.Point(136, 63);
            this.txtapellido.MaxLength = 8;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(153, 20);
            this.txtapellido.TabIndex = 2;
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Apellido";
            // 
            // txttelefono
            // 
            this.txttelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttelefono.Location = new System.Drawing.Point(136, 107);
            this.txttelefono.Mask = "0000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(153, 20);
            this.txttelefono.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.Location = new System.Drawing.Point(136, 23);
            this.txtnombre.MaxLength = 8;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(153, 20);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1025, 547);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnagregar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ComboBox cmbEstadoU;
        private System.Windows.Forms.ComboBox cmbTipoU;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnactualizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnmostrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtdocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCifrado;
        private System.Windows.Forms.TextBox textBox1;
    }
}