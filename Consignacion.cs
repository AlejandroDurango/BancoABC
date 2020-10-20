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
    public partial class Consignacion : Form
    {
        public Consignacion()
        {
            InitializeComponent();
            
        }

        private void title_whatdoing_Click(object sender, EventArgs e)
        {

        }


        private void form_consignacion_Load(object sender, EventArgs e)
        {

        }

        private void buttonatras_Click(object sender, EventArgs e)
        {
          
            
            Consignacion.ActiveForm.Hide();
            Form anterior = new Transacciones();
            anterior.Show();

        }

        private void Consignacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button_verifica_consignacion_Click(object sender, EventArgs e)
        {

        }

        private void label_result_retiro_Click(object sender, EventArgs e)
        {

        }

        private void button_tranferir_consignacion_Click(object sender, EventArgs e)
        {
            Consignacion.ActiveForm.Hide();
            Form nuevatranferencia = new Tranferencias();
            nuevatranferencia.Show();
        }
    }
}
