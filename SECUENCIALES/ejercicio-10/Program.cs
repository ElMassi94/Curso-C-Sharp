using System;

namespace ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar por teclado dos números y que luego
            //muestre por pantalla la suma, la resta, la multiplicación y la división de dichos
            //números. Se deben mostrar cuatro resultados en pantalla. Los números deben
            //ser solicitados una única vez.

            int numero1, numero2, resultadoSuma, resultadoResta, resultadoMultiplicacion, resultadoDivision;

            Console.WriteLine("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            resultadoSuma = numero1 + numero2;
            resultadoResta =  numero1 - numero2;
            resultadoMultiplicacion = numero1 * numero2;
            resultadoDivision = numero1 / numero2;

            Console.WriteLine("El resultado de la suma es: " + resultadoSuma);
            Console.WriteLine("El resultado de la resta es: " + resultadoResta);
            Console.WriteLine("El resultado de la multiplicacion es: " + resultadoMultiplicacion);
            Console.WriteLine("El resultado de la division es: " + resultadoDivision);   
        }   
    }
}    
