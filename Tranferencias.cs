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
            this.Close();
            BancoCuentas.Variables.Transacciones.Visible = true;
        }

        private void label_monto_retiro_Click(object sender, EventArgs e)
        {

        }

        private void lavel_monto_tranferir_Click(object sender, EventArgs e)
        {

        }

        private void button_tranferir_Click(object sender, EventArgs e)
        {
            try
            {
                int numero_cuenta = int.Parse(TextBox_numerocuenta_tranferir.Text);
                int monto_tranferir = int.Parse(textBox_monto_tranferir.Text);
                CuentaAhorros.Transferir(numero_cuenta, monto_tranferir);
                
                
            }
            catch (NegativeAmountException ex)
            {
                label_result_transferencia.Text = ex.getMensaje();
                label_result_transferencia.ForeColor = System.Drawing.Color.Red;
            }
            catch (FormatException)
            {
                label_result_transferencia.Text = "campos vacio, no se reconoce usuario";
                label_result_transferencia.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                TextBox_numerocuenta_tranferir.ResetText();
                textBox_monto_tranferir.ResetText();
            }
        }
    }
}
