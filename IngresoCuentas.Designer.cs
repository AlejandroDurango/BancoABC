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
            this.cuenta_text = new System.Windows.Forms.TextBox();
            this.identificacion_text = new System.Windows.Forms.TextBox();
            this.label_identificacion = new System.Windows.Forms.Label();
            this.button_iniciar_sesion = new System.Windows.Forms.Button();
            this.buttonatras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_cuenta
            // 
            this.label_cuenta.AutoSize = true;
            this.label_cuenta.Location = new System.Drawing.Point(129, 94);
            this.label_cuenta.Name = "label_cuenta";
            this.label_cuenta.Size = new System.Drawing.Size(82, 24);
            this.label_cuenta.TabIndex = 0;
            this.label_cuenta.Text = "Cuenta N°";
            this.label_cuenta.UseCompatibleTextRendering = true;
            this.label_cuenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // cuenta_text
            // 
            this.cuenta_text.AcceptsTab = true;
            this.cuenta_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuenta_text.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cuenta_text.Location = new System.Drawing.Point(83, 121);
            this.cuenta_text.Name = "cuenta_text";
            this.cuenta_text.Size = new System.Drawing.Size(170, 26);
            this.cuenta_text.TabIndex = 2;
            this.cuenta_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // identificacion_text
            // 
            this.identificacion_text.AcceptsTab = true;
            this.identificacion_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.identificacion_text.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.identificacion_text.Location = new System.Drawing.Point(83, 212);
            this.identificacion_text.Name = "identificacion_text";
            this.identificacion_text.Size = new System.Drawing.Size(170, 26);
            this.identificacion_text.TabIndex = 3;
            this.identificacion_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_identificacion
            // 
            this.label_identificacion.AutoSize = true;
            this.label_identificacion.Location = new System.Drawing.Point(110, 165);
            this.label_identificacion.Name = "label_identificacion";
            this.label_identificacion.Size = new System.Drawing.Size(125, 24);
            this.label_identificacion.TabIndex = 4;
            this.label_identificacion.Text = "Identificación N°";
            this.label_identificacion.UseCompatibleTextRendering = true;
            this.label_identificacion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button_iniciar_sesion
            // 
            this.button_iniciar_sesion.Location = new System.Drawing.Point(91, 270);
            this.button_iniciar_sesion.Name = "button_iniciar_sesion";
            this.button_iniciar_sesion.Size = new System.Drawing.Size(144, 56);
            this.button_iniciar_sesion.TabIndex = 5;
            this.button_iniciar_sesion.Text = "Iniciar Sesión";
            this.button_iniciar_sesion.UseVisualStyleBackColor = true;
            this.button_iniciar_sesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonatras
            // 
            this.buttonatras.AutoSize = true;
            this.buttonatras.Location = new System.Drawing.Point(240, 393);
            this.buttonatras.Name = "buttonatras";
            this.buttonatras.Size = new System.Drawing.Size(75, 30);
            this.buttonatras.TabIndex = 10;
            this.buttonatras.Text = "Atras";
            this.buttonatras.UseVisualStyleBackColor = true;
            this.buttonatras.Click += new System.EventHandler(this.buttonatras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 67);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoABC.Properties.Resources.Logo_Bank1;
            this.pictureBox1.Location = new System.Drawing.Point(21, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Iniciar_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonatras);
            this.Controls.Add(this.button_iniciar_sesion);
            this.Controls.Add(this.label_identificacion);
            this.Controls.Add(this.identificacion_text);
            this.Controls.Add(this.cuenta_text);
            this.Controls.Add(this.label_cuenta);
            this.Name = "Iniciar_sesion";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Iniciar_sesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cuenta;
        private System.Windows.Forms.TextBox cuenta_text;
        private System.Windows.Forms.TextBox identificacion_text;
        private System.Windows.Forms.Label label_identificacion;
        private System.Windows.Forms.Button button_iniciar_sesion;
        private System.Windows.Forms.Button buttonatras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}