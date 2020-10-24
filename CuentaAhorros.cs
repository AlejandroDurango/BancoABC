using System;
using System.Runtime.CompilerServices;

namespace BancoABC
{
    public class CuentaAhorros
    {

        private  int Numero_de_cuenta;
        private String Nombre_titular;
        private double Identificacion;
        private double Saldo;
        private int Pin;

        public CuentaAhorros(int numero_de_cuenta, string nombre_titular, double identificacion, double saldo, int pin)
        {
            Numero_de_cuenta = numero_de_cuenta;
            Nombre_titular = nombre_titular;
            Identificacion = identificacion;
            Saldo = saldo;
            Pin = pin;
        }

        public  int Numero_de_cuenta1 { get => Numero_de_cuenta; set => Numero_de_cuenta = value; }
        public  string Nombre_titular1 { get => Nombre_titular; set => Nombre_titular = value; }
        public  double Identificacion1 { get => Identificacion; set => Identificacion = value; }
        public double Saldo1 { get => Saldo; set => Saldo = value; }
        public int Pin1 { get => Pin; set => Pin = value; }

        public static bool Consignar(int numero_de_cuenta)
        {
            
            bool resultado = BancoCuentas.ExisteCuenta(numero_de_cuenta);
            if (!resultado)
            {
                AccountNoExistException ex = new AccountNoExistException("No existe el número de cuenta ingresado");
                throw ex;
            }
            else
            {
                return resultado;
            }
        }

        public static bool Retirar(int monto, int identificacion)
        {

            bool resultado = BancoCuentas.Retiro(monto, identificacion);
            if (!resultado)
            {
                AmountInsufficientException ex = new AmountInsufficientException("Fondos insuficientes");
                throw ex;
            }
            else
            {
                return resultado;
            }
        }

        public void Transferir(int numero_cuenta_destino, int monto)
        {
            int cont = 0;
            foreach (CuentaAhorros cuenta in BancoCuentas.getBanco())
            {
                if (numero_cuenta_destino == cuenta.Numero_de_cuenta1)
                {
                    if (monto <= 0)
                    {
                        NegativeAmountException ex = new NegativeAmountException("El monto a transferir no puede ser negativo");
                        throw ex;
                    }
                    else
                    {
                        cuenta.Saldo1 += monto;
                        Saldo -= monto;
                        return;
                    }
                }
                cont++;
            }
            if(cont == BancoCuentas.getBanco().Count)
            {
                AccountNoExistException ex = new AccountNoExistException("La cuenta ingresada no existe");
                throw ex;
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
