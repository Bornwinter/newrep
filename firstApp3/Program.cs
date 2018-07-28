using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(2, 3);
         
        }
        class Calculator
        {
            public static void Add (int x, int y)
            {
                int z = x + y;
                Console.WriteLine($"Сумма {x} + {y} = {z}");
                Console.ReadKey();

            }
        }
    }
}
