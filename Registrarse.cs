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
        BancoCuentas banco = new BancoCuentas();
        ControlValidacion validacion = new ControlValidacion();

        public Registrarse()
        {
            InitializeComponent();
            Console.WriteLine(BancoCuentas.getBanco().Count);
        }
      
        private void buttonatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            BancoCuentas.Variables.Menu_Principal.Visible = true;


        }

        private void button_registrar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(BancoCuentas.getBanco().Count);
            Random random = new Random();
            int Numero_de_cuenta = random.Next(100000001,int.MaxValue);
            try
            {
                String Nombre = (Textbox_nombres.Text + " " + TextBox_apellidos.Text);
                double Identificacion = double.Parse(textBox_identificación.Text);
                int Saldoinicial = int.Parse(textBox_saldo.Text);
                int Pin = int.Parse(text_pin.Text);
                double Saldo = 0;
                if (Saldoinicial >= 2000000)
                {
                    Saldo = Saldoinicial * 0.05 + Saldoinicial;
                }
                else
                {
                    Saldo = Saldoinicial;
                }
                CuentaAhorros Nueva_cuenta = new CuentaAhorros(Numero_de_cuenta, Nombre, Identificacion, Saldo, Pin);
                int cont = 0;
                if (BancoCuentas.getBanco().Count == 0)
                {
                    banco.AñadirCuenta(Nueva_cuenta);
                    Textbox_nombres.ResetText();
                    TextBox_apellidos.ResetText();
                    textBox_identificación.ResetText();
                    textBox_saldo.ResetText();
                    text_pin.ResetText();
                    label_result_registrarse.Text = "Registro Exitoso";
                    label_result_registrarse.ForeColor = System.Drawing.Color.Green;
                    cont = 0;
                }
                else
                {
                    while (cont < BancoCuentas.getBanco().Count)
                    {
                        if (Nueva_cuenta.Identificacion1 == BancoCuentas.getBanco()[cont].Identificacion1)
                        {
                            throw new AccountExistsException("Error, Usuario ya registrado");
                        }
                        cont++;
                    }

                    banco.AñadirCuenta(Nueva_cuenta);
                    Textbox_nombres.ResetText();
                    TextBox_apellidos.ResetText();
                    textBox_identificación.ResetText();
                    textBox_saldo.ResetText();
                    text_pin.ResetText();
                    label_result_registrarse.Text = "Registro Exitoso";
                    label_result_registrarse.ForeColor = System.Drawing.Color.Green;
                    cont = 0;
                }
            }
            catch (FormatException ex)
            {
                label_result_registrarse.Text = "Campos vacios, por favor llenar los datos";
                label_result_registrarse.ForeColor = System.Drawing.Color.Red;
            }
            catch (AccountExistsException ex)
            {
                label_result_registrarse.Text = ex.getMensaje();
                label_result_registrarse.ForeColor = System.Drawing.Color.Red;
                Textbox_nombres.ResetText();
                TextBox_apellidos.ResetText();
                textBox_identificación.ResetText();
                textBox_saldo.ResetText();
                text_pin.ResetText();
            }



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

        private void Textbox_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.OnlyLetters(e);
        }

        private void TextBox_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.OnlyLetters(e);
        }

        private void textBox_identificación_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.OnlyNumbers(e);
        }

        private void textBox_saldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.OnlyNumbers(e);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void text_pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.OnlyNumbers(e);
        }
    }
}
