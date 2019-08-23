namespace EXPO60.Vista
{
    partial class FrmNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.btnmaximizar = new System.Windows.Forms.ToolStripButton();
            this.btnnormal = new System.Windows.Forms.ToolStripButton();
            this.btnminimizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolbtnCerrar_Sesion = new System.Windows.Forms.ToolStripButton();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picimg = new System.Windows.Forms.PictureBox();
            this.picimgL = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimgL)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton6,
            this.btnmaximizar,
            this.btnnormal,
            this.btnminimizar,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolbtnCerrar_Sesion});
            this.toolStrip1.Location = new System.Drawing.Point(243, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1025, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStrip1_MouseDown);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton1";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Cerrar";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnmaximizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(23, 22);
            this.btnmaximizar.Text = "Maximizar";
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnnormal
            // 
            this.btnnormal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnnormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnnormal.Image = ((System.Drawing.Image)(resources.GetObject("btnnormal.Image")));
            this.btnnormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnormal.Name = "btnnormal";
            this.btnnormal.Size = new System.Drawing.Size(23, 22);
            this.btnnormal.Text = "Restaurar a tamaño normal";
            this.btnnormal.Visible = false;
            this.btnnormal.Click += new System.EventHandler(this.btnnormal_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnminimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(23, 22);
            this.btnminimizar.Text = "Minimizar";
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Cerrar Formulario";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Cerrar Formulario";
            // 
            // toolbtnCerrar_Sesion
            // 
            this.toolbtnCerrar_Sesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolbtnCerrar_Sesion.Image = global::EXPO60.Properties.Resources.change_power_options;
            this.toolbtnCerrar_Sesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnCerrar_Sesion.Name = "toolbtnCerrar_Sesion";
            this.toolbtnCerrar_Sesion.Size = new System.Drawing.Size(96, 22);
            this.toolbtnCerrar_Sesion.Text = "Cerrar Sesion";
            this.toolbtnCerrar_Sesion.Click += new System.EventHandler(this.ToolbtnCerrar_Sesion_Click_1);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(243, 25);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1025, 547);
            this.PanelContenedor.TabIndex = 2;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuVertical.BackgroundImage")));
            this.MenuVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuVertical.Controls.Add(this.btnInicio);
            this.MenuVertical.Controls.Add(this.picimg);
            this.MenuVertical.Controls.Add(this.picimgL);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.GradientBottomLeft = System.Drawing.Color.Red;
            this.MenuVertical.GradientBottomRight = System.Drawing.Color.Red;
            this.MenuVertical.GradientTopLeft = System.Drawing.Color.Maroon;
            this.MenuVertical.GradientTopRight = System.Drawing.Color.Black;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Quality = 10;
            this.MenuVertical.Size = new System.Drawing.Size(243, 572);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.Maroon;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "Inicio";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = global::EXPO60.Properties.Resources.home_96px;
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 90D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(3, 277);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHovercolor = System.Drawing.Color.DarkRed;
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(213, 46);
            this.btnInicio.TabIndex = 57;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInicio.Textcolor = System.Drawing.Color.White;
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // picimg
            // 
            this.picimg.Image = ((System.Drawing.Image)(resources.GetObject("picimg.Image")));
            this.picimg.Location = new System.Drawing.Point(0, 0);
            this.picimg.Name = "picimg";
            this.picimg.Size = new System.Drawing.Size(76, 61);
            this.picimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimg.TabIndex = 45;
            this.picimg.TabStop = false;
            this.picimg.Visible = false;
            // 
            // picimgL
            // 
            this.picimgL.BackColor = System.Drawing.Color.Transparent;
            this.picimgL.Dock = System.Windows.Forms.DockStyle.Top;
            this.picimgL.Image = ((System.Drawing.Image)(resources.GetObject("picimgL.Image")));
            this.picimgL.Location = new System.Drawing.Point(0, 0);
            this.picimgL.Name = "picimgL";
            this.picimgL.Size = new System.Drawing.Size(243, 61);
            this.picimgL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimgL.TabIndex = 46;
            this.picimgL.TabStop = false;
            // 
            // FrmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 572);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevo";
            this.Load += new System.EventHandler(this.FrmNuevo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimgL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton btnmaximizar;
        private System.Windows.Forms.ToolStripButton btnnormal;
        private System.Windows.Forms.ToolStripButton btnminimizar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel PanelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private System.Windows.Forms.PictureBox picimgL;
        private System.Windows.Forms.PictureBox picimg;
        private Bunifu.Framework.UI.BunifuGradientPanel MenuVertical;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolbtnCerrar_Sesion;
    }
}