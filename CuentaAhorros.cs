using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace BancoABC
{
    class CuentaAhorros
    {
        private int Numero_de_cuenta;
        private String Nombre_titular;
        private int Identificacion;
        private double Saldo;

        public CuentaAhorros(int numero_de_cuenta, string nombre_titular, int identificacion, double saldo)
        {
            Numero_de_cuenta = numero_de_cuenta;
            Nombre_titular = nombre_titular;
            Identificacion = identificacion;
            Saldo = saldo;
        }

        public int Numero_de_cuenta1 { get => Numero_de_cuenta; set => Numero_de_cuenta = value; }
        public string Nombre_titular1 { get => Nombre_titular; set => Nombre_titular = value; }
        public int Identificacion1 { get => Identificacion; set => Identificacion = value; }
        public double Saldo1 { get => Saldo; set => Saldo = value; }

        public bool Consignar(int numero_de_cuenta)
        {
            BancoCuentas banco = new BancoCuentas();
            bool resultado = banco.ExisteCuenta(numero_de_cuenta);
            if(!resultado)
            {
                AccountNoExistException ex = new AccountNoExistException("No existe el número de cuenta ingresado");
                throw ex;
            }
            else
            {
                return resultado;
            }
        }

        public void Retirar(int saldo_retirar)
        {
            if(saldo_retirar < Saldo)
            {
                AmountInsufficientException ex = new AmountInsufficientException("Fondos insuficientes, tu saldo es: "+ Saldo);
                throw ex;
            }
            else
            {
                Saldo -= saldo_retirar;
            }
        }

        public void Transferir(int numero_cuenta_destino, int monto)
        {
            BancoCuentas banco = new BancoCuentas();
            List<CuentaAhorros> lista_cuentas = banco.getBanco();
            foreach(CuentaAhorros cuenta in lista_cuentas)
            {
                if(numero_cuenta_destino == cuenta.Numero_de_cuenta1)
                {
                    if(monto <= 0)
                    {
                        NegativeAmountException ex = new NegativeAmountException("El monto a transferir no puede ser negativo");
                    }
                    else
                    {
                        cuenta.Saldo += monto;
                    }
                }
            }
        }
    }

    // Excepciones utilizadas para la implementación
    class CuentaAhorrosException : Exception
    {
        private String Mensaje;
        public CuentaAhorrosException(String mensaje)
        {
            Mensaje = mensaje;
        }

        public String getMensaje()
        {
            return Mensaje;
        }
    }

    class AccountNoExistException : CuentaAhorrosException
    {
        public AccountNoExistException(String mensaje) : base(mensaje)
        {
        }
    }

    class AmountInsufficientException : CuentaAhorrosException
    {
        public AmountInsufficientException(String mensaje) : base(mensaje)
        {
        }
    }

    class NegativeAmountException : CuentaAhorrosException
    {
        public NegativeAmountException(String mensaje) : base(mensaje)
        {
        }
    }
}
