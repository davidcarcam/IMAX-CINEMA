namespace EXPO60.Vista
{
    partial class FrmAsientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsientos));
            this.grpAsientos = new System.Windows.Forms.GroupBox();
            this.cmbsala = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbfila = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbtnCerrar_Asientos = new System.Windows.Forms.ToolStripButton();
            this.BtnAsientos = new System.Windows.Forms.ToolStripButton();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.cmbasiento = new System.Windows.Forms.ComboBox();
            this.lblEstado_Asiento = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtID_Asiento = new System.Windows.Forms.TextBox();
            this.lblAsiento = new System.Windows.Forms.Label();
            this.dgvAsientos = new System.Windows.Forms.DataGridView();
            this.btnEliminar_Asiento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnActualizar_Asiento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMostrar_Asientos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar_Asiento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.epError1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAsientos.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAsientos
            // 
            this.grpAsientos.Controls.Add(this.cmbsala);
            this.grpAsientos.Controls.Add(this.label1);
            this.grpAsientos.Controls.Add(this.cmbfila);
            this.grpAsientos.Controls.Add(this.label8);
            this.grpAsientos.Controls.Add(this.txtbuscar);
            this.grpAsientos.Controls.Add(this.toolStrip1);
            this.grpAsientos.Controls.Add(this.cmbestado);
            this.grpAsientos.Controls.Add(this.cmbasiento);
            this.grpAsientos.Controls.Add(this.lblEstado_Asiento);
            this.grpAsientos.Controls.Add(this.lblSala);
            this.grpAsientos.Controls.Add(this.txtID_Asiento);
            this.grpAsientos.Controls.Add(this.lblAsiento);
            this.grpAsientos.Controls.Add(this.dgvAsientos);
            this.grpAsientos.Controls.Add(this.btnEliminar_Asiento);
            this.grpAsientos.Controls.Add(this.btnActualizar_Asiento);
            this.grpAsientos.Controls.Add(this.btnMostrar_Asientos);
            this.grpAsientos.Controls.Add(this.btnAgregar_Asiento);
            this.grpAsientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAsientos.Location = new System.Drawing.Point(0, 0);
            this.grpAsientos.Name = "grpAsientos";
            this.grpAsientos.Size = new System.Drawing.Size(1025, 547);
            this.grpAsientos.TabIndex = 0;
            this.grpAsientos.TabStop = false;
            this.grpAsientos.Text = "Registro de Asientos";
            // 
            // cmbsala
            // 
            this.cmbsala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbsala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsala.FormattingEnabled = true;
            this.cmbsala.Location = new System.Drawing.Point(132, 126);
            this.cmbsala.Name = "cmbsala";
            this.cmbsala.Size = new System.Drawing.Size(200, 21);
            this.cmbsala.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Sala";
            // 
            // cmbfila
            // 
            this.cmbfila.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbfila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfila.FormattingEnabled = true;
            this.cmbfila.Location = new System.Drawing.Point(132, 70);
            this.cmbfila.Name = "cmbfila";
            this.cmbfila.Size = new System.Drawing.Size(200, 21);
            this.cmbfila.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(738, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 71;
            this.label8.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbuscar.Location = new System.Drawing.Point(803, 74);
            this.txtbuscar.MaxLength = 50;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(144, 20);
            this.txtbuscar.TabIndex = 5;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnCerrar_Asientos,
            this.BtnAsientos});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 65;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbtnCerrar_Asientos
            // 
            this.toolbtnCerrar_Asientos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolbtnCerrar_Asientos.Image = global::EXPO60.Properties.Resources.cancel;
            this.toolbtnCerrar_Asientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnCerrar_Asientos.Name = "toolbtnCerrar_Asientos";
            this.toolbtnCerrar_Asientos.Size = new System.Drawing.Size(107, 22);
            this.toolbtnCerrar_Asientos.Text = "Cerrar Asientos";
            this.toolbtnCerrar_Asientos.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // BtnAsientos
            // 
            this.BtnAsientos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnAsientos.Image = global::EXPO60.Properties.Resources.connection_indicator;
            this.BtnAsientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAsientos.Name = "BtnAsientos";
            this.BtnAsientos.Size = new System.Drawing.Size(109, 22);
            this.BtnAsientos.Text = "Generar reporte";
            this.BtnAsientos.Click += new System.EventHandler(this.BtnAsientos_Click);
            // 
            // cmbestado
            // 
            this.cmbestado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(597, 125);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(200, 21);
            this.cmbestado.TabIndex = 4;
            // 
            // cmbasiento
            // 
            this.cmbasiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbasiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbasiento.FormattingEnabled = true;
            this.cmbasiento.Location = new System.Drawing.Point(506, 71);
            this.cmbasiento.Name = "cmbasiento";
            this.cmbasiento.Size = new System.Drawing.Size(200, 21);
            this.cmbasiento.TabIndex = 2;
            // 
            // lblEstado_Asiento
            // 
            this.lblEstado_Asiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado_Asiento.AutoSize = true;
            this.lblEstado_Asiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado_Asiento.Location = new System.Drawing.Point(397, 126);
            this.lblEstado_Asiento.Name = "lblEstado_Asiento";
            this.lblEstado_Asiento.Size = new System.Drawing.Size(194, 20);
            this.lblEstado_Asiento.TabIndex = 0;
            this.lblEstado_Asiento.Text = "Estado actual del Asiento:";
            // 
            // lblSala
            // 
            this.lblSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.Location = new System.Drawing.Point(357, 71);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(143, 20);
            this.lblSala.TabIndex = 0;
            this.lblSala.Text = "Numero de asiento";
            // 
            // txtID_Asiento
            // 
            this.txtID_Asiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID_Asiento.Location = new System.Drawing.Point(315, 105);
            this.txtID_Asiento.Name = "txtID_Asiento";
            this.txtID_Asiento.Size = new System.Drawing.Size(32, 20);
            this.txtID_Asiento.TabIndex = 0;
            this.txtID_Asiento.Visible = false;
            // 
            // lblAsiento
            // 
            this.lblAsiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAsiento.AutoSize = true;
            this.lblAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiento.Location = new System.Drawing.Point(15, 68);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(111, 20);
            this.lblAsiento.TabIndex = 0;
            this.lblAsiento.Text = "Numero de fila";
            // 
            // dgvAsientos
            // 
            this.dgvAsientos.AllowUserToAddRows = false;
            this.dgvAsientos.AllowUserToDeleteRows = false;
            this.dgvAsientos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAsientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsientos.Location = new System.Drawing.Point(12, 241);
            this.dgvAsientos.Name = "dgvAsientos";
            this.dgvAsientos.Size = new System.Drawing.Size(986, 265);
            this.dgvAsientos.TabIndex = 0;
            this.dgvAsientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAsientos_CellClick);
            // 
            // btnEliminar_Asiento
            // 
            this.btnEliminar_Asiento.Activecolor = System.Drawing.Color.Maroon;
            this.btnEliminar_Asiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar_Asiento.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar_Asiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar_Asiento.BorderRadius = 0;
            this.btnEliminar_Asiento.ButtonText = "Eliminar Asiento";
            this.btnEliminar_Asiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar_Asiento.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar_Asiento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar_Asiento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar_Asiento.Iconimage")));
            this.btnEliminar_Asiento.Iconimage_right = null;
            this.btnEliminar_Asiento.Iconimage_right_Selected = null;
            this.btnEliminar_Asiento.Iconimage_Selected = null;
            this.btnEliminar_Asiento.IconMarginLeft = 0;
            this.btnEliminar_Asiento.IconMarginRight = 0;
            this.btnEliminar_Asiento.IconRightVisible = true;
            this.btnEliminar_Asiento.IconRightZoom = 0D;
            this.btnEliminar_Asiento.IconVisible = true;
            this.btnEliminar_Asiento.IconZoom = 80D;
            this.btnEliminar_Asiento.IsTab = false;
            this.btnEliminar_Asiento.Location = new System.Drawing.Point(757, 178);
            this.btnEliminar_Asiento.Name = "btnEliminar_Asiento";
            this.btnEliminar_Asiento.Normalcolor = System.Drawing.Color.Maroon;
            this.btnEliminar_Asiento.OnHovercolor = System.Drawing.Color.Brown;
            this.btnEliminar_Asiento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar_Asiento.selected = false;
            this.btnEliminar_Asiento.Size = new System.Drawing.Size(241, 48);
            this.btnEliminar_Asiento.TabIndex = 7;
            this.btnEliminar_Asiento.Text = "Eliminar Asiento";
            this.btnEliminar_Asiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar_Asiento.Textcolor = System.Drawing.Color.White;
            this.btnEliminar_Asiento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Asiento.Click += new System.EventHandler(this.BtnEliminar_Asiento_Click);
            // 
            // btnActualizar_Asiento
            // 
            this.btnActualizar_Asiento.Activecolor = System.Drawing.Color.Maroon;
            this.btnActualizar_Asiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar_Asiento.BackColor = System.Drawing.Color.Maroon;
            this.btnActualizar_Asiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar_Asiento.BorderRadius = 0;
            this.btnActualizar_Asiento.ButtonText = "Actualizar Asiento";
            this.btnActualizar_Asiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar_Asiento.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizar_Asiento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizar_Asiento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnActualizar_Asiento.Iconimage")));
            this.btnActualizar_Asiento.Iconimage_right = null;
            this.btnActualizar_Asiento.Iconimage_right_Selected = null;
            this.btnActualizar_Asiento.Iconimage_Selected = null;
            this.btnActualizar_Asiento.IconMarginLeft = 0;
            this.btnActualizar_Asiento.IconMarginRight = 0;
            this.btnActualizar_Asiento.IconRightVisible = true;
            this.btnActualizar_Asiento.IconRightZoom = 0D;
            this.btnActualizar_Asiento.IconVisible = true;
            this.btnActualizar_Asiento.IconZoom = 80D;
            this.btnActualizar_Asiento.IsTab = false;
            this.btnActualizar_Asiento.Location = new System.Drawing.Point(506, 178);
            this.btnActualizar_Asiento.Name = "btnActualizar_Asiento";
            this.btnActualizar_Asiento.Normalcolor = System.Drawing.Color.Maroon;
            this.btnActualizar_Asiento.OnHovercolor = System.Drawing.Color.Brown;
            this.btnActualizar_Asiento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnActualizar_Asiento.selected = false;
            this.btnActualizar_Asiento.Size = new System.Drawing.Size(241, 48);
            this.btnActualizar_Asiento.TabIndex = 6;
            this.btnActualizar_Asiento.Text = "Actualizar Asiento";
            this.btnActualizar_Asiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar_Asiento.Textcolor = System.Drawing.Color.White;
            this.btnActualizar_Asiento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar_Asiento.Click += new System.EventHandler(this.BtnActualizar_Asiento_Click);
            // 
            // btnMostrar_Asientos
            // 
            this.btnMostrar_Asientos.Activecolor = System.Drawing.Color.Maroon;
            this.btnMostrar_Asientos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostrar_Asientos.BackColor = System.Drawing.Color.Maroon;
            this.btnMostrar_Asientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrar_Asientos.BorderRadius = 0;
            this.btnMostrar_Asientos.ButtonText = "Mostrar y Limpiar Campos";
            this.btnMostrar_Asientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar_Asientos.DisabledColor = System.Drawing.Color.Gray;
            this.btnMostrar_Asientos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMostrar_Asientos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMostrar_Asientos.Iconimage")));
            this.btnMostrar_Asientos.Iconimage_right = null;
            this.btnMostrar_Asientos.Iconimage_right_Selected = null;
            this.btnMostrar_Asientos.Iconimage_Selected = null;
            this.btnMostrar_Asientos.IconMarginLeft = 0;
            this.btnMostrar_Asientos.IconMarginRight = 0;
            this.btnMostrar_Asientos.IconRightVisible = true;
            this.btnMostrar_Asientos.IconRightZoom = 0D;
            this.btnMostrar_Asientos.IconVisible = true;
            this.btnMostrar_Asientos.IconZoom = 80D;
            this.btnMostrar_Asientos.IsTab = false;
            this.btnMostrar_Asientos.Location = new System.Drawing.Point(259, 178);
            this.btnMostrar_Asientos.Name = "btnMostrar_Asientos";
            this.btnMostrar_Asientos.Normalcolor = System.Drawing.Color.Maroon;
            this.btnMostrar_Asientos.OnHovercolor = System.Drawing.Color.Brown;
            this.btnMostrar_Asientos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMostrar_Asientos.selected = false;
            this.btnMostrar_Asientos.Size = new System.Drawing.Size(241, 48);
            this.btnMostrar_Asientos.TabIndex = 5;
            this.btnMostrar_Asientos.Text = "Mostrar y Limpiar Campos";
            this.btnMostrar_Asientos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrar_Asientos.Textcolor = System.Drawing.Color.White;
            this.btnMostrar_Asientos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar_Asientos.Click += new System.EventHandler(this.BtnMostrar_Asientos_Click);
            // 
            // btnAgregar_Asiento
            // 
            this.btnAgregar_Asiento.Activecolor = System.Drawing.Color.Maroon;
            this.btnAgregar_Asiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar_Asiento.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregar_Asiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar_Asiento.BorderRadius = 0;
            this.btnAgregar_Asiento.ButtonText = "Agregar Asiento";
            this.btnAgregar_Asiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar_Asiento.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar_Asiento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar_Asiento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregar_Asiento.Iconimage")));
            this.btnAgregar_Asiento.Iconimage_right = null;
            this.btnAgregar_Asiento.Iconimage_right_Selected = null;
            this.btnAgregar_Asiento.Iconimage_Selected = null;
            this.btnAgregar_Asiento.IconMarginLeft = 0;
            this.btnAgregar_Asiento.IconMarginRight = 0;
            this.btnAgregar_Asiento.IconRightVisible = true;
            this.btnAgregar_Asiento.IconRightZoom = 0D;
            this.btnAgregar_Asiento.IconVisible = true;
            this.btnAgregar_Asiento.IconZoom = 80D;
            this.btnAgregar_Asiento.IsTab = false;
            this.btnAgregar_Asiento.Location = new System.Drawing.Point(12, 178);
            this.btnAgregar_Asiento.Name = "btnAgregar_Asiento";
            this.btnAgregar_Asiento.Normalcolor = System.Drawing.Color.Maroon;
            this.btnAgregar_Asiento.OnHovercolor = System.Drawing.Color.Brown;
            this.btnAgregar_Asiento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar_Asiento.selected = false;
            this.btnAgregar_Asiento.Size = new System.Drawing.Size(241, 48);
            this.btnAgregar_Asiento.TabIndex = 4;
            this.btnAgregar_Asiento.Text = "Agregar Asiento";
            this.btnAgregar_Asiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar_Asiento.Textcolor = System.Drawing.Color.White;
            this.btnAgregar_Asiento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar_Asiento.Click += new System.EventHandler(this.BtnAgregar_Asiento_Click);
            // 
            // epError1
            // 
            this.epError1.ContainerControl = this;
            // 
            // FrmAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 547);
            this.Controls.Add(this.grpAsientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsientos";
            this.Text = "FrmAsientos";
            this.Load += new System.EventHandler(this.FrmAsientos_Load);
            this.grpAsientos.ResumeLayout(false);
            this.grpAsientos.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAsientos;
        private System.Windows.Forms.Label lblEstado_Asiento;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.TextBox txtID_Asiento;
        private System.Windows.Forms.Label lblAsiento;
        private System.Windows.Forms.DataGridView dgvAsientos;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar_Asiento;
        private Bunifu.Framework.UI.BunifuFlatButton btnActualizar_Asiento;
        private Bunifu.Framework.UI.BunifuFlatButton btnMostrar_Asientos;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar_Asiento;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.ComboBox cmbasiento;
        private System.Windows.Forms.ErrorProvider epError1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolbtnCerrar_Asientos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cmbfila;
        private System.Windows.Forms.ComboBox cmbsala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton BtnAsientos;
    }
}