using System;
using System.Collections.Generic;

namespace banco
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio de cuentas");
            // creamos la persona
            Cliente Frodo = new Cliente();
            Frodo.Nombre = "Frodo";
            Frodo.Apellido = "Bolson";
            Frodo.Mail = "asd@asd.com";
            Frodo.Telefono = 423376;
            Frodo.FechaDeNacimiento = new DateTime (200,5,1);
            // creamos la cuenta
            Cuenta cuenta1 = new Cuenta();
            cuenta1.NumeroCuenta = 2345124132;
            cuenta1.Saldo = 0;
            cuenta1.Titular = Frodo;

            cuenta1.DepositarDinero(4000);
            cuenta1.RetirarDinero(6000);

            Console.WriteLine("Saldo actual de la cuenta en pesos ($): " + cuenta1.Saldo);
        }
    }
}

