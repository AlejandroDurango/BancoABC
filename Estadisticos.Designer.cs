namespace BancoABC
{
    partial class Estadisticos
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
            this.button_generar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonatras = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.result_totalconsignaciones = new System.Windows.Forms.Label();
            this.result_totalretiros = new System.Windows.Forms.Label();
            this.result_totaloperaciones = new System.Windows.Forms.Label();
            this.result_mayor_consignacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_generar
            // 
            this.button_generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_generar.Location = new System.Drawing.Point(77, 235);
            this.button_generar.Margin = new System.Windows.Forms.Padding(2);
            this.button_generar.Name = "button_generar";
            this.button_generar.Size = new System.Drawing.Size(78, 32);
            this.button_generar.TabIndex = 25;
            this.button_generar.Text = "Generar";
            this.button_generar.UseVisualStyleBackColor = true;
            this.button_generar.Click += new System.EventHandler(this.button_generar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoABC.Properties.Resources.Logo_Bank1;
            this.pictureBox1.Location = new System.Drawing.Point(77, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // buttonatras
            // 
            this.buttonatras.AutoSize = true;
            this.buttonatras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonatras.Location = new System.Drawing.Point(8, 8);
            this.buttonatras.Margin = new System.Windows.Forms.Padding(2);
            this.buttonatras.Name = "buttonatras";
            this.buttonatras.Size = new System.Drawing.Size(50, 23);
            this.buttonatras.TabIndex = 27;
            this.buttonatras.Text = "Atras";
            this.buttonatras.UseVisualStyleBackColor = true;
            this.buttonatras.Click += new System.EventHandler(this.buttonatras_Click);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(35, 86);
            this.label_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(153, 17);
            this.label_1.TabIndex = 28;
            this.label_1.Text = "Valor total de consignaciones";
            this.label_1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Valor total de retiros";
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Total de operaciones realizadas";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cliente de mayor consignación";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // result_totalconsignaciones
            // 
            this.result_totalconsignaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_totalconsignaciones.AutoSize = true;
            this.result_totalconsignaciones.Location = new System.Drawing.Point(83, 101);
            this.result_totalconsignaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result_totalconsignaciones.Name = "result_totalconsignaciones";
            this.result_totalconsignaciones.Size = new System.Drawing.Size(63, 17);
            this.result_totalconsignaciones.TabIndex = 32;
            this.result_totalconsignaciones.Text = "Cargando...";
            this.result_totalconsignaciones.UseCompatibleTextRendering = true;
            this.result_totalconsignaciones.UseWaitCursor = true;
            // 
            // result_totalretiros
            // 
            this.result_totalretiros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_totalretiros.AutoSize = true;
            this.result_totalretiros.Location = new System.Drawing.Point(83, 140);
            this.result_totalretiros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result_totalretiros.Name = "result_totalretiros";
            this.result_totalretiros.Size = new System.Drawing.Size(63, 17);
            this.result_totalretiros.TabIndex = 33;
            this.result_totalretiros.Text = "Cargando...";
            this.result_totalretiros.UseCompatibleTextRendering = true;
            this.result_totalretiros.UseWaitCursor = true;
            // 
            // result_totaloperaciones
            // 
            this.result_totaloperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_totaloperaciones.AutoSize = true;
            this.result_totaloperaciones.Location = new System.Drawing.Point(83, 177);
            this.result_totaloperaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result_totaloperaciones.Name = "result_totaloperaciones";
            this.result_totaloperaciones.Size = new System.Drawing.Size(63, 17);
            this.result_totaloperaciones.TabIndex = 34;
            this.result_totaloperaciones.Text = "Cargando...";
            this.result_totaloperaciones.UseCompatibleTextRendering = true;
            this.result_totaloperaciones.UseWaitCursor = true;
            // 
            // result_mayor_consignacion
            // 
            this.result_mayor_consignacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_mayor_consignacion.AutoSize = true;
            this.result_mayor_consignacion.Location = new System.Drawing.Point(83, 216);
            this.result_mayor_consignacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result_mayor_consignacion.Name = "result_mayor_consignacion";
            this.result_mayor_consignacion.Size = new System.Drawing.Size(63, 17);
            this.result_mayor_consignacion.TabIndex = 35;
            this.result_mayor_consignacion.Text = "Cargando...";
            this.result_mayor_consignacion.UseCompatibleTextRendering = true;
            this.result_mayor_consignacion.UseWaitCursor = true;
            // 
            // Estadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 292);
            this.Controls.Add(this.result_mayor_consignacion);
            this.Controls.Add(this.result_totaloperaciones);
            this.Controls.Add(this.result_totalretiros);
            this.Controls.Add(this.result_totalconsignaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.buttonatras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_generar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Estadisticos";
            this.Text = "Estadisticos";
            this.Load += new System.EventHandler(this.Estadisticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_generar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonatras;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result_totalconsignaciones;
        private System.Windows.Forms.Label result_totalretiros;
        private System.Windows.Forms.Label result_totaloperaciones;
        private System.Windows.Forms.Label result_mayor_consignacion;
    }
}