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
    public partial class Transacciones : Form
    {
        public Transacciones()
        {
            InitializeComponent();
        }

        private void button_consignar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BancoCuentas.Variables.Consignar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            BancoCuentas.Variables.Menu_Principal.Visible = true;

        }

        private void Transacciones_Load(object sender, EventArgs e)
        {

        }

        private void Button_retirar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BancoCuentas.Variables.Retiro.Show();
        }

        private void Tranferencia_Click(object sender, EventArgs e)
        {
            this.Visible = false ;
            BancoCuentas.Variables.Tranferencias.Show();

        }
    }
}

