using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 9, 15, 1, 14, 8, 7, 6, 5 };
            int suma = 0;
            int promedio;
            numeros.Sort();
            for(int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
                suma = suma + numeros[i];
            }
            Console.WriteLine("------------------------------------------");
            promedio = suma / numeros.Count;
            Console.WriteLine("La suma de todos los numeros es: "+suma);
            Console.WriteLine("El promedio dio como resultado: "+promedio);
            Console.ReadKey();
        }
    }
}
