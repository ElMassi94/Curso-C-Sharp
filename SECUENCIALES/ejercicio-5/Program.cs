using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000
           //más una comisión del 5% sobre el total facturado por cada empleado. Hacer un
          //programa para ingresar el total facturado por un empleado y que luego calcule
         //y emita por pantalla el sueldo total a cobrar por el mismo.

         double totalFacturado, sueldoTotal, comision;
         double sueldoFijo = 15000;

         Console.WriteLine("Ingrese el total facturado: ");
         totalFacturado = double.Parse(Console.ReadLine());

         comision = totalFacturado * 0.05;
         sueldoTotal = sueldoFijo + comision;

         Console.WriteLine("El sueldo final a cobrar es de: " + sueldoTotal);

        }
    }
}
