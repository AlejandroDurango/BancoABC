﻿namespace BancoABC
{
    partial class Registrarse
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
            this.button_Registrook = new System.Windows.Forms.Button();
            this.label_nombre = new System.Windows.Forms.Label();
            this.Textbox_nombres = new System.Windows.Forms.TextBox();
            this.label_registrate = new System.Windows.Forms.Label();
            this.label_apellidos = new System.Windows.Forms.Label();
            this.TextBox_apellidos = new System.Windows.Forms.TextBox();
            this.label_indentificación = new System.Windows.Forms.Label();
            this.textBox_identificación = new System.Windows.Forms.TextBox();
            this.label_result_registrarse = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_saldo = new System.Windows.Forms.Label();
            this.textBox_saldo = new System.Windows.Forms.TextBox();
            this.label_anota = new System.Windows.Forms.Label();
            this.label_cuenta = new System.Windows.Forms.Label();
            this.label_pin = new System.Windows.Forms.Label();
            this.text_pin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.buttonatras.TabIndex = 23;
            this.buttonatras.Text = "Atras";
            this.buttonatras.UseVisualStyleBackColor = true;
            this.buttonatras.Click += new System.EventHandler(this.buttonatras_Click);
            // 
            // button_Registrook
            // 
            this.button_Registrook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Registrook.Location = new System.Drawing.Point(84, 246);
            this.button_Registrook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Registrook.Name = "button_Registrook";
            this.button_Registrook.Size = new System.Drawing.Size(78, 32);
            this.button_Registrook.TabIndex = 24;
            this.button_Registrook.Text = "Registrar";
            this.button_Registrook.UseVisualStyleBackColor = true;
            this.button_Registrook.Click += new System.EventHandler(this.button_registrar_Click);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(8, 127);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(53, 17);
            this.label_nombre.TabIndex = 25;
            this.label_nombre.Text = "Nombres:";
            this.label_nombre.UseCompatibleTextRendering = true;
            // 
            // Textbox_nombres
            // 
            this.Textbox_nombres.AcceptsTab = true;
            this.Textbox_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_nombres.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Textbox_nombres.Location = new System.Drawing.Point(75, 124);
            this.Textbox_nombres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Textbox_nombres.Name = "Textbox_nombres";
            this.Textbox_nombres.Size = new System.Drawing.Size(174, 20);
            this.Textbox_nombres.TabIndex = 26;
            this.Textbox_nombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Textbox_nombres.TextChanged += new System.EventHandler(this.Textbox_nombres_TextChanged);
            this.Textbox_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_nombres_KeyPress);
            // 
            // label_registrate
            // 
            this.label_registrate.AutoSize = true;
            this.label_registrate.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registrate.Location = new System.Drawing.Point(32, 71);
            this.label_registrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_registrate.Name = "label_registrate";
            this.label_registrate.Size = new System.Drawing.Size(159, 38);
            this.label_registrate.TabIndex = 27;
            this.label_registrate.Text = "Registrate:";
            this.label_registrate.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.Location = new System.Drawing.Point(8, 152);
            this.label_apellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(53, 17);
            this.label_apellidos.TabIndex = 28;
            this.label_apellidos.Text = "Apellidos:";
            this.label_apellidos.UseCompatibleTextRendering = true;
            this.label_apellidos.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TextBox_apellidos
            // 
            this.TextBox_apellidos.AcceptsTab = true;
            this.TextBox_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_apellidos.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.TextBox_apellidos.Location = new System.Drawing.Point(75, 152);
            this.TextBox_apellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_apellidos.Name = "TextBox_apellidos";
            this.TextBox_apellidos.Size = new System.Drawing.Size(174, 20);
            this.TextBox_apellidos.TabIndex = 29;
            this.TextBox_apellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_apellidos_KeyPress);
            // 
            // label_indentificación
            // 
            this.label_indentificación.AutoSize = true;
            this.label_indentificación.Location = new System.Drawing.Point(0, 177);
            this.label_indentificación.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_indentificación.Name = "label_indentificación";
            this.label_indentificación.Size = new System.Drawing.Size(74, 17);
            this.label_indentificación.TabIndex = 30;
            this.label_indentificación.Text = "Identificación:";
            this.label_indentificación.UseCompatibleTextRendering = true;
            this.label_indentificación.Click += new System.EventHandler(this.label_indentificación_Click);
            // 
            // textBox_identificación
            // 
            this.textBox_identificación.AcceptsTab = true;
            this.textBox_identificación.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_identificación.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.textBox_identificación.Location = new System.Drawing.Point(75, 175);
            this.textBox_identificación.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_identificación.Name = "textBox_identificación";
            this.textBox_identificación.Size = new System.Drawing.Size(174, 20);
            this.textBox_identificación.TabIndex = 31;
            this.textBox_identificación.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_identificación.TextChanged += new System.EventHandler(this.textBox_identificación_TextChanged);
            this.textBox_identificación.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_identificación_KeyPress);
            // 
            // label_result_registrarse
            // 
            this.label_result_registrarse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_result_registrarse.AutoSize = true;
            this.label_result_registrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result_registrarse.ForeColor = System.Drawing.Color.Black;
            this.label_result_registrarse.Location = new System.Drawing.Point(11, 280);
            this.label_result_registrarse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_result_registrarse.Name = "label_result_registrarse";
            this.label_result_registrarse.Size = new System.Drawing.Size(224, 13);
            this.label_result_registrarse.TabIndex = 32;
            this.label_result_registrarse.Text = "Unete a Nosotros y ¡Crecemos Juntos!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoABC.Properties.Resources.Logo_Bank1;
            this.pictureBox1.Location = new System.Drawing.Point(75, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label_saldo
            // 
            this.label_saldo.AutoSize = true;
            this.label_saldo.Location = new System.Drawing.Point(23, 198);
            this.label_saldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_saldo.Name = "label_saldo";
            this.label_saldo.Size = new System.Drawing.Size(36, 17);
            this.label_saldo.TabIndex = 33;
            this.label_saldo.Text = "Saldo:";
            this.label_saldo.UseCompatibleTextRendering = true;
            // 
            // textBox_saldo
            // 
            this.textBox_saldo.AcceptsTab = true;
            this.textBox_saldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_saldo.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.textBox_saldo.Location = new System.Drawing.Point(75, 199);
            this.textBox_saldo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_saldo.Name = "textBox_saldo";
            this.textBox_saldo.Size = new System.Drawing.Size(174, 20);
            this.textBox_saldo.TabIndex = 34;
            this.textBox_saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_saldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_saldo_KeyPress);
            // 
            // label_anota
            // 
            this.label_anota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_anota.AutoSize = true;
            this.label_anota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_anota.ForeColor = System.Drawing.Color.Black;
            this.label_anota.Location = new System.Drawing.Point(20, 289);
            this.label_anota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_anota.Name = "label_anota";
            this.label_anota.Size = new System.Drawing.Size(0, 13);
            this.label_anota.TabIndex = 35;
            // 
            // label_cuenta
            // 
            this.label_cuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cuenta.AutoSize = true;
            this.label_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuenta.ForeColor = System.Drawing.Color.Black;
            this.label_cuenta.Location = new System.Drawing.Point(20, 312);
            this.label_cuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cuenta.Name = "label_cuenta";
            this.label_cuenta.Size = new System.Drawing.Size(0, 13);
            this.label_cuenta.TabIndex = 36;
            // 
            // label_pin
            // 
            this.label_pin.AutoSize = true;
            this.label_pin.Location = new System.Drawing.Point(25, 225);
            this.label_pin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pin.Name = "label_pin";
            this.label_pin.Size = new System.Drawing.Size(26, 17);
            this.label_pin.TabIndex = 37;
            this.label_pin.Text = "PIN:";
            this.label_pin.UseCompatibleTextRendering = true;
            this.label_pin.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // text_pin
            // 
            this.text_pin.AcceptsTab = true;
            this.text_pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_pin.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.text_pin.Location = new System.Drawing.Point(75, 222);
            this.text_pin.Margin = new System.Windows.Forms.Padding(2);
            this.text_pin.Name = "text_pin";
            this.text_pin.Size = new System.Drawing.Size(174, 20);
            this.text_pin.TabIndex = 38;
            this.text_pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_pin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_pin_KeyPress);
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 348);
            this.Controls.Add(this.text_pin);
            this.Controls.Add(this.label_pin);
            this.Controls.Add(this.label_cuenta);
            this.Controls.Add(this.label_anota);
            this.Controls.Add(this.textBox_saldo);
            this.Controls.Add(this.label_saldo);
            this.Controls.Add(this.label_result_registrarse);
            this.Controls.Add(this.textBox_identificación);
            this.Controls.Add(this.label_indentificación);
            this.Controls.Add(this.TextBox_apellidos);
            this.Controls.Add(this.label_apellidos);
            this.Controls.Add(this.label_registrate);
            this.Controls.Add(this.Textbox_nombres);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.button_Registrook);
            this.Controls.Add(this.buttonatras);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonatras;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox Textbox_nombres;
        private System.Windows.Forms.Label label_registrate;
        private System.Windows.Forms.Label label_apellidos;
        private System.Windows.Forms.TextBox TextBox_apellidos;
        private System.Windows.Forms.Label label_indentificación;
        private System.Windows.Forms.TextBox textBox_identificación;
        private System.Windows.Forms.Label label_result_registrarse;
        private System.Windows.Forms.Label label_saldo;
        private System.Windows.Forms.TextBox textBox_saldo;
        private System.Windows.Forms.Label label_anota;
        private System.Windows.Forms.Label label_cuenta;
        public System.Windows.Forms.Button button_Registrook;
        private System.Windows.Forms.Label label_pin;
        private System.Windows.Forms.TextBox text_pin;
    }
}