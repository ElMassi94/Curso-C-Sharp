using System;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una universidad desea conocer los porcentajes de mujeres y hombres en las
           //carreras de ciencias exactas. Se solicita un programa para cargar la cantidad de
          //mujeres y la cantidad de hombres y que el mismo calcule y emita por pantalla
         //los porcentajes correspondientes.

         int cantidadAlumnos, cantidadMujeres, cantidadHombres, porcentajeMujeres, porcentajeHombres;

         Console.WriteLine("Ingrese la cantidad de mujeres: ");
         cantidadMujeres = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese la cantidad de hombres: ");
         cantidadHombres = int.Parse(Console.ReadLine());

         cantidadAlumnos = cantidadMujeres + cantidadHombres;

         porcentajeMujeres = (cantidadMujeres * 100) / cantidadAlumnos;
         porcentajeHombres = (cantidadHombres * 100) / cantidadAlumnos;

         Console.WriteLine("El porcentaje de mujeres es: " + porcentajeMujeres);
         Console.WriteLine("El porcentaje de hombres es:" +porcentajeHombres);

        }
    }
}
