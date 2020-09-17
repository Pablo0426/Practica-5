using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorA = { 2, 4, 6 };
            int[] vectorB = { 1, 3, 5 };
            Console.WriteLine("El producto de los vectores " +
                "A = { 2, 4, 6 } y B = { 1, 3, 5 } es: ");
            int[] producto = new int[3];
            for (int i = 0; i < 3; i++)
            {
                producto[i] = vectorA[i] * vectorB[i];
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(producto[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
