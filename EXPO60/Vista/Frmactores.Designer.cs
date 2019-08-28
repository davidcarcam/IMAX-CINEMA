namespace EXPO60.Vista
{
    partial class FrmActores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActores));
            this.grpActores = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCerrar = new System.Windows.Forms.ToolStripButton();
            this.dgvActores = new System.Windows.Forms.DataGridView();
            this.txtID_Actor = new System.Windows.Forms.TextBox();
            this.btnEliminar_Actor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnActualizar_Actor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMostrar_Actores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar_Actor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtactor = new System.Windows.Forms.TextBox();
            this.lblNombre_Actor = new System.Windows.Forms.Label();
            this.epError3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpActores.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError3)).BeginInit();
            this.SuspendLayout();
            // 
            // grpActores
            // 
            this.grpActores.Controls.Add(this.label8);
            this.grpActores.Controls.Add(this.txtbuscar);
            this.grpActores.Controls.Add(this.toolStrip1);
            this.grpActores.Controls.Add(this.dgvActores);
            this.grpActores.Controls.Add(this.txtID_Actor);
            this.grpActores.Controls.Add(this.btnEliminar_Actor);
            this.grpActores.Controls.Add(this.btnActualizar_Actor);
            this.grpActores.Controls.Add(this.btnMostrar_Actores);
            this.grpActores.Controls.Add(this.btnAgregar_Actor);
            this.grpActores.Controls.Add(this.txtactor);
            this.grpActores.Controls.Add(this.lblNombre_Actor);
            this.grpActores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpActores.Location = new System.Drawing.Point(0, 0);
            this.grpActores.Name = "grpActores";
            this.grpActores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpActores.Size = new System.Drawing.Size(1237, 570);
            this.grpActores.TabIndex = 1;
            this.grpActores.TabStop = false;
            this.grpActores.Text = "Registro de actores";
            this.grpActores.Resize += new System.EventHandler(this.GrpActores_Resize);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(903, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(977, 99);
            this.txtbuscar.MaxLength = 50;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(182, 20);
            this.txtbuscar.TabIndex = 68;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1231, 25);
            this.toolStrip1.TabIndex = 48;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Resize += new System.EventHandler(this.ToolStrip1_Resize);
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
            // dgvActores
            // 
            this.dgvActores.AllowUserToAddRows = false;
            this.dgvActores.AllowUserToDeleteRows = false;
            this.dgvActores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActores.Location = new System.Drawing.Point(79, 236);
            this.dgvActores.Name = "dgvActores";
            this.dgvActores.Size = new System.Drawing.Size(1042, 298);
            this.dgvActores.TabIndex = 0;
            this.dgvActores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActores_CellClick);
            // 
            // txtID_Actor
            // 
            this.txtID_Actor.Location = new System.Drawing.Point(613, 54);
            this.txtID_Actor.Name = "txtID_Actor";
            this.txtID_Actor.Size = new System.Drawing.Size(35, 20);
            this.txtID_Actor.TabIndex = 0;
            this.txtID_Actor.Visible = false;
            // 
            // btnEliminar_Actor
            // 
            this.btnEliminar_Actor.Activecolor = System.Drawing.Color.Maroon;
            this.btnEliminar_Actor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar_Actor.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar_Actor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar_Actor.BorderRadius = 0;
            this.btnEliminar_Actor.ButtonText = "Eliminar Actor";
            this.btnEliminar_Actor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar_Actor.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar_Actor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar_Actor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar_Actor.Iconimage")));
            this.btnEliminar_Actor.Iconimage_right = null;
            this.btnEliminar_Actor.Iconimage_right_Selected = null;
            this.btnEliminar_Actor.Iconimage_Selected = null;
            this.btnEliminar_Actor.IconMarginLeft = 0;
            this.btnEliminar_Actor.IconMarginRight = 0;
            this.btnEliminar_Actor.IconRightVisible = true;
            this.btnEliminar_Actor.IconRightZoom = 0D;
            this.btnEliminar_Actor.IconVisible = true;
            this.btnEliminar_Actor.IconZoom = 80D;
            this.btnEliminar_Actor.IsTab = false;
            this.btnEliminar_Actor.Location = new System.Drawing.Point(880, 162);
            this.btnEliminar_Actor.Name = "btnEliminar_Actor";
            this.btnEliminar_Actor.Normalcolor = System.Drawing.Color.Maroon;
            this.btnEliminar_Actor.OnHovercolor = System.Drawing.Color.Brown;
            this.btnEliminar_Actor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar_Actor.selected = false;
            this.btnEliminar_Actor.Size = new System.Drawing.Size(241, 48);
            this.btnEliminar_Actor.TabIndex = 5;
            this.btnEliminar_Actor.Text = "Eliminar Actor";
            this.btnEliminar_Actor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar_Actor.Textcolor = System.Drawing.Color.White;
            this.btnEliminar_Actor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Actor.Click += new System.EventHandler(this.BtnEliminar_Actor_Click);
            // 
            // btnActualizar_Actor
            // 
            this.btnActualizar_Actor.Activecolor = System.Drawing.Color.Maroon;
            this.btnActualizar_Actor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar_Actor.BackColor = System.Drawing.Color.Maroon;
            this.btnActualizar_Actor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar_Actor.BorderRadius = 0;
            this.btnActualizar_Actor.ButtonText = "Actualizar Actor";
            this.btnActualizar_Actor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar_Actor.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizar_Actor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizar_Actor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnActualizar_Actor.Iconimage")));
            this.btnActualizar_Actor.Iconimage_right = null;
            this.btnActualizar_Actor.Iconimage_right_Selected = null;
            this.btnActualizar_Actor.Iconimage_Selected = null;
            this.btnActualizar_Actor.IconMarginLeft = 0;
            this.btnActualizar_Actor.IconMarginRight = 0;
            this.btnActualizar_Actor.IconRightVisible = true;
            this.btnActualizar_Actor.IconRightZoom = 0D;
            this.btnActualizar_Actor.IconVisible = true;
            this.btnActualizar_Actor.IconZoom = 80D;
            this.btnActualizar_Actor.IsTab = false;
            this.btnActualizar_Actor.Location = new System.Drawing.Point(613, 162);
            this.btnActualizar_Actor.Name = "btnActualizar_Actor";
            this.btnActualizar_Actor.Normalcolor = System.Drawing.Color.Maroon;
            this.btnActualizar_Actor.OnHovercolor = System.Drawing.Color.Brown;
            this.btnActualizar_Actor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnActualizar_Actor.selected = false;
            this.btnActualizar_Actor.Size = new System.Drawing.Size(241, 48);
            this.btnActualizar_Actor.TabIndex = 4;
            this.btnActualizar_Actor.Text = "Actualizar Actor";
            this.btnActualizar_Actor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar_Actor.Textcolor = System.Drawing.Color.White;
            this.btnActualizar_Actor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar_Actor.Click += new System.EventHandler(this.BtnActualizar_Actor_Click);
            // 
            // btnMostrar_Actores
            // 
            this.btnMostrar_Actores.Activecolor = System.Drawing.Color.Maroon;
            this.btnMostrar_Actores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostrar_Actores.BackColor = System.Drawing.Color.Maroon;
            this.btnMostrar_Actores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrar_Actores.BorderRadius = 0;
            this.btnMostrar_Actores.ButtonText = "Mostrar Actores";
            this.btnMostrar_Actores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar_Actores.DisabledColor = System.Drawing.Color.Gray;
            this.btnMostrar_Actores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMostrar_Actores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMostrar_Actores.Iconimage")));
            this.btnMostrar_Actores.Iconimage_right = null;
            this.btnMostrar_Actores.Iconimage_right_Selected = null;
            this.btnMostrar_Actores.Iconimage_Selected = null;
            this.btnMostrar_Actores.IconMarginLeft = 0;
            this.btnMostrar_Actores.IconMarginRight = 0;
            this.btnMostrar_Actores.IconRightVisible = true;
            this.btnMostrar_Actores.IconRightZoom = 0D;
            this.btnMostrar_Actores.IconVisible = true;
            this.btnMostrar_Actores.IconZoom = 80D;
            this.btnMostrar_Actores.IsTab = false;
            this.btnMostrar_Actores.Location = new System.Drawing.Point(346, 162);
            this.btnMostrar_Actores.Name = "btnMostrar_Actores";
            this.btnMostrar_Actores.Normalcolor = System.Drawing.Color.Maroon;
            this.btnMostrar_Actores.OnHovercolor = System.Drawing.Color.Brown;
            this.btnMostrar_Actores.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMostrar_Actores.selected = false;
            this.btnMostrar_Actores.Size = new System.Drawing.Size(241, 48);
            this.btnMostrar_Actores.TabIndex = 3;
            this.btnMostrar_Actores.Text = "Mostrar Actores";
            this.btnMostrar_Actores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrar_Actores.Textcolor = System.Drawing.Color.White;
            this.btnMostrar_Actores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar_Actores.Click += new System.EventHandler(this.BtnMostrar_Actores_Click);
            // 
            // btnAgregar_Actor
            // 
            this.btnAgregar_Actor.Activecolor = System.Drawing.Color.Maroon;
            this.btnAgregar_Actor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar_Actor.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregar_Actor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar_Actor.BorderRadius = 0;
            this.btnAgregar_Actor.ButtonText = "Agregar Actor";
            this.btnAgregar_Actor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar_Actor.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar_Actor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar_Actor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregar_Actor.Iconimage")));
            this.btnAgregar_Actor.Iconimage_right = null;
            this.btnAgregar_Actor.Iconimage_right_Selected = null;
            this.btnAgregar_Actor.Iconimage_Selected = null;
            this.btnAgregar_Actor.IconMarginLeft = 0;
            this.btnAgregar_Actor.IconMarginRight = 0;
            this.btnAgregar_Actor.IconRightVisible = true;
            this.btnAgregar_Actor.IconRightZoom = 0D;
            this.btnAgregar_Actor.IconVisible = true;
            this.btnAgregar_Actor.IconZoom = 80D;
            this.btnAgregar_Actor.IsTab = false;
            this.btnAgregar_Actor.Location = new System.Drawing.Point(79, 162);
            this.btnAgregar_Actor.Name = "btnAgregar_Actor";
            this.btnAgregar_Actor.Normalcolor = System.Drawing.Color.Maroon;
            this.btnAgregar_Actor.OnHovercolor = System.Drawing.Color.Brown;
            this.btnAgregar_Actor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar_Actor.selected = false;
            this.btnAgregar_Actor.Size = new System.Drawing.Size(241, 48);
            this.btnAgregar_Actor.TabIndex = 2;
            this.btnAgregar_Actor.Text = "Agregar Actor";
            this.btnAgregar_Actor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar_Actor.Textcolor = System.Drawing.Color.White;
            this.btnAgregar_Actor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar_Actor.Click += new System.EventHandler(this.BtnAgregar_Actor_Click);
            // 
            // txtactor
            // 
            this.txtactor.Location = new System.Drawing.Point(313, 99);
            this.txtactor.MaxLength = 100;
            this.txtactor.Name = "txtactor";
            this.txtactor.Size = new System.Drawing.Size(404, 20);
            this.txtactor.TabIndex = 1;
            this.txtactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_Actor_KeyPress);
            this.txtactor.Validated += new System.EventHandler(this.TxtNombre_Actor_Validated);
            // 
            // lblNombre_Actor
            // 
            this.lblNombre_Actor.AutoSize = true;
            this.lblNombre_Actor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_Actor.Location = new System.Drawing.Point(173, 97);
            this.lblNombre_Actor.Name = "lblNombre_Actor";
            this.lblNombre_Actor.Size = new System.Drawing.Size(134, 20);
            this.lblNombre_Actor.TabIndex = 0;
            this.lblNombre_Actor.Text = "Nombre del actor:";
            this.lblNombre_Actor.Click += new System.EventHandler(this.lblNombre_Actor_Click);
            // 
            // epError3
            // 
            this.epError3.ContainerControl = this;
            // 
            // FrmActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 570);
            this.ControlBox = false;
            this.Controls.Add(this.grpActores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmActores";
            this.Text = "Frmactores";
            this.Load += new System.EventHandler(this.FrmActores_Load);
            this.grpActores.ResumeLayout(false);
            this.grpActores.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpActores;
        private System.Windows.Forms.DataGridView dgvActores;
        private System.Windows.Forms.TextBox txtID_Actor;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar_Actor;
        private Bunifu.Framework.UI.BunifuFlatButton btnActualizar_Actor;
        private Bunifu.Framework.UI.BunifuFlatButton btnMostrar_Actores;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar_Actor;
        private System.Windows.Forms.TextBox txtactor;
        private System.Windows.Forms.Label lblNombre_Actor;
        private System.Windows.Forms.ErrorProvider epError3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCerrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}