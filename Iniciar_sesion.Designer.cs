namespace BancoABC
{
    partial class Iniciar_sesion
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
            this.label_cuenta = new System.Windows.Forms.Label();
            this.contraseña_text = new System.Windows.Forms.TextBox();
            this.button_iniciar_sesion = new System.Windows.Forms.Button();
            this.buttonatras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_cuenta
            // 
            this.label_cuenta.AutoSize = true;
            this.label_cuenta.Location = new System.Drawing.Point(73, 120);
            this.label_cuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cuenta.Name = "label_cuenta";
            this.label_cuenta.Size = new System.Drawing.Size(63, 17);
            this.label_cuenta.TabIndex = 0;
            this.label_cuenta.Text = "Contraseña";
            this.label_cuenta.UseCompatibleTextRendering = true;
            this.label_cuenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // contraseña_text
            // 
            this.contraseña_text.AcceptsTab = true;
            this.contraseña_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contraseña_text.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.contraseña_text.Location = new System.Drawing.Point(50, 148);
            this.contraseña_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contraseña_text.Name = "contraseña_text";
            this.contraseña_text.Size = new System.Drawing.Size(115, 20);
            this.contraseña_text.TabIndex = 2;
            this.contraseña_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contraseña_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cuenta_text_KeyPress);
            // 
            // button_iniciar_sesion
            // 
            this.button_iniciar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_iniciar_sesion.Location = new System.Drawing.Point(50, 185);
            this.button_iniciar_sesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_iniciar_sesion.Name = "button_iniciar_sesion";
            this.button_iniciar_sesion.Size = new System.Drawing.Size(115, 36);
            this.button_iniciar_sesion.TabIndex = 5;
            this.button_iniciar_sesion.Text = "Iniciar Sesión";
            this.button_iniciar_sesion.UseCompatibleTextRendering = true;
            this.button_iniciar_sesion.UseVisualStyleBackColor = true;
            this.button_iniciar_sesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonatras
            // 
            this.buttonatras.AutoSize = true;
            this.buttonatras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonatras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonatras.Location = new System.Drawing.Point(8, 43);
            this.buttonatras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonatras.Name = "buttonatras";
            this.buttonatras.Size = new System.Drawing.Size(41, 23);
            this.buttonatras.TabIndex = 10;
            this.buttonatras.Text = "Atras";
            this.buttonatras.UseVisualStyleBackColor = true;
            this.buttonatras.Click += new System.EventHandler(this.buttonatras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoABC.Properties.Resources.Logo_Bank1;
            this.pictureBox1.Location = new System.Drawing.Point(73, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ingresa a Tus Sueños";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Iniciar_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonatras);
            this.Controls.Add(this.button_iniciar_sesion);
            this.Controls.Add(this.contraseña_text);
            this.Controls.Add(this.label_cuenta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Iniciar_sesion";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Iniciar_sesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cuenta;
        private System.Windows.Forms.TextBox contraseña_text;
        private System.Windows.Forms.Button buttonatras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button_iniciar_sesion;
    }
}