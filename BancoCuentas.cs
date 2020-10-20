using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BancoABC
{
    class BancoCuentas
    {
        private List<CuentaAhorros> Cuentas;

        public BancoCuentas()
        {
            Cuentas = new List<CuentaAhorros>();
        }

        public void AñadirCuenta(CuentaAhorros cuenta)
        {
            Cuentas.Add(cuenta);
        }

        public bool ExisteCuenta(int numero_de_cuenta)
        {
            foreach(CuentaAhorros cuenta in Cuentas)
            {
                if(cuenta.Numero_de_cuenta1 == numero_de_cuenta)
                {
                    return true;
                }
            }

            return false;
        }

        public List<CuentaAhorros> getBanco()
        {
            return Cuentas;
        }
    }
}
