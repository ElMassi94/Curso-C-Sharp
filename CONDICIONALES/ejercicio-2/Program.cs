using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar dos números distintos y luego se muestre por
           //pantalla el menor de ellos.

           int numero1, numero2;

           Console.WriteLine("ingresar el primer numero: ");
           numero1 = int.Parse(Console.ReadLine());
           Console.WriteLine("ingresar el segundo numero: ");
           numero2 = int.Parse(Console.ReadLine());

           if(numero1 < numero2)
           {
            Console.WriteLine("El menor es: " + numero1);
           }else
           {
            Console.WriteLine("El menor es: " + numero2);
           }

           Console.WriteLine("Fin del Programa ");
        }
    }
}
