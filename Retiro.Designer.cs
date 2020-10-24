namespace BancoABC
{
    partial class Retiro
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
            this.buttonatras = new System.Windows.Forms.Button();
            this.title_retiro = new System.Windows.Forms.Label();
            this.label_monto_retiro = new System.Windows.Forms.Label();
            this.TextBox_monto_retirar = new System.Windows.Forms.TextBox();
            this.button_verifica_retiro = new System.Windows.Forms.Button();
            this.label_result_retiro = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_mostrar_retiro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonatras
            // 
            this.buttonatras.AutoSize = true;
            this.buttonatras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonatras.Location = new System.Drawing.Point(8, 8);
            this.buttonatras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonatras.Name = "buttonatras";
            this.buttonatras.Size = new System.Drawing.Size(50, 23);
            this.buttonatras.TabIndex = 10;
            this.buttonatras.Text = "Atras";
            this.buttonatras.UseVisualStyleBackColor = true;
            this.buttonatras.Click += new System.EventHandler(this.buttonatras_Click);
            // 
            // title_retiro
            // 
            this.title_retiro.AutoSize = true;
            this.title_retiro.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_retiro.Location = new System.Drawing.Point(4, 80);
            this.title_retiro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_retiro.Name = "title_retiro";
            this.title_retiro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title_retiro.Size = new System.Drawing.Size(217, 24);
            this.title_retiro.TabIndex = 11;
            this.title_retiro.Text = "Ingresa los datos.";
            // 
            // label_monto_retiro
            // 
            this.label_monto_retiro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label_monto_retiro.AutoSize = true;
            this.label_monto_retiro.Location = new System.Drawing.Point(63, 121);
            this.label_monto_retiro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_monto_retiro.Name = "label_monto_retiro";
            this.label_monto_retiro.Size = new System.Drawing.Size(81, 17);
            this.label_monto_retiro.TabIndex = 12;
            this.label_monto_retiro.Text = "Monto a retirar:";
            this.label_monto_retiro.UseCompatibleTextRendering = true;
            // 
            // TextBox_monto_retirar
            // 
            this.TextBox_monto_retirar.AcceptsTab = true;
            this.TextBox_monto_retirar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_monto_retirar.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.TextBox_monto_retirar.Location = new System.Drawing.Point(38, 161);
            this.TextBox_monto_retirar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_monto_retirar.Name = "TextBox_monto_retirar";
            this.TextBox_monto_retirar.Size = new System.Drawing.Size(139, 20);
            this.TextBox_monto_retirar.TabIndex = 13;
            this.TextBox_monto_retirar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_verifica_retiro
            // 
            this.button_verifica_retiro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_verifica_retiro.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button_verifica_retiro.Location = new System.Drawing.Point(38, 200);
            this.button_verifica_retiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_verifica_retiro.Name = "button_verifica_retiro";
            this.button_verifica_retiro.Size = new System.Drawing.Size(132, 31);
            this.button_verifica_retiro.TabIndex = 16;
            this.button_verifica_retiro.Text = "VERIFICAR";
            this.button_verifica_retiro.UseCompatibleTextRendering = true;
            this.button_verifica_retiro.UseVisualStyleBackColor = true;
            this.button_verifica_retiro.UseWaitCursor = true;
            this.button_verifica_retiro.Click += new System.EventHandler(this.button_verifica_retiro_Click);
            // 
            // label_result_retiro
            // 
            this.label_result_retiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_result_retiro.AutoSize = true;
            this.label_result_retiro.Location = new System.Drawing.Point(73, 246);
            this.label_result_retiro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_result_retiro.Name = "label_result_retiro";
            this.label_result_retiro.Size = new System.Drawing.Size(69, 13);
            this.label_result_retiro.TabIndex = 17;
            this.label_result_retiro.Text = "¡Sos Grande!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BancoABC.Properties.Resources.Logo_Bank1;
            this.pictureBox2.Location = new System.Drawing.Point(103, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label_mostrar_retiro
            // 
            this.label_mostrar_retiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mostrar_retiro.AutoSize = true;
            this.label_mostrar_retiro.Location = new System.Drawing.Point(73, 270);
            this.label_mostrar_retiro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mostrar_retiro.Name = "label_mostrar_retiro";
            this.label_mostrar_retiro.Size = new System.Drawing.Size(0, 13);
            this.label_mostrar_retiro.TabIndex = 23;
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 292);
            this.Controls.Add(this.label_mostrar_retiro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_result_retiro);
            this.Controls.Add(this.button_verifica_retiro);
            this.Controls.Add(this.TextBox_monto_retirar);
            this.Controls.Add(this.label_monto_retiro);
            this.Controls.Add(this.title_retiro);
            this.Controls.Add(this.buttonatras);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Retiro";
            this.Text = "Retiro";
            this.Load += new System.EventHandler(this.Retiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonatras;
        private System.Windows.Forms.Label title_retiro;
        private System.Windows.Forms.Label label_monto_retiro;
        private System.Windows.Forms.TextBox TextBox_monto_retirar;
        private System.Windows.Forms.Button button_verifica_retiro;
        private System.Windows.Forms.Label label_result_retiro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_mostrar_retiro;
    }
}