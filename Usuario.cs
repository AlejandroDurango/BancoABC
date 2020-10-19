using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

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
        
    }
}
