using System;

namespace banco
{
    /// <summary>
    /// Clase Cuenta
    /// </summary>
    
    public class Cuenta
    {
        //las clases que creamos son tipos de datos nuevos
        public Cliente Titular { get; set; }
        public long NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }

        /// <summary>
        /// Metodo para retirar dinero, no es void por que nos retorna un saldo restante tras la extraccion
        /// </summary>
        /// <param name="cantidadARetirar">Suma de dinero a retirar, por lo que es un decimal</param>
        /// <returns>Saldo restante</returns>
        
        public bool RetirarDinero(decimal cantidadARetirar)
        {
            if (Saldo >= cantidadARetirar)
            {
                this.Saldo -= cantidadARetirar;
                return true;
            }
            else 
            {
                return false;
            }  
        }

        /// <summary>
        /// Metodo para depositar dinero
        /// </summary>
        /// <param name="cantidadADepositar">Suma de dinero a depositar</param>
        /// <returns>Saldo actualizado</returns>
        
        public decimal DepositarDinero(decimal cantidadADepositar)
        {
            this.Saldo += cantidadADepositar;
            return this.Saldo;
        }
    }
}
