namespace EXPO60.Vista
{
    partial class Recuperacion_Correo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbtnCerra_Aplicacion = new System.Windows.Forms.ToolStripButton();
            this.toollblLogin = new System.Windows.Forms.ToolStripLabel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el usuario a recuperar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de seguridad";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnCerra_Aplicacion,
            this.toollblLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(559, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbtnCerra_Aplicacion
            // 
            this.toolbtnCerra_Aplicacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolbtnCerra_Aplicacion.Image = global::EXPO60.Properties.Resources.cancel;
            this.toolbtnCerra_Aplicacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnCerra_Aplicacion.Name = "toolbtnCerra_Aplicacion";
            this.toolbtnCerra_Aplicacion.Size = new System.Drawing.Size(103, 22);
            this.toolbtnCerra_Aplicacion.Text = "Cerrar Sistema";
            // 
            // toollblLogin
            // 
            this.toollblLogin.Name = "toollblLogin";
            this.toollblLogin.Size = new System.Drawing.Size(117, 22);
            this.toollblLogin.Text = "Codigo de seguridad";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(286, 68);
            this.txtUsuario.MaxLength = 100;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(193, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(286, 167);
            this.txtcodigo.MaxLength = 50;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(193, 20);
            this.txtcodigo.TabIndex = 2;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(129, 105);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(299, 28);
            this.btnconfirmar.TabIndex = 19;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Confirmar codigo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recuperacion_Correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recuperacion_Correo";
            this.Text = "Recuperacion_Correo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolbtnCerra_Aplicacion;
        private System.Windows.Forms.ToolStripLabel toollblLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button button1;
    }
}