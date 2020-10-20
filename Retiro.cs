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
            Retiro.ActiveForm.Hide();
            Form anterior = new Transacciones();
            anterior.Show();
        }

        private void Retiro_Load(object sender, EventArgs e)
        {

        }
    }
}
