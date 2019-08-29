namespace EXPO60.Vista
{
    partial class FrmSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSala));
            this.grpRegistro_Sala = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.cmbESTADO_SALA = new System.Windows.Forms.ComboBox();
            this.lblEstado_Sala = new System.Windows.Forms.Label();
            this.txtCapacidad_Sala = new System.Windows.Forms.TextBox();
            this.lblCapacidad_Sala = new System.Windows.Forms.Label();
            this.txtID_Sala = new System.Windows.Forms.TextBox();
            this.txtNumero_Sala = new System.Windows.Forms.TextBox();
            this.lblNumero_Sala = new System.Windows.Forms.Label();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.btnEliminar_Sala = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnActualizar_Sala = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMostrar_Salas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar_Sala = new Bunifu.Framework.UI.BunifuFlatButton();
            this.epError2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpRegistro_Sala.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRegistro_Sala
            // 
            this.grpRegistro_Sala.Controls.Add(this.label1);
            this.grpRegistro_Sala.Controls.Add(this.txtbuscar);
            this.grpRegistro_Sala.Controls.Add(this.toolStrip1);
            this.grpRegistro_Sala.Controls.Add(this.cmbESTADO_SALA);
            this.grpRegistro_Sala.Controls.Add(this.lblEstado_Sala);
            this.grpRegistro_Sala.Controls.Add(this.txtCapacidad_Sala);
            this.grpRegistro_Sala.Controls.Add(this.lblCapacidad_Sala);
            this.grpRegistro_Sala.Controls.Add(this.txtID_Sala);
            this.grpRegistro_Sala.Controls.Add(this.txtNumero_Sala);
            this.grpRegistro_Sala.Controls.Add(this.lblNumero_Sala);
            this.grpRegistro_Sala.Controls.Add(this.dgvSalas);
            this.grpRegistro_Sala.Controls.Add(this.btnEliminar_Sala);
            this.grpRegistro_Sala.Controls.Add(this.btnActualizar_Sala);
            this.grpRegistro_Sala.Controls.Add(this.btnMostrar_Salas);
            this.grpRegistro_Sala.Controls.Add(this.btnAgregar_Sala);
            this.grpRegistro_Sala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRegistro_Sala.Location = new System.Drawing.Point(0, 0);
            this.grpRegistro_Sala.Name = "grpRegistro_Sala";
            this.grpRegistro_Sala.Size = new System.Drawing.Size(1025, 547);
            this.grpRegistro_Sala.TabIndex = 0;
            this.grpRegistro_Sala.TabStop = false;
            this.grpRegistro_Sala.Text = "Registro de sala";
            this.grpRegistro_Sala.Enter += new System.EventHandler(this.grpRegistro_Sala_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbuscar.Location = new System.Drawing.Point(827, 59);
            this.txtbuscar.MaxLength = 50;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(144, 20);
            this.txtbuscar.TabIndex = 64;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 63;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnCerrar.Image = global::EXPO60.Properties.Resources.cancel;
            this.BtnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(120, 22);
            this.BtnCerrar.Text = "Cerrar Formulario";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // cmbESTADO_SALA
            // 
            this.cmbESTADO_SALA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbESTADO_SALA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbESTADO_SALA.FormattingEnabled = true;
            this.cmbESTADO_SALA.Location = new System.Drawing.Point(838, 110);
            this.cmbESTADO_SALA.Name = "cmbESTADO_SALA";
            this.cmbESTADO_SALA.Size = new System.Drawing.Size(153, 21);
            this.cmbESTADO_SALA.TabIndex = 3;
            this.cmbESTADO_SALA.SelectedIndexChanged += new System.EventHandler(this.cmbESTADO_SALA_SelectedIndexChanged);
            // 
            // lblEstado_Sala
            // 
            this.lblEstado_Sala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado_Sala.AutoSize = true;
            this.lblEstado_Sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado_Sala.Location = new System.Drawing.Point(686, 110);
            this.lblEstado_Sala.Name = "lblEstado_Sala";
            this.lblEstado_Sala.Size = new System.Drawing.Size(135, 20);
            this.lblEstado_Sala.TabIndex = 0;
            this.lblEstado_Sala.Text = "Estado de la sala:";
            // 
            // txtCapacidad_Sala
            // 
            this.txtCapacidad_Sala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCapacidad_Sala.Location = new System.Drawing.Point(516, 110);
            this.txtCapacidad_Sala.MaxLength = 4;
            this.txtCapacidad_Sala.Name = "txtCapacidad_Sala";
            this.txtCapacidad_Sala.Size = new System.Drawing.Size(153, 20);
            this.txtCapacidad_Sala.TabIndex = 2;
            this.txtCapacidad_Sala.TextChanged += new System.EventHandler(this.txtCapacidad_Sala_TextChanged);
            this.txtCapacidad_Sala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCapacidad_Sala_KeyPress);
            this.txtCapacidad_Sala.Validated += new System.EventHandler(this.TxtCapacidad_Sala_Validated);
            // 
            // lblCapacidad_Sala
            // 
            this.lblCapacidad_Sala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCapacidad_Sala.AutoSize = true;
            this.lblCapacidad_Sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad_Sala.Location = new System.Drawing.Point(339, 110);
            this.lblCapacidad_Sala.Name = "lblCapacidad_Sala";
            this.lblCapacidad_Sala.Size = new System.Drawing.Size(160, 20);
            this.lblCapacidad_Sala.TabIndex = 0;
            this.lblCapacidad_Sala.Text = "Capacidad de la sala:";
            // 
            // txtID_Sala
            // 
            this.txtID_Sala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID_Sala.Location = new System.Drawing.Point(515, 59);
            this.txtID_Sala.Name = "txtID_Sala";
            this.txtID_Sala.Size = new System.Drawing.Size(35, 20);
            this.txtID_Sala.TabIndex = 0;
            this.txtID_Sala.Visible = false;
            // 
            // txtNumero_Sala
            // 
            this.txtNumero_Sala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero_Sala.Location = new System.Drawing.Point(169, 110);
            this.txtNumero_Sala.MaxLength = 2;
            this.txtNumero_Sala.Name = "txtNumero_Sala";
            this.txtNumero_Sala.Size = new System.Drawing.Size(153, 20);
            this.txtNumero_Sala.TabIndex = 1;
            this.txtNumero_Sala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_Sala_KeyPress);
            this.txtNumero_Sala.Validated += new System.EventHandler(this.TxtNumero_Sala_Validated);
            // 
            // lblNumero_Sala
            // 
            this.lblNumero_Sala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumero_Sala.AutoSize = true;
            this.lblNumero_Sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero_Sala.Location = new System.Drawing.Point(12, 110);
            this.lblNumero_Sala.Name = "lblNumero_Sala";
            this.lblNumero_Sala.Size = new System.Drawing.Size(140, 20);
            this.lblNumero_Sala.TabIndex = 0;
            this.lblNumero_Sala.Text = "Numero de la sala:";
            // 
            // dgvSalas
            // 
            this.dgvSalas.AllowUserToAddRows = false;
            this.dgvSalas.AllowUserToDeleteRows = false;
            this.dgvSalas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalas.Location = new System.Drawing.Point(6, 288);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.Size = new System.Drawing.Size(1011, 265);
            this.dgvSalas.TabIndex = 0;
            this.dgvSalas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalas_CellClick);
            this.dgvSalas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalas_CellContentClick);
            // 
            // btnEliminar_Sala
            // 
            this.btnEliminar_Sala.Activecolor = System.Drawing.Color.Maroon;
            this.btnEliminar_Sala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar_Sala.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar_Sala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar_Sala.BorderRadius = 0;
            this.btnEliminar_Sala.ButtonText = "Eliminar Sala";
            this.btnEliminar_Sala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar_Sala.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar_Sala.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar_Sala.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar_Sala.Iconimage")));
            this.btnEliminar_Sala.Iconimage_right = null;
            this.btnEliminar_Sala.Iconimage_right_Selected = null;
            this.btnEliminar_Sala.Iconimage_Selected = null;
            this.btnEliminar_Sala.IconMarginLeft = 0;
            this.btnEliminar_Sala.IconMarginRight = 0;
            this.btnEliminar_Sala.IconRightVisible = true;
            this.btnEliminar_Sala.IconRightZoom = 0D;
            this.btnEliminar_Sala.IconVisible = true;
            this.btnEliminar_Sala.IconZoom = 80D;
            this.btnEliminar_Sala.IsTab = false;
            this.btnEliminar_Sala.Location = new System.Drawing.Point(778, 175);
            this.btnEliminar_Sala.Name = "btnEliminar_Sala";
            this.btnEliminar_Sala.Normalcolor = System.Drawing.Color.Maroon;
            this.btnEliminar_Sala.OnHovercolor = System.Drawing.Color.Brown;
            this.btnEliminar_Sala.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar_Sala.selected = false;
            this.btnEliminar_Sala.Size = new System.Drawing.Size(241, 48);
            this.btnEliminar_Sala.TabIndex = 7;
            this.btnEliminar_Sala.Text = "Eliminar Sala";
            this.btnEliminar_Sala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar_Sala.Textcolor = System.Drawing.Color.White;
            this.btnEliminar_Sala.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Sala.Click += new System.EventHandler(this.BtnEliminar_Salas_Click);
            // 
            // btnActualizar_Sala
            // 
            this.btnActualizar_Sala.Activecolor = System.Drawing.Color.Maroon;
            this.btnActualizar_Sala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar_Sala.BackColor = System.Drawing.Color.Maroon;
            this.btnActualizar_Sala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar_Sala.BorderRadius = 0;
            this.btnActualizar_Sala.ButtonText = "Actualizar Sala";
            this.btnActualizar_Sala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar_Sala.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizar_Sala.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizar_Sala.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnActualizar_Sala.Iconimage")));
            this.btnActualizar_Sala.Iconimage_right = null;
            this.btnActualizar_Sala.Iconimage_right_Selected = null;
            this.btnActualizar_Sala.Iconimage_Selected = null;
            this.btnActualizar_Sala.IconMarginLeft = 0;
            this.btnActualizar_Sala.IconMarginRight = 0;
            this.btnActualizar_Sala.IconRightVisible = true;
            this.btnActualizar_Sala.IconRightZoom = 0D;
            this.btnActualizar_Sala.IconVisible = true;
            this.btnActualizar_Sala.IconZoom = 80D;
            this.btnActualizar_Sala.IsTab = false;
            this.btnActualizar_Sala.Location = new System.Drawing.Point(515, 175);
            this.btnActualizar_Sala.Name = "btnActualizar_Sala";
            this.btnActualizar_Sala.Normalcolor = System.Drawing.Color.Maroon;
            this.btnActualizar_Sala.OnHovercolor = System.Drawing.Color.Brown;
            this.btnActualizar_Sala.OnHoverTextColor = System.Drawing.Color.White;
            this.btnActualizar_Sala.selected = false;
            this.btnActualizar_Sala.Size = new System.Drawing.Size(241, 48);
            this.btnActualizar_Sala.TabIndex = 6;
            this.btnActualizar_Sala.Text = "Actualizar Sala";
            this.btnActualizar_Sala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar_Sala.Textcolor = System.Drawing.Color.White;
            this.btnActualizar_Sala.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar_Sala.Click += new System.EventHandler(this.BtnActualizar_Salas_Click);
            // 
            // btnMostrar_Salas
            // 
            this.btnMostrar_Salas.Activecolor = System.Drawing.Color.Maroon;
            this.btnMostrar_Salas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostrar_Salas.BackColor = System.Drawing.Color.Maroon;
            this.btnMostrar_Salas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrar_Salas.BorderRadius = 0;
            this.btnMostrar_Salas.ButtonText = "Mostrar Salas";
            this.btnMostrar_Salas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar_Salas.DisabledColor = System.Drawing.Color.Gray;
            this.btnMostrar_Salas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMostrar_Salas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMostrar_Salas.Iconimage")));
            this.btnMostrar_Salas.Iconimage_right = null;
            this.btnMostrar_Salas.Iconimage_right_Selected = null;
            this.btnMostrar_Salas.Iconimage_Selected = null;
            this.btnMostrar_Salas.IconMarginLeft = 0;
            this.btnMostrar_Salas.IconMarginRight = 0;
            this.btnMostrar_Salas.IconRightVisible = true;
            this.btnMostrar_Salas.IconRightZoom = 0D;
            this.btnMostrar_Salas.IconVisible = true;
            this.btnMostrar_Salas.IconZoom = 80D;
            this.btnMostrar_Salas.IsTab = false;
            this.btnMostrar_Salas.Location = new System.Drawing.Point(258, 175);
            this.btnMostrar_Salas.Name = "btnMostrar_Salas";
            this.btnMostrar_Salas.Normalcolor = System.Drawing.Color.Maroon;
            this.btnMostrar_Salas.OnHovercolor = System.Drawing.Color.Brown;
            this.btnMostrar_Salas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMostrar_Salas.selected = false;
            this.btnMostrar_Salas.Size = new System.Drawing.Size(241, 48);
            this.btnMostrar_Salas.TabIndex = 5;
            this.btnMostrar_Salas.Text = "Mostrar Salas";
            this.btnMostrar_Salas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrar_Salas.Textcolor = System.Drawing.Color.White;
            this.btnMostrar_Salas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar_Salas.Click += new System.EventHandler(this.BtnMostrar_Salas_Click);
            // 
            // btnAgregar_Sala
            // 
            this.btnAgregar_Sala.Activecolor = System.Drawing.Color.Maroon;
            this.btnAgregar_Sala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar_Sala.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregar_Sala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar_Sala.BorderRadius = 0;
            this.btnAgregar_Sala.ButtonText = "Agregar Sala";
            this.btnAgregar_Sala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar_Sala.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar_Sala.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar_Sala.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregar_Sala.Iconimage")));
            this.btnAgregar_Sala.Iconimage_right = null;
            this.btnAgregar_Sala.Iconimage_right_Selected = null;
            this.btnAgregar_Sala.Iconimage_Selected = null;
            this.btnAgregar_Sala.IconMarginLeft = 0;
            this.btnAgregar_Sala.IconMarginRight = 0;
            this.btnAgregar_Sala.IconRightVisible = true;
            this.btnAgregar_Sala.IconRightZoom = 0D;
            this.btnAgregar_Sala.IconVisible = true;
            this.btnAgregar_Sala.IconZoom = 80D;
            this.btnAgregar_Sala.IsTab = false;
            this.btnAgregar_Sala.Location = new System.Drawing.Point(11, 175);
            this.btnAgregar_Sala.Name = "btnAgregar_Sala";
            this.btnAgregar_Sala.Normalcolor = System.Drawing.Color.Maroon;
            this.btnAgregar_Sala.OnHovercolor = System.Drawing.Color.Brown;
            this.btnAgregar_Sala.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar_Sala.selected = false;
            this.btnAgregar_Sala.Size = new System.Drawing.Size(241, 48);
            this.btnAgregar_Sala.TabIndex = 4;
            this.btnAgregar_Sala.Text = "Agregar Sala";
            this.btnAgregar_Sala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar_Sala.Textcolor = System.Drawing.Color.White;
            this.btnAgregar_Sala.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar_Sala.Click += new System.EventHandler(this.BtnAgregar_Sala_Click);
            // 
            // epError2
            // 
            this.epError2.ContainerControl = this;
            // 
            // FrmSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 547);
            this.Controls.Add(this.grpRegistro_Sala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSala";
            this.Text = "Frmdistribuidoras";
            this.Load += new System.EventHandler(this.FrmSala_Load);
            this.grpRegistro_Sala.ResumeLayout(false);
            this.grpRegistro_Sala.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistro_Sala;
        private System.Windows.Forms.DataGridView dgvSalas;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar_Sala;
        private Bunifu.Framework.UI.BunifuFlatButton btnActualizar_Sala;
        private Bunifu.Framework.UI.BunifuFlatButton btnMostrar_Salas;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar_Sala;
        private System.Windows.Forms.Label lblEstado_Sala;
        private System.Windows.Forms.TextBox txtCapacidad_Sala;
        private System.Windows.Forms.Label lblCapacidad_Sala;
        private System.Windows.Forms.TextBox txtID_Sala;
        private System.Windows.Forms.TextBox txtNumero_Sala;
        private System.Windows.Forms.Label lblNumero_Sala;
        private System.Windows.Forms.ErrorProvider epError2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ComboBox cmbESTADO_SALA;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
    }
}