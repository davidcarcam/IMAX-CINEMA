namespace EXPO60.Vista
{
    partial class FrmBoleteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoleteria));
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDEsc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnumsala = new System.Windows.Forms.TextBox();
            this.txtclasificacion = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtFuncion_titulo = new System.Windows.Forms.TextBox();
            this.dgvfunciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnagregar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(659, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tipo de descuento";
            // 
            // cmbDEsc
            // 
            this.cmbDEsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDEsc.FormattingEnabled = true;
            this.cmbDEsc.Items.AddRange(new object[] {
            "Adulto",
            "Estudiante",
            "Niño",
            "Adulto Mayor"});
            this.cmbDEsc.Location = new System.Drawing.Point(807, 33);
            this.cmbDEsc.Name = "cmbDEsc";
            this.cmbDEsc.Size = new System.Drawing.Size(121, 21);
            this.cmbDEsc.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Subtotal";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Cantidad de boletos";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(183, 79);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 1;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(807, 81);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtsubtotal.TabIndex = 50;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(473, 59);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(21, 20);
            this.txtprecio.TabIndex = 49;
            this.txtprecio.Visible = false;
            // 
            // txtnumsala
            // 
            this.txtnumsala.Location = new System.Drawing.Point(398, 95);
            this.txtnumsala.Name = "txtnumsala";
            this.txtnumsala.Size = new System.Drawing.Size(21, 20);
            this.txtnumsala.TabIndex = 7;
            this.txtnumsala.Visible = false;
            // 
            // txtclasificacion
            // 
            this.txtclasificacion.Location = new System.Drawing.Point(334, 59);
            this.txtclasificacion.Name = "txtclasificacion";
            this.txtclasificacion.Size = new System.Drawing.Size(21, 20);
            this.txtclasificacion.TabIndex = 6;
            this.txtclasificacion.Visible = false;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(348, 19);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(21, 20);
            this.txtDuracion.TabIndex = 5;
            this.txtDuracion.Visible = false;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(417, 59);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(21, 20);
            this.txtfecha.TabIndex = 4;
            this.txtfecha.Visible = false;
            // 
            // txtFuncion_titulo
            // 
            this.txtFuncion_titulo.Location = new System.Drawing.Point(453, 19);
            this.txtFuncion_titulo.Name = "txtFuncion_titulo";
            this.txtFuncion_titulo.Size = new System.Drawing.Size(21, 20);
            this.txtFuncion_titulo.TabIndex = 3;
            this.txtFuncion_titulo.Visible = false;
            // 
            // dgvfunciones
            // 
            this.dgvfunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfunciones.Location = new System.Drawing.Point(30, 220);
            this.dgvfunciones.Name = "dgvfunciones";
            this.dgvfunciones.Size = new System.Drawing.Size(944, 269);
            this.dgvfunciones.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbDEsc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsubtotal);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txtnumsala);
            this.groupBox1.Controls.Add(this.txtclasificacion);
            this.groupBox1.Controls.Add(this.txtDuracion);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.txtFuncion_titulo);
            this.groupBox1.Controls.Add(this.txthora);
            this.groupBox1.Controls.Add(this.dgvfunciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 534);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boleteria";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 52;
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(371, 59);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(21, 20);
            this.txthora.TabIndex = 2;
            this.txthora.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 3;
            this.bunifuFlatButton1.ButtonText = "Imprimir ticket";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(519, 150);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Brown;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 57;
            this.bunifuFlatButton1.Text = "Imprimir ticket";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnagregar
            // 
            this.btnagregar.Activecolor = System.Drawing.Color.Maroon;
            this.btnagregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnagregar.BackColor = System.Drawing.Color.Maroon;
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.BorderRadius = 3;
            this.btnagregar.ButtonText = "Agregar ticket";
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
            this.btnagregar.Location = new System.Drawing.Point(209, 150);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Normalcolor = System.Drawing.Color.Maroon;
            this.btnagregar.OnHovercolor = System.Drawing.Color.Brown;
            this.btnagregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnagregar.selected = false;
            this.btnagregar.Size = new System.Drawing.Size(241, 48);
            this.btnagregar.TabIndex = 48;
            this.btnagregar.Text = "Agregar ticket";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnagregar.Textcolor = System.Drawing.Color.White;
            this.btnagregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // FrmBoleteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 547);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBoleteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBoleteria";
            this.Load += new System.EventHandler(this.FrmBoleteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDEsc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtprecio;
        private Bunifu.Framework.UI.BunifuFlatButton btnagregar;
        private System.Windows.Forms.TextBox txtnumsala;
        private System.Windows.Forms.TextBox txtclasificacion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtFuncion_titulo;
        private System.Windows.Forms.DataGridView dgvfunciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthora;
    }
}