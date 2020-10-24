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

        private void button_generar_Click(object sender, EventArgs e)
        {
            result_totalconsignaciones.Text = BancoCuentas.Total_cosignaciones.ToString();
            result_totalconsignaciones.ForeColor = System.Drawing.Color.Green;

            result_totalretiros.Text = BancoCuentas.Total_retiros.ToString();
            result_totalretiros.ForeColor = System.Drawing.Color.Green;

            result_totaloperaciones.Text = BancoCuentas.Total_operaciones.ToString();
            result_totaloperaciones.ForeColor = System.Drawing.Color.Green;


        }
    }
}
