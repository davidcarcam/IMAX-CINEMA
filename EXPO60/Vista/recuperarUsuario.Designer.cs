namespace EXPO60.Vista
{
    partial class recuperarUsuario
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
            this.btnRecu = new System.Windows.Forms.Button();
            this.txtusuarioRecuperar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecu
            // 
            this.btnRecu.Location = new System.Drawing.Point(295, 188);
            this.btnRecu.Name = "btnRecu";
            this.btnRecu.Size = new System.Drawing.Size(116, 30);
            this.btnRecu.TabIndex = 0;
            this.btnRecu.Text = "recuperar";
            this.btnRecu.UseVisualStyleBackColor = true;
            this.btnRecu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtusuarioRecuperar
            // 
            this.txtusuarioRecuperar.Location = new System.Drawing.Point(255, 129);
            this.txtusuarioRecuperar.MaxLength = 100;
            this.txtusuarioRecuperar.Name = "txtusuarioRecuperar";
            this.txtusuarioRecuperar.Size = new System.Drawing.Size(181, 20);
            this.txtusuarioRecuperar.TabIndex = 1;
            this.txtusuarioRecuperar.TextChanged += new System.EventHandler(this.txtusuarioRecuperar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnRecu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtusuarioRecuperar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 259);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(251, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "recuperacion por correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Correo a recuperar";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // recuperarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 259);
            this.Controls.Add(this.panel1);
            this.Name = "recuperarUsuario";
            this.Text = "recuperarUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecu;
        private System.Windows.Forms.TextBox txtusuarioRecuperar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error1;
    }
}