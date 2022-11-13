using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Suma.

            int numero1, numero2, resultado;

            Console.WriteLine("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = int.Parse(Console.ReadLine());

            resultado = numero1 + numero2;

            Console.WriteLine("El resultado de la suma es: " + resultado);

        }
    }
}
