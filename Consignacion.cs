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
        ControlValidacion validacion = new ControlValidacion();
        
        public Consignacion()
        {
            InitializeComponent();
            
        }

        private void form_consignacion_Load(object sender, EventArgs e)
        {

        }

        private void buttonatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            BancoCuentas.Variables.Transacciones.Visible = true ;
        }

        private void Consignacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button_verifica_consignacion_Click(object sender, EventArgs e)
        {

            try
            {
                int numero_cuenta = int.Parse(cuenta_consignacion_text.Text);
                if (CuentaAhorros.Consignar(numero_cuenta) == true)
                {
                    label_result_consigna.Text = "La Cuenta Existe, Puedes Tranferir";
                    label_result_consigna.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    throw new AccountExistsException("Datos incorrectos,Por favor verificalos");
                }
            
            }
            catch (AccountExistsException ex)
            {
                label_result_consigna.Text = ex.getMensaje();
                label_result_consigna.ForeColor = System.Drawing.Color.Red;
            }
            catch (FormatException )
            {
                label_result_consigna.Text = "campos vacio, no se reconoce usuario";
                label_result_consigna.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                cuenta_consignacion_text.ResetText();
            }
        }

        private void button_tranferir_consignacion_Click(object sender, EventArgs e)
        {
            this.Close();
            BancoCuentas.Variables.Tranferencias.Show();
        }
        private void cuenta_consignacion_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.OnlyNumbers(e);
        }
    }
}
