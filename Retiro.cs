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
    public partial class Retiro : Form
    {
        public Retiro()
        {
            InitializeComponent();
        }

        private void buttonatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            BancoCuentas.Variables.Transacciones.Visible = true;
        }

        private void Retiro_Load(object sender, EventArgs e)
        {

        }

        private void button_verifica_retiro_Click(object sender, EventArgs e)
        {

            try
            {
                int monto = int.Parse(TextBox_monto_retirar.Text);
                

            }
            catch 
            {
            }
            
        }
    }
}
