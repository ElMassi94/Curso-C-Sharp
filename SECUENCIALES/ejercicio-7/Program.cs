using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
             //Hacer un programa para ingresar por teclado los metros cuadrados totales de
            //un predio y los metros cuadrados cubiertos; luego calcular y mostrar por
           //pantalla el porcentaje de metros cuadrados cubiertos y el porcentaje de
          //metros cuadrados descubiertos.

          int metroscuadradosTotales, metroscuadradosCubiertos, metrosDescubiertos, promedioDescubiertos, promedioCubiertos;

          Console.WriteLine("Ingrese los metros cuadrados totales: ");
          metroscuadradosTotales = int.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese los metros cuadrados cubiertos: ");
          metroscuadradosCubiertos = int.Parse(Console.ReadLine());

          metrosDescubiertos = metroscuadradosTotales - metroscuadradosCubiertos;
          promedioCubiertos = (metroscuadradosCubiertos * 100) / metroscuadradosTotales;
          promedioDescubiertos = (metrosDescubiertos * 100) / metroscuadradosTotales;

          Console.WriteLine("El promedio de los metros cuadrados cubiertos es: " + promedioCubiertos);
          Console.WriteLine("El promedio de los metros cuadrados descubiertos es: " + promedioDescubiertos);

        }
    }
}
