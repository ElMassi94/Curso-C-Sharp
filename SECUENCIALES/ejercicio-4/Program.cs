using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar los kilómetros existentes entre dos
           //ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla
          //el tiempo aproximado que demandará llegar de un punto a otro teniendo en
         //cuenta los datos ingresados.

         int kilometros, velocidad, tiempo;

         Console.WriteLine("Ingrese los kilometros de distancia: ");
         kilometros = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese la velocidad promedio: ");
         velocidad = int.Parse(Console.ReadLine());

         tiempo = kilometros / velocidad;

         Console.WriteLine("El tiempo es: " + tiempo);
        }
    }
}
