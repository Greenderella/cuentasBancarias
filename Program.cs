using System;
using System.Collections.Generic;

namespace banco
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio de cuentas");
            // creamos la persona1
            Cliente Frodo = new Cliente();
            Frodo.Nombre = "Frodo";
            Frodo.Apellido = "Bolson";
            Frodo.Mail = "asd@asd.com";
            Frodo.Telefono = 423376;
            Frodo.FechaDeNacimiento = new DateTime (200,5,1);

            // creamos la persona2
            Cliente Gandalf = new Cliente();
            Gandalf.Nombre = "Gandalf";
            Gandalf.Apellido = "They Grey";
            Gandalf.Mail = "asd@asd.com";
            Gandalf.Telefono = 423375;
            Gandalf.FechaDeNacimiento = new DateTime (4,1,1);

            // creamos la cuenta
            Cuenta cuenta1 = new Cuenta(2345124132);
            cuenta1.Saldo = 0;
            // le damos una cuenta a Frodo
            cuenta1.Titulares.Add(Frodo);
            cuenta1.Titulares.Add(Gandalf);
            
            Cuenta cuenta2 = new Cuenta(348438);
            cuenta2.Titulares.Add(Gandalf);

            if(cuenta1.DepositarDinero(400))
            {
                Console.WriteLine("Operación OK");
            }
            if(cuenta1.RetirarDinero(200))
            {
                Console.WriteLine("Operación OK");
            }
            if(cuenta1.RetirarDinero(300))
            {
                Console.WriteLine("Operación OK");
            }

            Console.WriteLine("La cuenta1 tiene un saldo: " + cuenta1.Saldo);
            foreach(Cliente titular in cuenta1.Titulares)
            {
                Console.WriteLine("La cuenta1 tiene el titular: " + titular.NombreCompleto());
            }
            cuenta1.DepositarDinero(4000);
            cuenta1.RetirarDinero(6000);

            Console.WriteLine("Saldo actual de la cuenta en pesos ($): " + cuenta1.Saldo);
        }
    }
}

