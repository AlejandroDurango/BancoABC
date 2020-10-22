using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoABC
{
    public partial class Iniciar_sesion : Form
    {

        BancoCuentas banco = new BancoCuentas();

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

            Iniciar_sesion.ActiveForm.Hide();
            Form Transacciones = new Transacciones();
            Transacciones.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Iniciar_sesion_Load(object sender, EventArgs e)
        {

        }

        private void buttonatras_Click(object sender, EventArgs e)
        {
            foreach(CuentaAhorros cuenta in banco.getBanco())
            {
                if(int.Parse(cuenta_text.Text) == cuenta.Numero_de_cuenta1)
                {

                }
            }
            Iniciar_sesion.ActiveForm.Hide();
            Form menu = new Menu_principal();
            menu.Show();
        }

        private void cuenta_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
