using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos numeros digitará? ");
            int n = int.Parse(Console.ReadLine());

            int[] listado = new int[n];
            for(int i = 0; i< n; i++)
            {
                listado[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i < n; i++)
            {
                Console.Write(listado[i]+" ");
            }

            Console.ReadKey();
        }
    }
}
