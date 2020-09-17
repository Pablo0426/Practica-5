using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> notas = new List<int>() { 90, 88, 92, 79 };

            for (int i = 0; i < notas.Count; i++)
            {
                Console.WriteLine(notas[i]);
            }

            Console.ReadKey();
        }
    }
}
