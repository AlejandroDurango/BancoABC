namespace BancoABC
{
    partial class Menu_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_principal));
            this.Iniciar_sesion = new System.Windows.Forms.Button();
            this.Button_Registrarse = new System.Windows.Forms.Button();
            this.Estadisticos = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Iniciar_sesion
            // 
            this.Iniciar_sesion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Iniciar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Iniciar_sesion.Location = new System.Drawing.Point(39, 161);
            this.Iniciar_sesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Iniciar_sesion.Name = "Iniciar_sesion";
            this.Iniciar_sesion.Size = new System.Drawing.Size(132, 31);
            this.Iniciar_sesion.TabIndex = 0;
            this.Iniciar_sesion.Text = "Iniciar Sesión";
            this.Iniciar_sesion.UseCompatibleTextRendering = true;
            this.Iniciar_sesion.UseVisualStyleBackColor = true;
            this.Iniciar_sesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_Registrarse
            // 
            this.Button_Registrarse.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Button_Registrarse.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Button_Registrarse.Location = new System.Drawing.Point(39, 207);
            this.Button_Registrarse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Registrarse.Name = "Button_Registrarse";
            this.Button_Registrarse.Size = new System.Drawing.Size(132, 31);
            this.Button_Registrarse.TabIndex = 1;
            this.Button_Registrarse.Text = "Registrarse";
            this.Button_Registrarse.UseCompatibleTextRendering = true;
            this.Button_Registrarse.UseVisualStyleBackColor = true;
            this.Button_Registrarse.UseWaitCursor = true;
            this.Button_Registrarse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Estadisticos
            // 
            this.Estadisticos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Estadisticos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Estadisticos.Location = new System.Drawing.Point(119, 262);
            this.Estadisticos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Estadisticos.Name = "Estadisticos";
            this.Estadisticos.Size = new System.Drawing.Size(88, 23);
            this.Estadisticos.TabIndex = 2;
            this.Estadisticos.Text = "Estadisticas";
            this.Estadisticos.UseCompatibleTextRendering = true;
            this.Estadisticos.UseVisualStyleBackColor = true;
            this.Estadisticos.UseWaitCursor = true;
            this.Estadisticos.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(8, 265);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 19);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(39, 22);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(133, 130);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 292);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Estadisticos);
            this.Controls.Add(this.Button_Registrarse);
            this.Controls.Add(this.Iniciar_sesion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu_principal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menú_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_Registrarse;
        private System.Windows.Forms.Button Estadisticos;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Exit;
        public System.Windows.Forms.Button Iniciar_sesion;
    }
}