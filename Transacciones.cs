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

        private void title_consignacion_Click(object sender, EventArgs e)
        {

        }

        private void button_consignar_Click(object sender, EventArgs e)
        {
            Transacciones.ActiveForm.Hide();
            Form nueva_consignacion = new Consignacion();
            nueva_consignacion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            BancoCuentas.Variables.Iniciar_Sesion.Visible = true;

        }

        private void Transacciones_Load(object sender, EventArgs e)
        {

        }

        private void Button_retirar_Click(object sender, EventArgs e)
        {
            Transacciones.ActiveForm.Hide();
            Form nuevoretiro = new Retiro();
            nuevoretiro.Show();
        }

        private void Tranferencia_Click(object sender, EventArgs e)
        {
            Transacciones.ActiveForm.Hide();
            Form nuevatranferencia = new Tranferencias();
            nuevatranferencia.Show();
        }
    }
}

