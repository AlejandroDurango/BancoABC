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
                 if (CuentaAhorros.Retirar(monto, Iniciar_sesion.id) == true)
                 {
                     label_result_retiro.Text = "Retiro realizado";
                     label_result_retiro.ForeColor = System.Drawing.Color.Green;
                     label_monto_retiro.Text = "Su saldo actual es: " + Iniciar_sesion.Cuenta.Saldo1;
                     BancoCuentas.Total_retiros += 1;
                     BancoCuentas.Total_operaciones += 1;
                 }
             }
             catch (FormatException)
             {
                 label_result_retiro.Text = "campo vacio, no se reconoce usuario";
                 label_result_retiro.ForeColor = System.Drawing.Color.Red;
             }
             catch (OverflowException)
             {
                 label_result_retiro.Text = "Cuenta ingresada no válida";
                 label_result_retiro.ForeColor = System.Drawing.Color.Red;
             }
             catch(AmountInsufficientException ex)
             {
                 label_result_retiro.Text = ex.getMensaje();
                 label_result_retiro.ForeColor = System.Drawing.Color.Red;
             }
             finally
             {
                 TextBox_monto_retirar.ResetText();
             }
        }
    }
}
