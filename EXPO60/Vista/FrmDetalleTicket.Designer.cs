namespace EXPO60.Vista
{
    partial class FrmDetalleTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleTicket));
            this.grpDetalleTicket = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.btnagregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.cmbfuncion = new System.Windows.Forms.ComboBox();
            this.cmbAsiento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idDetalletic = new System.Windows.Forms.TextBox();
            this.dgvtickets = new System.Windows.Forms.DataGridView();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnactualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmostrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDetalleTicket = new System.Windows.Forms.ToolStripButton();
            this.grpDetalleTicket.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtickets)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDetalleTicket
            // 
            this.grpDetalleTicket.Controls.Add(this.label1);
            this.grpDetalleTicket.Controls.Add(this.txtbuscar);
            this.grpDetalleTicket.Controls.Add(this.txtNum);
            this.grpDetalleTicket.Controls.Add(this.txtFila);
            this.grpDetalleTicket.Controls.Add(this.btnagregar);
            this.grpDetalleTicket.Controls.Add(this.toolStrip1);
            this.grpDetalleTicket.Controls.Add(this.cmbfuncion);
            this.grpDetalleTicket.Controls.Add(this.cmbAsiento);
            this.grpDetalleTicket.Controls.Add(this.label9);
            this.grpDetalleTicket.Controls.Add(this.label8);
            this.grpDetalleTicket.Controls.Add(this.idDetalletic);
            this.grpDetalleTicket.Controls.Add(this.dgvtickets);
            this.grpDetalleTicket.Controls.Add(this.btneliminar);
            this.grpDetalleTicket.Controls.Add(this.btnactualizar);
            this.grpDetalleTicket.Controls.Add(this.btnmostrar);
            this.grpDetalleTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetalleTicket.Location = new System.Drawing.Point(0, 0);
            this.grpDetalleTicket.Name = "grpDetalleTicket";
            this.grpDetalleTicket.Size = new System.Drawing.Size(1009, 597);
            this.grpDetalleTicket.TabIndex = 0;
            this.grpDetalleTicket.TabStop = false;
            this.grpDetalleTicket.Enter += new System.EventHandler(this.grpDetalleTicket_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(750, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbuscar.Location = new System.Drawing.Point(827, 98);
            this.txtbuscar.MaxLength = 50;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(144, 20);
            this.txtbuscar.TabIndex = 3;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.Control;
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Location = new System.Drawing.Point(412, 67);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(32, 13);
            this.txtNum.TabIndex = 50;
            // 
            // txtFila
            // 
            this.txtFila.BackColor = System.Drawing.SystemColors.Control;
            this.txtFila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFila.Location = new System.Drawing.Point(813, 128);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(22, 13);
            this.txtFila.TabIndex = 49;
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
            this.btnagregar.Location = new System.Drawing.Point(7, 213);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnagregar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnagregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnagregar.selected = false;
            this.btnagregar.Size = new System.Drawing.Size(241, 48);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnagregar.Textcolor = System.Drawing.Color.White;
            this.btnagregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar,
            this.BtnDetalleTicket});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1003, 25);
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
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // cmbfuncion
            // 
            this.cmbfuncion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbfuncion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbfuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfuncion.FormattingEnabled = true;
            this.cmbfuncion.Location = new System.Drawing.Point(184, 101);
            this.cmbfuncion.Name = "cmbfuncion";
            this.cmbfuncion.Size = new System.Drawing.Size(195, 21);
            this.cmbfuncion.TabIndex = 1;
            // 
            // cmbAsiento
            // 
            this.cmbAsiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAsiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsiento.FormattingEnabled = true;
            this.cmbAsiento.Location = new System.Drawing.Point(555, 101);
            this.cmbAsiento.Name = "cmbAsiento";
            this.cmbAsiento.Size = new System.Drawing.Size(176, 21);
            this.cmbAsiento.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Asiento Asignado";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Funcion";
            // 
            // idDetalletic
            // 
            this.idDetalletic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idDetalletic.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.idDetalletic.Location = new System.Drawing.Point(700, 44);
            this.idDetalletic.Name = "idDetalletic";
            this.idDetalletic.Size = new System.Drawing.Size(31, 20);
            this.idDetalletic.TabIndex = 0;
            this.idDetalletic.Visible = false;
            // 
            // dgvtickets
            // 
            this.dgvtickets.AllowUserToDeleteRows = false;
            this.dgvtickets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvtickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtickets.Location = new System.Drawing.Point(12, 283);
            this.dgvtickets.Name = "dgvtickets";
            this.dgvtickets.Size = new System.Drawing.Size(980, 281);
            this.dgvtickets.TabIndex = 0;
            this.dgvtickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtickets_CellContentClick);
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
            this.btneliminar.Location = new System.Drawing.Point(763, 213);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.Maroon;
            this.btneliminar.OnHovercolor = System.Drawing.Color.Brown;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = false;
            this.btneliminar.Size = new System.Drawing.Size(241, 48);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneliminar.Textcolor = System.Drawing.Color.White;
            this.btneliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnactualizar.Location = new System.Drawing.Point(511, 213);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnactualizar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnactualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnactualizar.selected = false;
            this.btnactualizar.Size = new System.Drawing.Size(241, 48);
            this.btnactualizar.TabIndex = 5;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnactualizar.Textcolor = System.Drawing.Color.White;
            this.btnactualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnmostrar.Location = new System.Drawing.Point(259, 213);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnmostrar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnmostrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmostrar.selected = false;
            this.btnmostrar.Size = new System.Drawing.Size(241, 48);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "Mostrar y Limpiar Campos";
            this.btnmostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnmostrar.Textcolor = System.Drawing.Color.White;
            this.btnmostrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // BtnDetalleTicket
            // 
            this.BtnDetalleTicket.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnDetalleTicket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDetalleTicket.Image = ((System.Drawing.Image)(resources.GetObject("BtnDetalleTicket.Image")));
            this.BtnDetalleTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDetalleTicket.Name = "BtnDetalleTicket";
            this.BtnDetalleTicket.Size = new System.Drawing.Size(23, 22);
            // 
            // FrmDetalleTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 597);
            this.Controls.Add(this.grpDetalleTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetalleTicket";
            this.Text = "FrmDetalleTicket";
            this.Load += new System.EventHandler(this.FrmDetalleTicket_Load);
            this.grpDetalleTicket.ResumeLayout(false);
            this.grpDetalleTicket.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetalleTicket;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtFila;
        private Bunifu.Framework.UI.BunifuFlatButton btnagregar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ComboBox cmbfuncion;
        private System.Windows.Forms.ComboBox cmbAsiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idDetalletic;
        private System.Windows.Forms.DataGridView dgvtickets;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnactualizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnmostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ToolStripButton BtnDetalleTicket;
    }
}