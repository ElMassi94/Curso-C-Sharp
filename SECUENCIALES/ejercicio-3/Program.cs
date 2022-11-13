using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar el año actual y el año de la fecha de
           //nacimiento de una persona y luego calcule y emita por pantalla su edad.
           //Nota: no hay que tener en cuenta si la persona cumplió años o no,
           //simplemente calcular.

           int añoActual, añoNacimiento, edad;
           
           Console.WriteLine("Ingrese el año actual: ");
           añoActual = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese su año de nacimiento: ");
           añoNacimiento = int.Parse(Console.ReadLine());

           edad = añoActual - añoNacimiento;

           Console.WriteLine("Tu edad es: " + edad);
        }
    }
}
