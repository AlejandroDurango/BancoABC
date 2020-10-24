using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BancoABC
{
    public class BancoCuentas
    {
       
        private static List<CuentaAhorros> Cuentas;
        public static int Total_cosignaciones;
        public static int Total_retiros;
        public static int Total_operaciones;
        public static String Cliente_mayor;
        public static int Monto_mayor;

        public  BancoCuentas()
        {
            Cuentas = new List<CuentaAhorros>();
            Total_cosignaciones = 0;
            Total_retiros = 0;
            Cliente_mayor = "";
            Monto_mayor = 0;
        }

        public class Variables
        {
            public static Menu_principal Menu_Principal = new Menu_principal();
            public static Registrarse Registrarse = new Registrarse();
            public static Iniciar_sesion Iniciar_Sesion = new Iniciar_sesion();
            public static Transacciones Transacciones = new Transacciones();
            public static Estadisticos Estadisticos = new Estadisticos();
            public static Consignacion Consignar = new Consignacion();
            public static Retiro Retiro = new Retiro();
            public static Tranferencias Tranferencias = new Tranferencias();

        }

        public void AñadirCuenta(CuentaAhorros cuenta)
        {
           Cuentas.Add(cuenta);
        }

        // referenciado en CuentaAhorros para implementar método consignar
        public static bool ExisteCuenta(int numero_de_cuenta)
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

        public static bool Retiro(int monto, int identificacion)
        {
            foreach (CuentaAhorros cuenta in Cuentas)
            {
                if (cuenta.Identificacion1 == identificacion)
                {
                    if(monto <= cuenta.Saldo1)
                    {
                        cuenta.Saldo1 -= monto;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    AccountNoExistException ex = new AccountNoExistException("La cuenta ingresada no existe");
                }

            }

            return false;
        }


        public static List<CuentaAhorros> getBanco()
        {
            return Cuentas;
        }

        
        public bool IniciarSesion(int identificacion,int pin)
        {
            foreach(CuentaAhorros cuenta in Cuentas)
            {
              if(identificacion == cuenta.Identificacion1)
              {
                    if (pin == cuenta.Pin1)
                    {
                          return true;
                    }
              }
              
            }

            return false;
        }
    }

    class BancoException : Exception
    {
        private String Mensaje;
        public BancoException(String mensaje)
        {
            Mensaje = mensaje;
        }

        public String getMensaje()
        {
            return Mensaje;
        }
    }

    class AccountExistsException : BancoException
    {
        public AccountExistsException(String mensaje) : base(mensaje)
        {
        }
    }
}
