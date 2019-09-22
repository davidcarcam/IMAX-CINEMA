namespace EXPO60.graficos
{
    partial class graficoSalas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnRegresar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafico
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico.Legends.Add(legend2);
            this.grafico.Location = new System.Drawing.Point(33, 28);
            this.grafico.Name = "grafico";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(750, 397);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(830, 153);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 31);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRegresar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 25);
            this.toolStrip1.TabIndex = 61;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnRegresar.Image = global::EXPO60.Properties.Resources.regresar;
            this.BtnRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(143, 22);
            this.BtnRegresar.Text = "Regresar al formulario";
            this.BtnRegresar.ToolTipText = "Regresar al Formulario";
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(801, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doble clic para actualizar el gráfico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "NÚMERO DE SALA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 117);
            this.label3.TabIndex = 63;
            this.label3.Text = "C\r\nA\r\nP\r\nA\r\nC\r\nI\r\nD\r\nA\r\nD";
            // 
            // graficoSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "graficoSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "graficoSalas";
            this.Load += new System.EventHandler(this.graficoSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}