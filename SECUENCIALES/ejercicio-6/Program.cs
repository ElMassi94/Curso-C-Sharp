using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar por teclado las tres notas de exámenes de un
           //alumno y luego calcule y emita por pantalla el promedio final.

           int primernota, segundanota, tercernota, promediofinal;

           Console.WriteLine("Ingrese la primer nota del alumno: ");
           primernota = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese la segunda nota del alumno: ");
           segundanota = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese la tercer nota del alumno: ");
           tercernota = int.Parse(Console.ReadLine());

           promediofinal = (primernota + segundanota + tercernota) / 3;

           Console.WriteLine("El promedio final es: " + promediofinal);

        }
    }
}
