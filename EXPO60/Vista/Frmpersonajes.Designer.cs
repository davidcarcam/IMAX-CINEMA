﻿namespace EXPO60.Vista
{
    partial class FrmPersonajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonajes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cmbactor = new System.Windows.Forms.ComboBox();
            this.cmbpelicula = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgvpersonajes = new System.Windows.Forms.DataGridView();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnactualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnmostrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnagregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Controls.Add(this.cmbactor);
            this.groupBox1.Controls.Add(this.cmbpelicula);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.dgvpersonajes);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnactualizar);
            this.groupBox1.Controls.Add(this.btnmostrar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de personajes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(375, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 81;
            this.label11.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbuscar.Location = new System.Drawing.Point(452, 112);
            this.txtbuscar.MaxLength = 50;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(144, 20);
            this.txtbuscar.TabIndex = 80;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // cmbactor
            // 
            this.cmbactor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbactor.FormattingEnabled = true;
            this.cmbactor.Location = new System.Drawing.Point(830, 63);
            this.cmbactor.Name = "cmbactor";
            this.cmbactor.Size = new System.Drawing.Size(153, 21);
            this.cmbactor.TabIndex = 3;
            // 
            // cmbpelicula
            // 
            this.cmbpelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbpelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpelicula.FormattingEnabled = true;
            this.cmbpelicula.Location = new System.Drawing.Point(534, 63);
            this.cmbpelicula.Name = "cmbpelicula";
            this.cmbpelicula.Size = new System.Drawing.Size(153, 21);
            this.cmbpelicula.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
            this.toolStrip1.TabIndex = 59;
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
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.Location = new System.Drawing.Point(137, 121);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(28, 20);
            this.txtid.TabIndex = 0;
            this.txtid.Visible = false;
            // 
            // dgvpersonajes
            // 
            this.dgvpersonajes.AllowUserToAddRows = false;
            this.dgvpersonajes.AllowUserToDeleteRows = false;
            this.dgvpersonajes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvpersonajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonajes.Location = new System.Drawing.Point(12, 241);
            this.dgvpersonajes.Name = "dgvpersonajes";
            this.dgvpersonajes.Size = new System.Drawing.Size(1001, 265);
            this.dgvpersonajes.TabIndex = 0;
            this.dgvpersonajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonajes_CellClick_1);
            this.dgvpersonajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonajes_CellContentClick);
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
            this.btneliminar.Location = new System.Drawing.Point(772, 170);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.Maroon;
            this.btneliminar.OnHovercolor = System.Drawing.Color.Brown;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = false;
            this.btneliminar.Size = new System.Drawing.Size(241, 48);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnactualizar.Location = new System.Drawing.Point(516, 170);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnactualizar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnactualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnactualizar.selected = false;
            this.btnactualizar.Size = new System.Drawing.Size(241, 48);
            this.btnactualizar.TabIndex = 6;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnmostrar.Location = new System.Drawing.Point(260, 170);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnmostrar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnmostrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmostrar.selected = false;
            this.btnmostrar.Size = new System.Drawing.Size(241, 48);
            this.btnmostrar.TabIndex = 5;
            this.btnmostrar.Text = "Mostrar y Limpiar Campos";
            this.btnmostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnmostrar.Textcolor = System.Drawing.Color.White;
            this.btnmostrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
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
            this.btnagregar.Location = new System.Drawing.Point(4, 170);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnagregar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnagregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnagregar.selected = false;
            this.btnagregar.Size = new System.Drawing.Size(241, 48);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnagregar.Textcolor = System.Drawing.Color.White;
            this.btnagregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(735, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Actor";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pelicula";
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.Location = new System.Drawing.Point(222, 63);
            this.txtnombre.MaxLength = 60;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(153, 20);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del personaje";
            // 
            // FrmPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 547);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonajes";
            this.Text = "FrmPersonajes";
            this.Load += new System.EventHandler(this.FrmPersonajes_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvpersonajes;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnactualizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnmostrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnagregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.ComboBox cmbactor;
        private System.Windows.Forms.ComboBox cmbpelicula;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}