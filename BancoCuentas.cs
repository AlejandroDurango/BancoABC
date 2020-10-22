﻿using System;
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

        public  BancoCuentas()
        {
            Cuentas = new List<CuentaAhorros>();
             
        }

        public class Variables
         {
            public static Menu_principal Menu_Principal = new Menu_principal() ;
            public static Registrarse Registrarse = new Registrarse();
            public static Iniciar_sesion Iniciar_Sesion = new Iniciar_sesion();

        }
        public void actualizar_lista(Registrarse envio_datos )
        {
            //Cuentas += envio_datos.;
        }

        public void AñadirCuenta(CuentaAhorros cuenta)
        {
           Cuentas.Add(cuenta);
        }

        public void actualizar (BancoCuentas Cuenta)
        {
            //Cuentas.Add(Cuenta);
        }

        // referenciado en CuentaAhorros para implementar método consignar
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

        
        public bool IniciarSesion(int numero_cuenta, double identificacion)
        {  ;
            foreach(CuentaAhorros cuenta in Cuentas)
            {
              if(numero_cuenta == cuenta.Numero_de_cuenta1)
                {
                    if(identificacion == cuenta.Identificacion1)
                    {
                        return true ;
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
