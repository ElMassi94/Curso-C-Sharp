using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Hacer un programa para ingresar dos números y que luego emita por pantalla
                   //el mayor de ellos o un cartel aclaratorio “Son iguales” en el caso de que así sea.
                  //Nota: los números pueden ser iguales.


                  int numero1, numero2;

                  Console.WriteLine("ingrese un numero: ");
                  numero1 = int.Parse(Console.ReadLine());
                  Console.WriteLine("Ingrese otro numero: ");
                  numero2 = int.Parse(Console.ReadLine());

                  if(numero1 > numero2)
                  {
                    Console.WriteLine("El mayor es: " + numero1); 
                  }else if(numero1 == numero2)
                  {
                    Console.WriteLine("Son iguales. ");
                  }

                  Console.WriteLine("Fin del Programa ");


        }
    }
}
