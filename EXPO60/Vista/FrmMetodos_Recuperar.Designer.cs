namespace EXPO60.Vista
{
    partial class FrmMetodos_Recuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMetodos_Recuperar));
            this.toolStripMetodos = new System.Windows.Forms.ToolStrip();
            this.btntoolCerrar_Metodos = new System.Windows.Forms.ToolStripButton();
            this.toollblMetodos = new System.Windows.Forms.ToolStripLabel();
            this.menuStripBotones_Metodos = new System.Windows.Forms.MenuStrip();
            this.MenuItemCorreo_Recuperacion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPreguntas_Recuperacion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemContactar_Administrador = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMetodos = new System.Windows.Forms.Panel();
            this.panelMetodo_Mostrar = new System.Windows.Forms.Panel();
            this.toolStripMetodos.SuspendLayout();
            this.menuStripBotones_Metodos.SuspendLayout();
            this.panelMetodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMetodos
            // 
            this.toolStripMetodos.AutoSize = false;
            this.toolStripMetodos.BackColor = System.Drawing.Color.White;
            this.toolStripMetodos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btntoolCerrar_Metodos,
            this.toollblMetodos});
            this.toolStripMetodos.Location = new System.Drawing.Point(0, 0);
            this.toolStripMetodos.Name = "toolStripMetodos";
            this.toolStripMetodos.Size = new System.Drawing.Size(960, 25);
            this.toolStripMetodos.TabIndex = 0;
            this.toolStripMetodos.Text = "toolStrip1";
            this.toolStripMetodos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripMetodos_MouseDown);
            // 
            // btntoolCerrar_Metodos
            // 
            this.btntoolCerrar_Metodos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btntoolCerrar_Metodos.BackColor = System.Drawing.Color.DarkRed;
            this.btntoolCerrar_Metodos.ForeColor = System.Drawing.Color.White;
            this.btntoolCerrar_Metodos.Image = ((System.Drawing.Image)(resources.GetObject("btntoolCerrar_Metodos.Image")));
            this.btntoolCerrar_Metodos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntoolCerrar_Metodos.Name = "btntoolCerrar_Metodos";
            this.btntoolCerrar_Metodos.Size = new System.Drawing.Size(166, 22);
            this.btntoolCerrar_Metodos.Text = "Regresar a inicio de cesion";
            this.btntoolCerrar_Metodos.Click += new System.EventHandler(this.BtntoolCerrar_Metodos_Click);
            // 
            // toollblMetodos
            // 
            this.toollblMetodos.Name = "toollblMetodos";
            this.toollblMetodos.Size = new System.Drawing.Size(219, 22);
            this.toollblMetodos.Text = "Metodos de recuperacion de contrasena";
            // 
            // menuStripBotones_Metodos
            // 
            this.menuStripBotones_Metodos.AutoSize = false;
            this.menuStripBotones_Metodos.BackColor = System.Drawing.Color.DarkRed;
            this.menuStripBotones_Metodos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCorreo_Recuperacion,
            this.toolStripMenuItem1,
            this.MenuItemPreguntas_Recuperacion,
            this.MenuItemContactar_Administrador});
            this.menuStripBotones_Metodos.Location = new System.Drawing.Point(0, 0);
            this.menuStripBotones_Metodos.Name = "menuStripBotones_Metodos";
            this.menuStripBotones_Metodos.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.menuStripBotones_Metodos.Size = new System.Drawing.Size(960, 25);
            this.menuStripBotones_Metodos.TabIndex = 1;
            this.menuStripBotones_Metodos.Text = "menuStrip1";
            // 
            // MenuItemCorreo_Recuperacion
            // 
            this.MenuItemCorreo_Recuperacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuItemCorreo_Recuperacion.BackColor = System.Drawing.Color.Silver;
            this.MenuItemCorreo_Recuperacion.Image = global::EXPO60.Properties.Resources.send_96px1;
            this.MenuItemCorreo_Recuperacion.Name = "MenuItemCorreo_Recuperacion";
            this.MenuItemCorreo_Recuperacion.Size = new System.Drawing.Size(159, 21);
            this.MenuItemCorreo_Recuperacion.Text = "Correo de recuperacion";
            this.MenuItemCorreo_Recuperacion.Click += new System.EventHandler(this.MenuItemCorreo_Recuperacion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 21);
            // 
            // MenuItemPreguntas_Recuperacion
            // 
            this.MenuItemPreguntas_Recuperacion.BackColor = System.Drawing.Color.Silver;
            this.MenuItemPreguntas_Recuperacion.Image = global::EXPO60.Properties.Resources.question_mark_96px1;
            this.MenuItemPreguntas_Recuperacion.Name = "MenuItemPreguntas_Recuperacion";
            this.MenuItemPreguntas_Recuperacion.Size = new System.Drawing.Size(159, 21);
            this.MenuItemPreguntas_Recuperacion.Text = "Preguntas de seguridad";
            this.MenuItemPreguntas_Recuperacion.Click += new System.EventHandler(this.MenuItemPreguntas_Recuperacion_Click);
            // 
            // MenuItemContactar_Administrador
            // 
            this.MenuItemContactar_Administrador.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuItemContactar_Administrador.BackColor = System.Drawing.Color.Silver;
            this.MenuItemContactar_Administrador.Image = global::EXPO60.Properties.Resources.end_call_male_96px;
            this.MenuItemContactar_Administrador.Name = "MenuItemContactar_Administrador";
            this.MenuItemContactar_Administrador.Size = new System.Drawing.Size(166, 21);
            this.MenuItemContactar_Administrador.Text = "Contactar Administrador";
            this.MenuItemContactar_Administrador.Click += new System.EventHandler(this.MenuItemContactar_Administrador_Click);
            // 
            // panelMetodos
            // 
            this.panelMetodos.BackColor = System.Drawing.Color.White;
            this.panelMetodos.Controls.Add(this.panelMetodo_Mostrar);
            this.panelMetodos.Controls.Add(this.menuStripBotones_Metodos);
            this.panelMetodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMetodos.Location = new System.Drawing.Point(0, 25);
            this.panelMetodos.Name = "panelMetodos";
            this.panelMetodos.Size = new System.Drawing.Size(960, 455);
            this.panelMetodos.TabIndex = 2;
            // 
            // panelMetodo_Mostrar
            // 
            this.panelMetodo_Mostrar.BackColor = System.Drawing.SystemColors.Control;
            this.panelMetodo_Mostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMetodo_Mostrar.Location = new System.Drawing.Point(0, 25);
            this.panelMetodo_Mostrar.Name = "panelMetodo_Mostrar";
            this.panelMetodo_Mostrar.Size = new System.Drawing.Size(960, 430);
            this.panelMetodo_Mostrar.TabIndex = 2;
            // 
            // FrmMetodos_Recuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 480);
            this.Controls.Add(this.panelMetodos);
            this.Controls.Add(this.toolStripMetodos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripBotones_Metodos;
            this.Name = "FrmMetodos_Recuperar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMetodos_Recuperar";
            this.toolStripMetodos.ResumeLayout(false);
            this.toolStripMetodos.PerformLayout();
            this.menuStripBotones_Metodos.ResumeLayout(false);
            this.menuStripBotones_Metodos.PerformLayout();
            this.panelMetodos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMetodos;
        private System.Windows.Forms.MenuStrip menuStripBotones_Metodos;
        private System.Windows.Forms.Panel panelMetodos;
        private System.Windows.Forms.ToolStripButton btntoolCerrar_Metodos;
        private System.Windows.Forms.ToolStripLabel toollblMetodos;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCorreo_Recuperacion;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPreguntas_Recuperacion;
        private System.Windows.Forms.ToolStripMenuItem MenuItemContactar_Administrador;
        private System.Windows.Forms.Panel panelMetodo_Mostrar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}