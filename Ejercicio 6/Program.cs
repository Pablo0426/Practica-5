using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorA = { 2, 4, 6 };
            int[] vectorB = { 1, 3, 5 };
            int productoEscalar = 0;

            Console.WriteLine("El producto escalar de los vectores " +
                "A = { 2, 4, 6 } y B = { 1, 3, 5 } es: ");

            for (int i = 0; i < 3; i++)
            {
                productoEscalar = productoEscalar + (vectorA[i] * vectorB[i]);
            }

            Console.Write("El producto escalar es: ");
            Console.WriteLine(productoEscalar);

            Console.ReadKey();
        }
    }
}
