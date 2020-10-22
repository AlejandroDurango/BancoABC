using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace BancoABC
{
    public partial class Iniciar_sesion : Form
    {
        Registrarse envio_datos = new Registrarse();
        BancoCuentas banco = new BancoCuentas();
        ControlValidacion validar = new ControlValidacion();

        public Iniciar_sesion()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero_cuenta = int.Parse(cuenta_text.Text);
                double Identificacion = double.Parse(identificacion_text.Text);


                if (banco.IniciarSesion(numero_cuenta, Identificacion) == true)
                {
                    Iniciar_sesion.ActiveForm.Hide();
                    Form Transacciones = new Transacciones();
                    Transacciones.Show();
                }
                else
                {
                    throw new AccountExistsException("Datos incorrectos,Por favor verificalos");
                }
            }
           
        
            catch (AccountExistsException ex)
            {
                label2.Text = ex.getMensaje();
                label2.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Iniciar_sesion_Load(object sender, EventArgs e)
        {

        }

        private void buttonatras_Click(object sender, EventArgs e)
        {
            Iniciar_sesion.ActiveForm.Hide();
            Form menu = new Menu_principal();
            menu.Show();
        }
        private void cuenta_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }

        private void identificacion_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.OnlyNumbers(e);
        }
        private void cuenta_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
