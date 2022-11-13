using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar por teclado un número y luego devolver su
            //valor elevado al cubo.

            int numero, resultado;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            resultado = numero * numero * numero;

            Console.WriteLine("El resultado elevado al cubo es: " + resultado);
        }
    }
}
