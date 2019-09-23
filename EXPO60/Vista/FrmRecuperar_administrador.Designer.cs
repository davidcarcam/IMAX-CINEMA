namespace EXPO60.Vista
{
    partial class FrmRecuperar_administrador
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
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.txtencriptado2 = new System.Windows.Forms.TextBox();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnPemitir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveAdmin = new System.Windows.Forms.TextBox();
            this.txtUsuarioRecuperar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.BtnCambiarContraseña = new System.Windows.Forms.Button();
            this.BtnValidar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraseñaRecuperar = new System.Windows.Forms.TextBox();
            this.txtEncriptado = new System.Windows.Forms.TextBox();
            this.grpAdmin.SuspendLayout();
            this.grpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(130, 58);
            this.txtUsuarioAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(233, 22);
            this.txtUsuarioAdmin.TabIndex = 0;
            // 
            // txtencriptado2
            // 
            this.txtencriptado2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtencriptado2.Location = new System.Drawing.Point(255, 29);
            this.txtencriptado2.Margin = new System.Windows.Forms.Padding(2);
            this.txtencriptado2.Name = "txtencriptado2";
            this.txtencriptado2.Size = new System.Drawing.Size(47, 22);
            this.txtencriptado2.TabIndex = 11;
            this.txtencriptado2.Visible = false;
            // 
            // grpAdmin
            // 
            this.grpAdmin.BackColor = System.Drawing.Color.Brown;
            this.grpAdmin.Controls.Add(this.checkBox1);
            this.grpAdmin.Controls.Add(this.BtnPemitir);
            this.grpAdmin.Controls.Add(this.label2);
            this.grpAdmin.Controls.Add(this.label1);
            this.grpAdmin.Controls.Add(this.txtClaveAdmin);
            this.grpAdmin.Controls.Add(this.txtUsuarioAdmin);
            this.grpAdmin.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdmin.ForeColor = System.Drawing.Color.White;
            this.grpAdmin.Location = new System.Drawing.Point(11, 77);
            this.grpAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.grpAdmin.Size = new System.Drawing.Size(438, 315);
            this.grpAdmin.TabIndex = 10;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Admin";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(283, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 22);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Ocultar Clave";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BtnPemitir
            // 
            this.BtnPemitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnPemitir.FlatAppearance.BorderSize = 0;
            this.BtnPemitir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnPemitir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPemitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPemitir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPemitir.ForeColor = System.Drawing.Color.White;
            this.BtnPemitir.Location = new System.Drawing.Point(65, 234);
            this.BtnPemitir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPemitir.Name = "BtnPemitir";
            this.BtnPemitir.Size = new System.Drawing.Size(298, 26);
            this.BtnPemitir.TabIndex = 3;
            this.BtnPemitir.Text = "Verificar Administrador";
            this.BtnPemitir.UseVisualStyleBackColor = false;
            this.BtnPemitir.Click += new System.EventHandler(this.BtnPemitir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // txtClaveAdmin
            // 
            this.txtClaveAdmin.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveAdmin.Location = new System.Drawing.Point(130, 153);
            this.txtClaveAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtClaveAdmin.Name = "txtClaveAdmin";
            this.txtClaveAdmin.Size = new System.Drawing.Size(233, 22);
            this.txtClaveAdmin.TabIndex = 1;
            // 
            // txtUsuarioRecuperar
            // 
            this.txtUsuarioRecuperar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioRecuperar.Location = new System.Drawing.Point(191, 73);
            this.txtUsuarioRecuperar.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioRecuperar.Name = "txtUsuarioRecuperar";
            this.txtUsuarioRecuperar.Size = new System.Drawing.Size(203, 22);
            this.txtUsuarioRecuperar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario a recuperar";
            // 
            // grpUsuario
            // 
            this.grpUsuario.BackColor = System.Drawing.Color.Brown;
            this.grpUsuario.Controls.Add(this.BtnCambiarContraseña);
            this.grpUsuario.Controls.Add(this.BtnValidar);
            this.grpUsuario.Controls.Add(this.txtUsuarioRecuperar);
            this.grpUsuario.Controls.Add(this.label4);
            this.grpUsuario.Controls.Add(this.txtContraseñaRecuperar);
            this.grpUsuario.Controls.Add(this.label3);
            this.grpUsuario.Enabled = false;
            this.grpUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsuario.ForeColor = System.Drawing.Color.White;
            this.grpUsuario.Location = new System.Drawing.Point(462, 77);
            this.grpUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.grpUsuario.Size = new System.Drawing.Size(466, 315);
            this.grpUsuario.TabIndex = 9;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Recuperación";
            // 
            // BtnCambiarContraseña
            // 
            this.BtnCambiarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnCambiarContraseña.FlatAppearance.BorderSize = 0;
            this.BtnCambiarContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnCambiarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiarContraseña.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.BtnCambiarContraseña.Location = new System.Drawing.Point(246, 234);
            this.BtnCambiarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCambiarContraseña.Name = "BtnCambiarContraseña";
            this.BtnCambiarContraseña.Size = new System.Drawing.Size(182, 26);
            this.BtnCambiarContraseña.TabIndex = 7;
            this.BtnCambiarContraseña.Text = "Cambiar Clave";
            this.BtnCambiarContraseña.UseVisualStyleBackColor = false;
            this.BtnCambiarContraseña.Click += new System.EventHandler(this.BtnCambiarContraseña_Click);
            // 
            // BtnValidar
            // 
            this.BtnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnValidar.FlatAppearance.BorderSize = 0;
            this.BtnValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnValidar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidar.ForeColor = System.Drawing.Color.White;
            this.BtnValidar.Location = new System.Drawing.Point(31, 234);
            this.BtnValidar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(180, 26);
            this.BtnValidar.TabIndex = 6;
            this.BtnValidar.Text = "Verificar Usuario";
            this.BtnValidar.UseVisualStyleBackColor = false;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nueva contraseña";
            // 
            // txtContraseñaRecuperar
            // 
            this.txtContraseñaRecuperar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaRecuperar.Location = new System.Drawing.Point(191, 157);
            this.txtContraseñaRecuperar.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaRecuperar.Name = "txtContraseñaRecuperar";
            this.txtContraseñaRecuperar.Size = new System.Drawing.Size(203, 22);
            this.txtContraseñaRecuperar.TabIndex = 5;
            // 
            // txtEncriptado
            // 
            this.txtEncriptado.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncriptado.Location = new System.Drawing.Point(361, 29);
            this.txtEncriptado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEncriptado.Name = "txtEncriptado";
            this.txtEncriptado.Size = new System.Drawing.Size(47, 22);
            this.txtEncriptado.TabIndex = 12;
            this.txtEncriptado.Visible = false;
            // 
            // FrmRecuperar_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 430);
            this.Controls.Add(this.txtEncriptado);
            this.Controls.Add(this.txtencriptado2);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.grpUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecuperar_administrador";
            this.Text = "FrmRecuperar_administrador";
            this.grpAdmin.ResumeLayout(false);
            this.grpAdmin.PerformLayout();
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.TextBox txtencriptado2;
        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnPemitir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveAdmin;
        private System.Windows.Forms.TextBox txtUsuarioRecuperar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.Button BtnCambiarContraseña;
        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraseñaRecuperar;
        private System.Windows.Forms.TextBox txtEncriptado;
    }
}