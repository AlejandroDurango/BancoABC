namespace BancoABC
{
    partial class Tranferencias
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
            this.title_tranferencias = new System.Windows.Forms.Label();
            this.buttonatras = new System.Windows.Forms.Button();
            this.label_cuenta_tranferencia = new System.Windows.Forms.Label();
            this.TextBox_numerocuenta_tranferir = new System.Windows.Forms.TextBox();
            this.lavel_monto_tranferir = new System.Windows.Forms.Label();
            this.textBox_monto_tranferir = new System.Windows.Forms.TextBox();
            this.button_tranferir = new System.Windows.Forms.Button();
            this.label_result_transferencia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_transferido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_tranferencias
            // 
            this.title_tranferencias.AutoSize = true;
            this.title_tranferencias.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tranferencias.Location = new System.Drawing.Point(8, 72);
            this.title_tranferencias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_tranferencias.Name = "title_tranferencias";
            this.title_tranferencias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title_tranferencias.Size = new System.Drawing.Size(217, 24);
            this.title_tranferencias.TabIndex = 12;
            this.title_tranferencias.Text = "Ingresa los datos.";
            // 
            // buttonatras
            // 
            this.buttonatras.AutoSize = true;
            this.buttonatras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonatras.Location = new System.Drawing.Point(8, 8);
            this.buttonatras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonatras.Name = "buttonatras";
            this.buttonatras.Size = new System.Drawing.Size(50, 23);
            this.buttonatras.TabIndex = 13;
            this.buttonatras.Text = "Atras";
            this.buttonatras.UseVisualStyleBackColor = true;
            this.buttonatras.Click += new System.EventHandler(this.buttonatras_Click);
            // 
            // label_cuenta_tranferencia
            // 
            this.label_cuenta_tranferencia.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label_cuenta_tranferencia.AutoSize = true;
            this.label_cuenta_tranferencia.Location = new System.Drawing.Point(66, 103);
            this.label_cuenta_tranferencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cuenta_tranferencia.Name = "label_cuenta_tranferencia";
            this.label_cuenta_tranferencia.Size = new System.Drawing.Size(99, 17);
            this.label_cuenta_tranferencia.TabIndex = 14;
            this.label_cuenta_tranferencia.Text = "Cuenta a Tranferir:";
            this.label_cuenta_tranferencia.UseCompatibleTextRendering = true;
            this.label_cuenta_tranferencia.Click += new System.EventHandler(this.label_monto_retiro_Click);
            // 
            // TextBox_numerocuenta_tranferir
            // 
            this.TextBox_numerocuenta_tranferir.AcceptsTab = true;
            this.TextBox_numerocuenta_tranferir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_numerocuenta_tranferir.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.TextBox_numerocuenta_tranferir.Location = new System.Drawing.Point(39, 121);
            this.TextBox_numerocuenta_tranferir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_numerocuenta_tranferir.Name = "TextBox_numerocuenta_tranferir";
            this.TextBox_numerocuenta_tranferir.Size = new System.Drawing.Size(139, 20);
            this.TextBox_numerocuenta_tranferir.TabIndex = 15;
            this.TextBox_numerocuenta_tranferir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lavel_monto_tranferir
            // 
            this.lavel_monto_tranferir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lavel_monto_tranferir.AutoSize = true;
            this.lavel_monto_tranferir.Location = new System.Drawing.Point(66, 148);
            this.lavel_monto_tranferir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lavel_monto_tranferir.Name = "lavel_monto_tranferir";
            this.lavel_monto_tranferir.Size = new System.Drawing.Size(94, 17);
            this.lavel_monto_tranferir.TabIndex = 16;
            this.lavel_monto_tranferir.Text = "Monto a Tranferir:";
            this.lavel_monto_tranferir.UseCompatibleTextRendering = true;
            this.lavel_monto_tranferir.Click += new System.EventHandler(this.lavel_monto_tranferir_Click);
            // 
            // textBox_monto_tranferir
            // 
            this.textBox_monto_tranferir.AcceptsTab = true;
            this.textBox_monto_tranferir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_monto_tranferir.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.textBox_monto_tranferir.Location = new System.Drawing.Point(39, 166);
            this.textBox_monto_tranferir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_monto_tranferir.Name = "textBox_monto_tranferir";
            this.textBox_monto_tranferir.Size = new System.Drawing.Size(139, 20);
            this.textBox_monto_tranferir.TabIndex = 17;
            this.textBox_monto_tranferir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_tranferir
            // 
            this.button_tranferir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_tranferir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_tranferir.Location = new System.Drawing.Point(39, 207);
            this.button_tranferir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_tranferir.Name = "button_tranferir";
            this.button_tranferir.Size = new System.Drawing.Size(132, 31);
            this.button_tranferir.TabIndex = 18;
            this.button_tranferir.Text = "TRANSFERIR";
            this.button_tranferir.UseCompatibleTextRendering = true;
            this.button_tranferir.UseVisualStyleBackColor = true;
            this.button_tranferir.Click += new System.EventHandler(this.button_tranferir_Click);
            // 
            // label_result_transferencia
            // 
            this.label_result_transferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_result_transferencia.AutoSize = true;
            this.label_result_transferencia.Location = new System.Drawing.Point(21, 251);
            this.label_result_transferencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_result_transferencia.Name = "label_result_transferencia";
            this.label_result_transferencia.Size = new System.Drawing.Size(191, 13);
            this.label_result_transferencia.TabIndex = 19;
            this.label_result_transferencia.Text = "¡Transfiere Amor, pero con proteccion !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoABC.Properties.Resources.Logo_Bank1;
            this.pictureBox1.Location = new System.Drawing.Point(125, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label_transferido
            // 
            this.label_transferido.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label_transferido.AutoSize = true;
            this.label_transferido.Location = new System.Drawing.Point(66, 266);
            this.label_transferido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_transferido.Name = "label_transferido";
            this.label_transferido.Size = new System.Drawing.Size(0, 16);
            this.label_transferido.TabIndex = 23;
            this.label_transferido.UseCompatibleTextRendering = true;
            // 
            // Tranferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 292);
            this.Controls.Add(this.label_transferido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_result_transferencia);
            this.Controls.Add(this.button_tranferir);
            this.Controls.Add(this.textBox_monto_tranferir);
            this.Controls.Add(this.lavel_monto_tranferir);
            this.Controls.Add(this.TextBox_numerocuenta_tranferir);
            this.Controls.Add(this.label_cuenta_tranferencia);
            this.Controls.Add(this.buttonatras);
            this.Controls.Add(this.title_tranferencias);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tranferencias";
            this.Text = "Tranferir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_tranferencias;
        private System.Windows.Forms.Button buttonatras;
        private System.Windows.Forms.Label label_cuenta_tranferencia;
        private System.Windows.Forms.TextBox TextBox_numerocuenta_tranferir;
        private System.Windows.Forms.Label lavel_monto_tranferir;
        private System.Windows.Forms.TextBox textBox_monto_tranferir;
        private System.Windows.Forms.Button button_tranferir;
        private System.Windows.Forms.Label label_result_transferencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_transferido;
    }
}