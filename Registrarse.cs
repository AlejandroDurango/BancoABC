using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoABC
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void buttonatras_Click(object sender, EventArgs e)
        {
            Registrarse.ActiveForm.Hide();
            Form menu = new Menu_principal();
            menu.Show();
        }

        private void button_iniciar_sesion_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int Numero_de_cuenta = random.Next(100000001,int.MaxValue);
            String Nombre = (Textbox_nombres.Text +  " " + TextBox_apellidos.Text);
            int Identificacion = int.Parse(textBox_identificación.Text);
            int Saldoinicial = int.Parse(textBox_saldo.Text);
            double Saldo = 0;
            if (Saldoinicial >= 2000000)
            {
                   Saldo = Saldoinicial *0.05 + Saldoinicial;
            } 
            else
            {
                Saldo = Saldoinicial;
            }

            CuentaAhorros Nueva_cuenta = new CuentaAhorros(Numero_de_cuenta, Nombre, Identificacion, Saldo);
            BancoCuentas banco = new BancoCuentas();

            banco.AñadirCuenta(Nueva_cuenta);

            Textbox_nombres.ResetText();
            TextBox_apellidos.ResetText();
            textBox_identificación.ResetText();
            textBox_saldo.ResetText();
            label_result_registrarse.Text = "Registro Exitoso";
            label_result_registrarse.ForeColor = System.Drawing.Color.Green;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_indentificación_Click(object sender, EventArgs e)
        {

        }

        private void Textbox_nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_identificación_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_identificación_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
