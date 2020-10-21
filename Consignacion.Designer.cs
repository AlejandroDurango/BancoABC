namespace BancoABC
{
    partial class Consignacion
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
            this.cuenta_consignacion_text = new System.Windows.Forms.TextBox();
            this.title_consignacion = new System.Windows.Forms.Label();
            this.label_cuenta_consignacion = new System.Windows.Forms.Label();
            this.label_result_consignacion = new System.Windows.Forms.Label();
            this.buttonatras = new System.Windows.Forms.Button();
            this.button_verifica_consignacion = new System.Windows.Forms.Button();
            this.label_result_retiro = new System.Windows.Forms.Label();
            this.button_tranferir_consignacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cuenta_consignacion_text
            // 
            this.cuenta_consignacion_text.AcceptsTab = true;
            this.cuenta_consignacion_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuenta_consignacion_text.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cuenta_consignacion_text.Location = new System.Drawing.Point(69, 221);
            this.cuenta_consignacion_text.Name = "cuenta_consignacion_text";
            this.cuenta_consignacion_text.Size = new System.Drawing.Size(170, 26);
            this.cuenta_consignacion_text.TabIndex = 3;
            this.cuenta_consignacion_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title_consignacion
            // 
            this.title_consignacion.AutoSize = true;
            this.title_consignacion.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_consignacion.Location = new System.Drawing.Point(14, 129);
            this.title_consignacion.Name = "title_consignacion";
            this.title_consignacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title_consignacion.Size = new System.Drawing.Size(312, 36);
            this.title_consignacion.TabIndex = 4;
            this.title_consignacion.Text = "Ingresa los datos.";
            this.title_consignacion.Click += new System.EventHandler(this.title_whatdoing_Click);
            // 
            // label_cuenta_consignacion
            // 
            this.label_cuenta_consignacion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label_cuenta_consignacion.AutoSize = true;
            this.label_cuenta_consignacion.Location = new System.Drawing.Point(117, 177);
            this.label_cuenta_consignacion.Name = "label_cuenta_consignacion";
            this.label_cuenta_consignacion.Size = new System.Drawing.Size(82, 24);
            this.label_cuenta_consignacion.TabIndex = 5;
            this.label_cuenta_consignacion.Text = "Cuenta N°";
            this.label_cuenta_consignacion.UseCompatibleTextRendering = true;
            // 
            // label_result_consignacion
            // 
            this.label_result_consignacion.AutoSize = true;
            this.label_result_consignacion.Location = new System.Drawing.Point(104, 367);
            this.label_result_consignacion.Name = "label_result_consignacion";
            this.label_result_consignacion.Size = new System.Drawing.Size(0, 20);
            this.label_result_consignacion.TabIndex = 8;
            // 
            // buttonatras
            // 
            this.buttonatras.AutoSize = true;
            this.buttonatras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonatras.Location = new System.Drawing.Point(3, 12);
            this.buttonatras.Name = "buttonatras";
            this.buttonatras.Size = new System.Drawing.Size(75, 30);
            this.buttonatras.TabIndex = 9;
            this.buttonatras.Text = "Atras";
            this.buttonatras.UseVisualStyleBackColor = true;
            this.buttonatras.Click += new System.EventHandler(this.buttonatras_Click);
            // 
            // button_verifica_consignacion
            // 
            this.button_verifica_consignacion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_verifica_consignacion.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button_verifica_consignacion.Location = new System.Drawing.Point(58, 271);
            this.button_verifica_consignacion.Name = "button_verifica_consignacion";
            this.button_verifica_consignacion.Size = new System.Drawing.Size(198, 47);
            this.button_verifica_consignacion.TabIndex = 15;
            this.button_verifica_consignacion.Text = "VERIFICAR";
            this.button_verifica_consignacion.UseCompatibleTextRendering = true;
            this.button_verifica_consignacion.UseVisualStyleBackColor = true;
            this.button_verifica_consignacion.UseWaitCursor = true;
            this.button_verifica_consignacion.Click += new System.EventHandler(this.button_verifica_consignacion_Click);
            // 
            // label_result_retiro
            // 
            this.label_result_retiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_result_retiro.AutoSize = true;
            this.label_result_retiro.Location = new System.Drawing.Point(38, 367);
            this.label_result_retiro.Name = "label_result_retiro";
            this.label_result_retiro.Size = new System.Drawing.Size(274, 20);
            this.label_result_retiro.TabIndex = 18;
            this.label_result_retiro.Text = "¡Tu tienes la plata , nosotros el medio!";
            this.label_result_retiro.Click += new System.EventHandler(this.label_result_retiro_Click);
            // 
            // button_tranferir_consignacion
            // 
            this.button_tranferir_consignacion.AutoSize = true;
            this.button_tranferir_consignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_tranferir_consignacion.Location = new System.Drawing.Point(188, 408);
            this.button_tranferir_consignacion.Name = "button_tranferir_consignacion";
            this.button_tranferir_consignacion.Size = new System.Drawing.Size(138, 30);
            this.button_tranferir_consignacion.TabIndex = 19;
            this.button_tranferir_consignacion.Text = "Ir Transferencias";
            this.button_tranferir_consignacion.UseVisualStyleBackColor = true;
            this.button_tranferir_consignacion.Click += new System.EventHandler(this.button_tranferir_consignacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoABC.Properties.Resources.Logo_Bank1;
            this.pictureBox1.Location = new System.Drawing.Point(179, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Consignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_tranferir_consignacion);
            this.Controls.Add(this.label_result_retiro);
            this.Controls.Add(this.button_verifica_consignacion);
            this.Controls.Add(this.buttonatras);
            this.Controls.Add(this.label_result_consignacion);
            this.Controls.Add(this.label_cuenta_consignacion);
            this.Controls.Add(this.title_consignacion);
            this.Controls.Add(this.cuenta_consignacion_text);
            this.Name = "Consignacion";
            this.Text = "Consignación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consignacion_FormClosed);
            this.Load += new System.EventHandler(this.form_consignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cuenta_consignacion_text;
        private System.Windows.Forms.Label title_consignacion;
        private System.Windows.Forms.Label label_cuenta_consignacion;
        private System.Windows.Forms.Label label_result_consignacion;
        private System.Windows.Forms.Button buttonatras;
        private System.Windows.Forms.Button button_verifica_consignacion;
        private System.Windows.Forms.Label label_result_retiro;
        private System.Windows.Forms.Button button_tranferir_consignacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}