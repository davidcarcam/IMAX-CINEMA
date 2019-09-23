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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnmostrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnactualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.cmbTipoU = new System.Windows.Forms.ComboBox();
            this.cmbEstadoU = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.BtnUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnagregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.Location = new System.Drawing.Point(133, 51);
            this.txtnombre.MaxLength = 60;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(153, 20);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress_1);
            // 
            // txttelefono
            // 
            this.txttelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttelefono.Location = new System.Drawing.Point(133, 144);
            this.txttelefono.Mask = "0000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(153, 20);
            this.txttelefono.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            // 
            // txtapellido
            // 
            this.txtapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapellido.Location = new System.Drawing.Point(133, 94);
            this.txtapellido.MaxLength = 60;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(153, 20);
            this.txtapellido.TabIndex = 2;
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "DUI";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdocumento.Location = new System.Drawing.Point(457, 44);
            this.txtdocumento.Mask = "00000000-0";
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(196, 20);
            this.txtdocumento.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Correo";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcorreo.Location = new System.Drawing.Point(457, 76);
            this.txtcorreo.MaxLength = 200;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(196, 20);
            this.txtcorreo.TabIndex = 5;
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Direccion";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Activecolor = System.Drawing.Color.Maroon;
            this.btnmostrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmostrar.BackColor = System.Drawing.Color.Maroon;
            this.btnmostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmostrar.BorderRadius = 0;
            this.btnmostrar.ButtonText = "Mostrar y Limpiar Campos";
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
            this.btnmostrar.Location = new System.Drawing.Point(263, 201);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnmostrar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnmostrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmostrar.selected = false;
            this.btnmostrar.Size = new System.Drawing.Size(241, 48);
            this.btnmostrar.TabIndex = 9;
            this.btnmostrar.Text = "Mostrar y Limpiar Campos";
            this.btnmostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnmostrar.Textcolor = System.Drawing.Color.White;
            this.btnmostrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click_1);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Activecolor = System.Drawing.Color.Maroon;
            this.btnactualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnactualizar.BackColor = System.Drawing.Color.Maroon;
            this.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnactualizar.BorderRadius = 0;
            this.btnactualizar.ButtonText = "Actualizar";
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
            this.btnactualizar.Location = new System.Drawing.Point(510, 201);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnactualizar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnactualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnactualizar.selected = false;
            this.btnactualizar.Size = new System.Drawing.Size(241, 48);
            this.btnactualizar.TabIndex = 10;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnactualizar.Textcolor = System.Drawing.Color.White;
            this.btnactualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Activecolor = System.Drawing.Color.Maroon;
            this.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneliminar.BackColor = System.Drawing.Color.Maroon;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.BorderRadius = 0;
            this.btneliminar.ButtonText = "Eliminar";
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
            this.btneliminar.Location = new System.Drawing.Point(772, 201);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.Maroon;
            this.btneliminar.OnHovercolor = System.Drawing.Color.Brown;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = false;
            this.btneliminar.Size = new System.Drawing.Size(241, 48);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneliminar.Textcolor = System.Drawing.Color.White;
            this.btneliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Location = new System.Drawing.Point(10, 264);
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.Size = new System.Drawing.Size(1009, 230);
            this.dgvusuarios.TabIndex = 0;
            this.dgvusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellClick);
            this.dgvusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellContentClick);
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtid.Location = new System.Drawing.Point(323, 54);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(31, 20);
            this.txtid.TabIndex = 36;
            this.txtid.Visible = false;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdireccion.Location = new System.Drawing.Point(457, 116);
            this.txtdireccion.MaxLength = 200;
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(196, 71);
            this.txtdireccion.TabIndex = 6;
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(679, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Estado del usuario";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(699, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo de usuario";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(752, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusuario.Location = new System.Drawing.Point(836, 118);
            this.txtusuario.MaxLength = 60;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(153, 20);
            this.txtusuario.TabIndex = 9;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // cmbTipoU
            // 
            this.cmbTipoU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoU.Location = new System.Drawing.Point(837, 78);
            this.cmbTipoU.Name = "cmbTipoU";
            this.cmbTipoU.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoU.TabIndex = 8;
            // 
            // cmbEstadoU
            // 
            this.cmbEstadoU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEstadoU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoU.FormattingEnabled = true;
            this.cmbEstadoU.Location = new System.Drawing.Point(836, 51);
            this.cmbEstadoU.Name = "cmbEstadoU";
            this.cmbEstadoU.Size = new System.Drawing.Size(153, 21);
            this.cmbEstadoU.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar,
            this.BtnUsuario,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.Image = global::EXPO60.Properties.Resources.cancel;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(120, 22);
            this.BtnCerrar.Text = "Cerrar Formulario";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click_1);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnUsuario.Image = global::EXPO60.Properties.Resources.document_96px;
            this.BtnUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(112, 22);
            this.BtnUsuario.Text = "Generar Reporte";
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(125, 22);
            this.toolStripButton1.Text = "Recuperar contraseña";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Activecolor = System.Drawing.Color.Maroon;
            this.btnagregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnagregar.BackColor = System.Drawing.Color.Maroon;
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.BorderRadius = 0;
            this.btnagregar.ButtonText = "Agregar";
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
            this.btnagregar.Location = new System.Drawing.Point(16, 201);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnagregar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnagregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnagregar.selected = false;
            this.btnagregar.Size = new System.Drawing.Size(241, 48);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnagregar.Textcolor = System.Drawing.Color.White;
            this.btnagregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // txtCifrado
            // 
            this.txtCifrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCifrado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCifrado.Location = new System.Drawing.Point(323, 107);
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.Size = new System.Drawing.Size(31, 20);
            this.txtCifrado.TabIndex = 49;
            this.txtCifrado.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCifrado);
            this.groupBox2.Controls.Add(this.btnagregar);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.cmbEstadoU);
            this.groupBox2.Controls.Add(this.cmbTipoU);
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
            this.groupBox2.Size = new System.Drawing.Size(1025, 500);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de usuarios";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1025, 500);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCifrado;
        private Bunifu.Framework.UI.BunifuFlatButton btnagregar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ComboBox cmbEstadoU;
        private System.Windows.Forms.ComboBox cmbTipoU;
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
        private System.Windows.Forms.ToolStripButton BtnUsuario;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}