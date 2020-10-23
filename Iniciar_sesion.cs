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
                int contraseña = int.Parse(contraseña_text.Text);
                if (banco.IniciarSesion(contraseña) == true)
                {
                    this.Hide();
                    this.label2.Text = "Ingresa a Tus Sueños";
                    BancoCuentas.Variables.Transacciones.Show();
                }
                else
                {
                    throw new AccountExistsException("No existe el número de cuenta ingresado");
                }
            }
            catch (AccountExistsException ex)
            {
                label2.Text = ex.getMensaje();
                label2.ForeColor = System.Drawing.Color.Red;
            }
            catch(FormatException )
            {
                label2.Text = "campos vacio, no se reconoce usuario";
                label2.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                contraseña_text.ResetText();
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
            this.Hide();
            BancoCuentas.Variables.Menu_Principal.Visible = true;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
