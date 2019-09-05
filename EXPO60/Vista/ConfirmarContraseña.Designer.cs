namespace EXPO60.Vista
{
    partial class ConfirmarContraseña
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbtnCerra_Aplicacion = new System.Windows.Forms.ToolStripButton();
            this.toollblLogin = new System.Windows.Forms.ToolStripLabel();
            this.txtCifrado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblcontra = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnCerra_Aplicacion,
            this.toollblLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(442, 25);
            this.toolStrip1.TabIndex = 15;
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
            this.toolbtnCerra_Aplicacion.Click += new System.EventHandler(this.toolbtnCerra_Aplicacion_Click);
            // 
            // toollblLogin
            // 
            this.toollblLogin.Name = "toollblLogin";
            this.toollblLogin.Size = new System.Drawing.Size(157, 22);
            this.toollblLogin.Text = "Confirmacion de contraseña";
            // 
            // txtCifrado
            // 
            this.txtCifrado.Location = new System.Drawing.Point(145, 97);
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.Size = new System.Drawing.Size(38, 20);
            this.txtCifrado.TabIndex = 30;
            this.txtCifrado.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.ForeColor = System.Drawing.Color.Red;
            this.lblcontra.Location = new System.Drawing.Point(229, 104);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(149, 13);
            this.lblcontra.TabIndex = 29;
            this.lblcontra.Text = "Las contraseñas no coinciden";
            this.lblcontra.Visible = false;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(219, 131);
            this.txtContra.MaxLength = 50;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(179, 20);
            this.txtContra.TabIndex = 2;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(219, 61);
            this.txt1.MaxLength = 50;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(179, 20);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Confirmar contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Contraseña";
            // 
            // ConfirmarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 285);
            this.Controls.Add(this.txtCifrado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmarContraseña";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolbtnCerra_Aplicacion;
        private System.Windows.Forms.ToolStripLabel toollblLogin;
        private System.Windows.Forms.TextBox txtCifrado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}