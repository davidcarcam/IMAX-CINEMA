namespace EXPO60.Vista
{
    partial class RecuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuAdmin));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtencriptado2 = new System.Windows.Forms.TextBox();
            this.txtEncriptado = new System.Windows.Forms.TextBox();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnPemitir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveAdmin = new System.Windows.Forms.TextBox();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.BtnCambiarContraseña = new System.Windows.Forms.Button();
            this.BtnValidar = new System.Windows.Forms.Button();
            this.txtUsuarioRecuperar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraseñaRecuperar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.grpAdmin.SuspendLayout();
            this.grpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.txtencriptado2);
            this.bunifuGradientPanel1.Controls.Add(this.txtEncriptado);
            this.bunifuGradientPanel1.Controls.Add(this.grpAdmin);
            this.bunifuGradientPanel1.Controls.Add(this.grpUsuario);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(744, 286);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(610, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 189;
            this.label5.Text = "Regresar al login";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtencriptado2
            // 
            this.txtencriptado2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtencriptado2.Location = new System.Drawing.Point(264, 4);
            this.txtencriptado2.Margin = new System.Windows.Forms.Padding(2);
            this.txtencriptado2.Name = "txtencriptado2";
            this.txtencriptado2.Size = new System.Drawing.Size(47, 22);
            this.txtencriptado2.TabIndex = 8;
            this.txtencriptado2.Visible = false;
            // 
            // txtEncriptado
            // 
            this.txtEncriptado.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncriptado.Location = new System.Drawing.Point(315, 4);
            this.txtEncriptado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEncriptado.Name = "txtEncriptado";
            this.txtEncriptado.Size = new System.Drawing.Size(47, 22);
            this.txtEncriptado.TabIndex = 6;
            this.txtEncriptado.Visible = false;
            // 
            // grpAdmin
            // 
            this.grpAdmin.BackColor = System.Drawing.Color.Transparent;
            this.grpAdmin.Controls.Add(this.checkBox1);
            this.grpAdmin.Controls.Add(this.BtnPemitir);
            this.grpAdmin.Controls.Add(this.label2);
            this.grpAdmin.Controls.Add(this.label1);
            this.grpAdmin.Controls.Add(this.txtClaveAdmin);
            this.grpAdmin.Controls.Add(this.txtUsuarioAdmin);
            this.grpAdmin.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdmin.ForeColor = System.Drawing.Color.White;
            this.grpAdmin.Location = new System.Drawing.Point(21, 35);
            this.grpAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.grpAdmin.Size = new System.Drawing.Size(333, 218);
            this.grpAdmin.TabIndex = 7;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Admin";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(203, 136);
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
            this.BtnPemitir.Location = new System.Drawing.Point(19, 174);
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
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // txtClaveAdmin
            // 
            this.txtClaveAdmin.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveAdmin.Location = new System.Drawing.Point(130, 103);
            this.txtClaveAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtClaveAdmin.Name = "txtClaveAdmin";
            this.txtClaveAdmin.Size = new System.Drawing.Size(146, 22);
            this.txtClaveAdmin.TabIndex = 1;
            this.txtClaveAdmin.TextChanged += new System.EventHandler(this.txtClaveAdmin_TextChanged);
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(130, 58);
            this.txtUsuarioAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(146, 22);
            this.txtUsuarioAdmin.TabIndex = 0;
            // 
            // grpUsuario
            // 
            this.grpUsuario.BackColor = System.Drawing.Color.Transparent;
            this.grpUsuario.Controls.Add(this.BtnCambiarContraseña);
            this.grpUsuario.Controls.Add(this.BtnValidar);
            this.grpUsuario.Controls.Add(this.txtUsuarioRecuperar);
            this.grpUsuario.Controls.Add(this.label4);
            this.grpUsuario.Controls.Add(this.txtContraseñaRecuperar);
            this.grpUsuario.Controls.Add(this.label3);
            this.grpUsuario.Enabled = false;
            this.grpUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsuario.ForeColor = System.Drawing.Color.White;
            this.grpUsuario.Location = new System.Drawing.Point(379, 35);
            this.grpUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.grpUsuario.Size = new System.Drawing.Size(350, 218);
            this.grpUsuario.TabIndex = 6;
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
            this.BtnCambiarContraseña.Location = new System.Drawing.Point(188, 174);
            this.BtnCambiarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCambiarContraseña.Name = "BtnCambiarContraseña";
            this.BtnCambiarContraseña.Size = new System.Drawing.Size(142, 26);
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
            this.BtnValidar.Location = new System.Drawing.Point(23, 174);
            this.BtnValidar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(142, 26);
            this.BtnValidar.TabIndex = 6;
            this.BtnValidar.Text = "Verificar Usuario";
            this.BtnValidar.UseVisualStyleBackColor = false;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // txtUsuarioRecuperar
            // 
            this.txtUsuarioRecuperar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioRecuperar.Location = new System.Drawing.Point(168, 52);
            this.txtUsuarioRecuperar.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioRecuperar.Name = "txtUsuarioRecuperar";
            this.txtUsuarioRecuperar.Size = new System.Drawing.Size(162, 22);
            this.txtUsuarioRecuperar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nueva contraseña";
            // 
            // txtContraseñaRecuperar
            // 
            this.txtContraseñaRecuperar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaRecuperar.Location = new System.Drawing.Point(168, 102);
            this.txtContraseñaRecuperar.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaRecuperar.Name = "txtContraseñaRecuperar";
            this.txtContraseñaRecuperar.Size = new System.Drawing.Size(162, 22);
            this.txtContraseñaRecuperar.TabIndex = 5;
            this.txtContraseñaRecuperar.TextChanged += new System.EventHandler(this.txtContraseñaRecuperar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario a recuperar";
            // 
            // RecuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 286);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuAdmin";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.grpAdmin.ResumeLayout(false);
            this.grpAdmin.PerformLayout();
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtencriptado2;
        private System.Windows.Forms.TextBox txtEncriptado;
        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnPemitir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveAdmin;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.Button BtnCambiarContraseña;
        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.TextBox txtUsuarioRecuperar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraseñaRecuperar;
        private System.Windows.Forms.Label label3;
    }
}