using System;
using System.Collections.Generic;

namespace banco
{
    /// <summary>
    /// Clase Cuenta
    /// </summary>
    public class Cuenta
    {
        public List<Cliente> Titulares { get; set; }
        public long NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }

        /// <summary>
        /// Constructor que recibe parámetro
        /// </summary>
        /// <param name="numero">Numero de Cuenta</param>
        /// 
        public Cuenta(long numero)
        {
            this.NumeroCuenta = numero;
            this.Saldo = 0;
            this.Titulares = new List<Cliente>();
        }

        /// <summary>
        /// Metodo para retirar dinero, no es void por que nos retorna un saldo restante tras la extraccion
        /// </summary>
        /// <param name="cantidadARetirar">Suma de dinero a retirar, por lo que es un decimal</param>
        /// <returns>Saldo restante</returns>
        public bool RetirarDinero(decimal cantidad)        
        {
            if(Saldo >= cantidad)
            {
                this.Saldo -= cantidad; // this.Saldo = this.Saldo - cantidad;
                return true;
            }
            return false;
        }

        public bool DepositarDinero(decimal cantidad)
        {
            this.Saldo += cantidad;
            return true;
        }
    }
}
