namespace BancoABC
{
    partial class Transacciones
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
            this.title_transacciones = new System.Windows.Forms.Label();
            this.button_consignar = new System.Windows.Forms.Button();
            this.Button_retirar = new System.Windows.Forms.Button();
            this.Tranferencia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_transacciones
            // 
            this.title_transacciones.AutoSize = true;
            this.title_transacciones.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_transacciones.Location = new System.Drawing.Point(12, 131);
            this.title_transacciones.Name = "title_transacciones";
            this.title_transacciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title_transacciones.Size = new System.Drawing.Size(322, 36);
            this.title_transacciones.TabIndex = 5;
            this.title_transacciones.Text = "¿Que desea hacer?";
            this.title_transacciones.Click += new System.EventHandler(this.title_consignacion_Click);
            // 
            // button_consignar
            // 
            this.button_consignar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_consignar.Location = new System.Drawing.Point(64, 185);
            this.button_consignar.Name = "button_consignar";
            this.button_consignar.Size = new System.Drawing.Size(198, 47);
            this.button_consignar.TabIndex = 16;
            this.button_consignar.Text = "Consignar";
            this.button_consignar.UseCompatibleTextRendering = true;
            this.button_consignar.UseVisualStyleBackColor = true;
            this.button_consignar.UseWaitCursor = true;
            this.button_consignar.Click += new System.EventHandler(this.button_consignar_Click);
            // 
            // Button_retirar
            // 
            this.Button_retirar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Button_retirar.Location = new System.Drawing.Point(64, 241);
            this.Button_retirar.Name = "Button_retirar";
            this.Button_retirar.Size = new System.Drawing.Size(198, 47);
            this.Button_retirar.TabIndex = 17;
            this.Button_retirar.Text = "Retirar";
            this.Button_retirar.UseCompatibleTextRendering = true;
            this.Button_retirar.UseVisualStyleBackColor = true;
            this.Button_retirar.UseWaitCursor = true;
            this.Button_retirar.Click += new System.EventHandler(this.Button_retirar_Click);
            // 
            // Tranferencia
            // 
            this.Tranferencia.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Tranferencia.Location = new System.Drawing.Point(64, 303);
            this.Tranferencia.Name = "Tranferencia";
            this.Tranferencia.Size = new System.Drawing.Size(198, 47);
            this.Tranferencia.TabIndex = 18;
            this.Tranferencia.Text = "Tranferir";
            this.Tranferencia.UseCompatibleTextRendering = true;
            this.Tranferencia.UseVisualStyleBackColor = true;
            this.Tranferencia.UseWaitCursor = true;
            this.Tranferencia.Click += new System.EventHandler(this.Tranferencia_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Location = new System.Drawing.Point(91, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoABC.Properties.Resources.Logo_Bank1;
            this.pictureBox1.Location = new System.Drawing.Point(112, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tranferencia);
            this.Controls.Add(this.Button_retirar);
            this.Controls.Add(this.button_consignar);
            this.Controls.Add(this.title_transacciones);
            this.Name = "Transacciones";
            this.Text = "Transacciones";
            this.Load += new System.EventHandler(this.Transacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_transacciones;
        private System.Windows.Forms.Button button_consignar;
        private System.Windows.Forms.Button Button_retirar;
        private System.Windows.Forms.Button Tranferencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}