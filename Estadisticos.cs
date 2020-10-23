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
    public partial class Estadisticos : Form
    {
        public Estadisticos()
        {
            InitializeComponent();
        }

        private void buttonatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            BancoCuentas.Variables.Menu_Principal.Visible = true ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Estadisticos_Load(object sender, EventArgs e)
        {
          

        }
    }
}
