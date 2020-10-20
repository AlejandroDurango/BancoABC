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
    public partial class Tranferencias : Form
    {
        public Tranferencias()
        {
            InitializeComponent();
        }

        private void buttonatras_Click(object sender, EventArgs e)
        {
            Tranferencias.ActiveForm.Hide();
            Form anterior = new Transacciones();
            anterior.Show();
        }

        private void label_monto_retiro_Click(object sender, EventArgs e)
        {

        }

        private void lavel_monto_tranferir_Click(object sender, EventArgs e)
        {

        }

        private void label_result_retiro_Click(object sender, EventArgs e)
        {

        }
    }
}
