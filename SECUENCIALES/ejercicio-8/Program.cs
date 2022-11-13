using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
              //Una importante cadena de delivery cuenta con una promoción por tiempo
             //limitado en la que otorga un 15% de descuento sobre el total del valor de la
            //compra realizada. Hacer un programa para solicitar el monto total y el mismo
           //calcule y emita por pantalla el total a cobrar con el descuento aplicado.

           double montoTotal, totalaCobrar;

           Console.WriteLine("Ingrese el total de la venta: ");
           montoTotal = double.Parse(Console.ReadLine());

           totalaCobrar = montoTotal * 0.85;

           Console.WriteLine("El total a cobrar con el descuento es de: " + totalaCobrar);




        }
    }
}
